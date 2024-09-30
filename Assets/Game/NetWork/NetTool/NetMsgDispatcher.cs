using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using Google.Protobuf;
using HyPb;

public class NetMsgDispatcher
{
    List<Action<IMessage>> _listenerTemp = new();
    public void DispatchMsg(CancellationToken cancellation)
    {
        UniTaskAsyncEnumerable.EveryUpdate().ForEachAsync((asyncUnit) =>
        {

            //在主线程调度网络消息
            while (_msgs.Count > 0)
            {
                if (_msgs.TryDequeue(out var msgPackage))
                {
                    var cmd = msgPackage.Item1.MsgCode;
                    if (_serverPushListeners.TryGetValue(cmd, out var actions))
                    {
                        _listenerTemp.Clear();
                        _listenerTemp.AddRange(actions);
                        foreach (var item in _listenerTemp)
                        {
                            item(msgPackage.Item2);
                        }
                    }
                    else//非服务器主动推送的消息
                    {
                        var clientSendSequence = msgPackage.Item1.Sequence - 1;
                        if (_msgResponceCompletions.TryGetValue(clientSendSequence, out var uniTaskCompletion))
                        {
                            uniTaskCompletion.TrySetResult(msgPackage);
                            _msgResponceCompletions.TryRemove(clientSendSequence, out var _);
                        }
                    }
                }
            }

        }, cancellationToken: cancellation).Forget();
    }

    /// <summary>
    /// 接收服务主机返回的网络消息
    /// </summary>
    ConcurrentDictionary<uint, UniTaskCompletionSource<(MsgPackageServer, IMessage)>> _msgResponceCompletions = new();
    /// <summary>
    /// 发送消息等待回包完成记录
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sequence"></param>
    /// <param name="taskCompletionSource"></param>
    /// <param name="cmd"></param>
    /// <param name="messageParser"></param>
    public void RecoderResponseCompletion<T>(uint sequence, UniTaskCompletionSource<(MsgPackageServer, IMessage)> taskCompletionSource, int cmd, MessageParser<T> messageParser) where T : IMessage<T>
    {
        if (!_messageParserMap.ContainsKey(cmd) && messageParser != null)
        {
            _messageParserMap.TryAdd(cmd, messageParser);
        }
        _msgResponceCompletions.TryAdd(sequence, taskCompletionSource);
    }

    /// <summary>
    /// 收到网络消息
    /// </summary>
    ConcurrentQueue<(MsgPackageServer, IMessage)> _msgs = new();

    /// <summary>
    /// 解包收到的网络数据
    /// </summary>
    /// <param name="packageServer"></param>
    public void EnqueueMsgPackage(MsgPackageServer packageServer)
    {
        //根据返回的消息包，解析出业务消息包体
        var cmd = packageServer.MsgCode;
        //解包器
        _messageParserMap.TryGetValue(cmd, out var messageParser);
        if (_serverPushListeners.ContainsKey(cmd))//服务器主动推送的消息
        {
            var logicMsgData = messageParser.ParseFrom(packageServer.MsgData);
            _msgs.Enqueue((packageServer, logicMsgData));
        }
        else
        {
            if (messageParser != null)
            {
                var logicMsgData = messageParser.ParseFrom(packageServer.MsgData);
                _msgs.Enqueue((packageServer, logicMsgData));
            }
            else
            {
                if (!packageServer.MsgData.IsEmpty)
                {
                    UnityEngine.Debug.LogError($"客户端未注册该消息Cmd：{cmd}返回包体的解包器");
                }
            }
        }
    }

    ConcurrentDictionary<int, MessageParser> _messageParserMap = new();
    ConcurrentDictionary<int, HashSet<Action<IMessage>>> _serverPushListeners = new();

    /// <summary>
    /// 添加服务器主动退的消息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cmd"></param>
    /// <param name="cb"></param>
    /// <param name="messageParser"></param>
    public void AddServerPushListener<T>(int cmd, Action<T> cb, MessageParser<T> messageParser) where T : IMessage<T>
    {
        if (!_messageParserMap.ContainsKey(cmd))
        {
            _messageParserMap.TryAdd(cmd, messageParser);
        }
        if (!_serverPushListeners.TryGetValue(cmd, out var actions))
        {
            actions = new();
            _serverPushListeners.TryAdd(cmd, actions);
        }
        actions.Add((msgData) => { cb?.Invoke((T)msgData); });
    }
}