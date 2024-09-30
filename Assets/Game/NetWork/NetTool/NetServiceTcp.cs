using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using HyPb;
using UnityEngine;

public class NetServiceTcp : INetService
{
    Socket _client;
    CancellationTokenSource _cts = new CancellationTokenSource();
    NetMsgDispatcher _msgDispatcher = new NetMsgDispatcher();
    public NetServiceTcp()
    {
        _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    /// <summary>
    /// 连接服务主机
    /// </summary>
    /// <param name="host"></param>
    /// <param name="port"></param>
    /// <returns></returns>
    public async UniTask<bool> Connect(string host, int port)
    {
        try
        {
            await _client.ConnectAsync(host, port).AsUniTask();
            //开启消息调度器(主线程)
            _msgDispatcher.DispatchMsg(_cts.Token);
            //连接成功，开启发送和接收线程
            UniTask.RunOnThreadPool(UniTask.Action(SendAsync), cancellationToken: _cts.Token).Forget();
            UniTask.RunOnThreadPool(UniTask.Action(ReceiveAsync), cancellationToken: _cts.Token).Forget();
        }
        catch (SocketException e)
        {
            Debug.LogError(e.Message);
            return false;
        }
        return true;
    }

    /// <summary>
    /// 发送队列
    /// </summary>
    ConcurrentQueue<MsgPackageClient> _sendQueue = new ConcurrentQueue<MsgPackageClient>();

    /// <summary>
    /// 发送数据包任务
    /// </summary>
    /// <returns></returns>
    async UniTaskVoid SendAsync()
    {
        if (_client != null && _client.Connected)
        {
            while (true)
            {
                if (_sendQueue.TryDequeue(out MsgPackageClient packageClient))
                {
                    //包体数据
                    var msgBody = packageClient.ToByteArray();
                    //构造消息头
                    int msgBodyLength = msgBody.Length;
                    char msgHeaderFlag = 'L';
                    using var sendMemory = MemoryPool<byte>.Shared.Rent(_msgPackageHeaderLenght + msgBodyLength);
                    //只操作包头写入有效的字节长度
                    var headerMemoryBuffer = sendMemory.Memory.Slice(0, _msgPackageHeaderLenght);
                    //写入包体总长
                    BinaryPrimitives.WriteInt32BigEndian(headerMemoryBuffer.Span.Slice(0, 4), msgBodyLength);
                    //写入包头校验标识
                    headerMemoryBuffer.Span[4] = (byte)msgHeaderFlag;
                    //TODO包头数据加密

                    //包体内存Buffer
                    var msgBodyBuffer = sendMemory.Memory.Slice(5, msgBodyLength);
                    msgBody.CopyTo(msgBodyBuffer.Span);
                    //发送网络消息
                    try
                    {
                        var sendTotal = await _client.SendAsync(sendMemory.Memory.Slice(0, _msgPackageHeaderLenght + msgBodyLength), SocketFlags.None);
                        Debug.Log($"客户端发送网络数据包总长度:{sendTotal}");
                    }
                    catch (SocketException e)
                    {
                        Debug.LogError(e.Message);
                        DisConnect();
                        return;
                    }
                }
            }
        }
    }

    /// <summary>
    /// 包头总长
    /// </summary>
    int _msgPackageHeaderLenght = 5;

    /// <summary>
    /// 接收数据包任务
    /// </summary>
    /// <returns></returns>
    async UniTaskVoid ReceiveAsync()
    {
        if (_client != null && _client.Connected)
        {
            using var headerMemory = MemoryPool<byte>.Shared.Rent(_msgPackageHeaderLenght);
            //4字节包体长度+1字节包头标识
            var headerMemoryBuffer = headerMemory.Memory.Slice(0, _msgPackageHeaderLenght);
            while (true)
            {
                try
                {
                    //接收包头
                    int receiveHeaderTotal = 0;
                    while (receiveHeaderTotal < _msgPackageHeaderLenght)
                    {
                        int receiveCount = await _client.ReceiveAsync(headerMemoryBuffer, SocketFlags.None);
                        receiveHeaderTotal += receiveCount;
                        if (receiveCount == 0)//Sokect异常
                        {
                            Debug.LogError("接收远程主机字节数为0,客户端主动断开连接!!!");
                            DisConnect();
                            return;
                        }
                    }
                    //包头读取完毕
                    //读取包体总长
                    var msgBodyLength = BinaryPrimitives.ReadInt32BigEndian(headerMemoryBuffer.Span);
                    //接收包体
                    if (msgBodyLength <= 0)
                    {
                        Debug.LogError("服务主机返回的消息包体长度为0");
                        DisConnect();
                        return;
                    }
                    //租借一个存放包体字节数组
                    var msgBodyBuffer = ArrayPool<byte>.Shared.Rent(msgBodyLength);
                    //确保只操作有效的内存长度
                    var msgBodyBufferMemory = msgBodyBuffer.AsMemory().Slice(0, msgBodyLength);
                    int receiveBodyTotal = 0;
                    while (receiveBodyTotal < msgBodyLength)
                    {
                        int receiveCount = await _client.ReceiveAsync(msgBodyBufferMemory, SocketFlags.None);
                        receiveBodyTotal += receiveCount;
                        if (receiveCount == 0)//Sokect异常
                        {
                            Debug.LogError("接收远程主机字节数为0,客户端主动断开连接!!!");
                            DisConnect();
                            return;
                        }
                    }
                    //包体读取完毕
                    //解析包体
                    MsgPackageServer packageServer = MsgPackageServer.Parser.ParseFrom(msgBodyBufferMemory.Span);
                    //调度网络消息
                    _msgDispatcher.EnqueueMsgPackage(packageServer);
                    //归还租借的包体数组
                    ArrayPool<byte>.Shared.Return(msgBodyBuffer);
                }
                catch (SocketException e)
                {
                    Debug.LogError(e.Message);
                    return;
                }
            }
        }
    }

    /// <summary>
    /// 客户端记录发送消息序列号
    /// </summary>
    uint _msgSequence = 0;

    /// <summary>
    /// 网络消息，如果服务端没有业务返回值，建议传入IMessage作为填充返回类型，有业务返回值正常输入返回值类型
    /// </summary>
    public async UniTask<TMsgRes> SendAsync<TMsgRes, TMsgReq>(int cmd, TMsgReq sendMsg, MessageParser<TMsgRes> messageParser = null) where TMsgReq : IMessage where TMsgRes : IMessage<TMsgRes>, new()
    {
        var sendSequence = ++_msgSequence;
        //构造等待回包任务
        UniTaskCompletionSource<(MsgPackageServer, IMessage)> manualUniTaskCompletionSource = new();
        _msgDispatcher.RecoderResponseCompletion(sendSequence, manualUniTaskCompletionSource, cmd, messageParser);
        //把网络消息包入队
        MsgPackageClient packageClient = new MsgPackageClient();
        packageClient.MsgCode = cmd;
        packageClient.MsgData = sendMsg.ToByteString();
        packageClient.Sequence = sendSequence;
        _sendQueue.Enqueue(packageClient);
        //等待服务主机回包
        (MsgPackageServer serverPackage, IMessage logicMsgData) packageServer = await manualUniTaskCompletionSource.Task;
        //客户端统一处理逻辑，例如错误码等等
        return packageServer.logicMsgData != null ? (TMsgRes)packageServer.logicMsgData : default;
    }

    /// <summary>
    /// 添加服务器推送
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cmd"></param>
    /// <param name="cb"></param>
    /// <param name="messageParser"></param>
    public void AddServerPushListener<T>(int cmd, Action<T> cb, MessageParser<T> messageParser) where T : IMessage<T>
    {
        _msgDispatcher.AddServerPushListener(cmd, cb, messageParser);
    }

    /// <summary>
    /// 断开网络连接
    /// </summary>
    public void DisConnect()
    {
        if (_client != null && _client.Connected)
        {
            _client.Shutdown(SocketShutdown.Both);
            _client.Dispose();
        }
        if (!_cts.IsCancellationRequested)
        {
            _cts.Cancel();
            _cts.Dispose();
        }
    }
}