using Cysharp.Threading.Tasks;
using Google.Protobuf;

public interface INetService
{
    UniTask<bool> Connect(string host, int port);
    UniTask<TMsgRes> SendAsync<TMsgRes, TMsgReq>(int cmd, TMsgReq sendMsg, MessageParser<TMsgRes> messageParser = null) where TMsgReq : IMessage where TMsgRes : IMessage<TMsgRes>, new();
    void DisConnect();
}