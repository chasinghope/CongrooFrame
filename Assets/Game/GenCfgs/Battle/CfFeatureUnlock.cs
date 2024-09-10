
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.Battle
{
public sealed partial class CfFeatureUnlock : Luban.BeanBase
{
    public CfFeatureUnlock(JSONNode _buf) 
    {
        { if(!_buf["FunctionId"].IsNumber) { throw new SerializationException(); }  FunctionId = _buf["FunctionId"]; }
        { if(!_buf["IsDisplay"].IsBoolean) { throw new SerializationException(); }  IsDisplay = _buf["IsDisplay"]; }
        { if(!_buf["FuctionIcon"].IsString) { throw new SerializationException(); }  FuctionIcon = _buf["FuctionIcon"]; }
        { if(!_buf["FuctionName"].IsNumber) { throw new SerializationException(); }  FuctionName = _buf["FuctionName"]; }
        { if(!_buf["StageID"].IsNumber) { throw new SerializationException(); }  StageID = _buf["StageID"]; }
        { if(!_buf["UnlockNotice"].IsNumber) { throw new SerializationException(); }  UnlockNotice = _buf["UnlockNotice"]; }
    }

    public static CfFeatureUnlock DeserializeCfFeatureUnlock(JSONNode _buf)
    {
        return new Battle.CfFeatureUnlock(_buf);
    }

    /// <summary>
    /// 功能ID
    /// </summary>
    public readonly int FunctionId;
    /// <summary>
    /// 是否弹出
    /// </summary>
    public readonly bool IsDisplay;
    /// <summary>
    /// 功能图标
    /// </summary>
    public readonly string FuctionIcon;
    /// <summary>
    /// 功能名称
    /// </summary>
    public readonly int FuctionName;
    /// <summary>
    /// 关卡ID
    /// </summary>
    public readonly int StageID;
    /// <summary>
    /// 解锁提示
    /// </summary>
    public readonly int UnlockNotice;
   
    public const int __ID__ = 1058108673;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "FunctionId:" + FunctionId + ","
        + "IsDisplay:" + IsDisplay + ","
        + "FuctionIcon:" + FuctionIcon + ","
        + "FuctionName:" + FuctionName + ","
        + "StageID:" + StageID + ","
        + "UnlockNotice:" + UnlockNotice + ","
        + "}";
    }
}

}

