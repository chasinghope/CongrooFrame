
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
public sealed partial class CfTaskType : Luban.BeanBase
{
    public CfTaskType(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["TaskDesc"].IsNumber) { throw new SerializationException(); }  TaskDesc = _buf["TaskDesc"]; }
        { if(!_buf["TargetPage"].IsNumber) { throw new SerializationException(); }  TargetPage = (Common.TargetPage)_buf["TargetPage"].AsInt; }
    }

    public static CfTaskType DeserializeCfTaskType(JSONNode _buf)
    {
        return new Battle.CfTaskType(_buf);
    }

    /// <summary>
    /// 任务类型id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 任务描述
    /// </summary>
    public readonly int TaskDesc;
    /// <summary>
    /// 目标页面
    /// </summary>
    public readonly Common.TargetPage TargetPage;
   
    public const int __ID__ = -1420422440;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "TaskDesc:" + TaskDesc + ","
        + "TargetPage:" + TargetPage + ","
        + "}";
    }
}

}

