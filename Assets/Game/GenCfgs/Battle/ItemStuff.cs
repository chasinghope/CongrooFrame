
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
public sealed partial class ItemStuff : Luban.BeanBase
{
    public ItemStuff(JSONNode _buf) 
    {
        { if(!_buf["ItemID"].IsNumber) { throw new SerializationException(); }  ItemID = _buf["ItemID"]; }
        { if(!_buf["ItemCount"].IsNumber) { throw new SerializationException(); }  ItemCount = _buf["ItemCount"]; }
    }

    public static ItemStuff DeserializeItemStuff(JSONNode _buf)
    {
        return new Battle.ItemStuff(_buf);
    }

    /// <summary>
    /// 道具ID
    /// </summary>
    public readonly int ItemID;
    /// <summary>
    /// 数量
    /// </summary>
    public readonly int ItemCount;
   
    public const int __ID__ = 2032474347;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ItemID:" + ItemID + ","
        + "ItemCount:" + ItemCount + ","
        + "}";
    }
}

}

