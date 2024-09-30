using Cysharp.Threading.Tasks;
using HyPb;
using UnityEngine;

public class Test : MonoBehaviour
{
    NetServiceTcp _gameNet = new NetServiceTcp();
    async UniTaskVoid Start()
    {
        _gameNet.AddServerPushListener(cmd: 1, OnTestFunc, MsgPackageClient.Parser);
        _gameNet.AddServerPushListener(cmd: 2, OnTestFunc2, MsgPackageServer.Parser);

        TestMsgInt res = await _gameNet.SendAsync<TestMsgInt, TestMsg>(cmd: 1001, new TestMsg(), TestMsgInt.Parser);
        Debug.Log(res.Value);
    }

    private void OnTestFunc2(MsgPackageServer server)
    {
    }

    private void OnTestFunc(MsgPackageClient client)
    {
    }
}