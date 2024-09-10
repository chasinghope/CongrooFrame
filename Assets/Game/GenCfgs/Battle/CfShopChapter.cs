
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
public sealed partial class CfShopChapter : Luban.BeanBase
{
    public CfShopChapter(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["Title"].IsNumber) { throw new SerializationException(); }  Title = _buf["Title"]; }
        { if(!_buf["Price"].IsNumber) { throw new SerializationException(); }  Price = _buf["Price"]; }
        { if(!_buf["DollarPrice"].IsNumber) { throw new SerializationException(); }  DollarPrice = _buf["DollarPrice"]; }
        { if(!_buf["OriginalDollarPrice"].IsNumber) { throw new SerializationException(); }  OriginalDollarPrice = _buf["OriginalDollarPrice"]; }
        { if(!_buf["OriginalPrice"].IsNumber) { throw new SerializationException(); }  OriginalPrice = _buf["OriginalPrice"]; }
        { if(!_buf["GiftDesc"].IsNumber) { throw new SerializationException(); }  GiftDesc = _buf["GiftDesc"]; }
        { if(!_buf["DiscountDesc"].IsNumber) { throw new SerializationException(); }  DiscountDesc = _buf["DiscountDesc"]; }
        { var __json0 = _buf["Rewards"]; if(!__json0.IsArray) { throw new SerializationException(); } Rewards = new System.Collections.Generic.List<Battle.ItemStuff>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { Battle.ItemStuff __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = Battle.ItemStuff.DeserializeItemStuff(__e0);  }  Rewards.Add(__v0); }   }
    }

    public static CfShopChapter DeserializeCfShopChapter(JSONNode _buf)
    {
        return new Battle.CfShopChapter(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 标题
    /// </summary>
    public readonly int Title;
    /// <summary>
    /// 价格
    /// </summary>
    public readonly int Price;
    /// <summary>
    /// 美元价格
    /// </summary>
    public readonly float DollarPrice;
    /// <summary>
    /// 美元原价
    /// </summary>
    public readonly float OriginalDollarPrice;
    /// <summary>
    /// 原价
    /// </summary>
    public readonly float OriginalPrice;
    /// <summary>
    /// 礼包描述
    /// </summary>
    public readonly int GiftDesc;
    /// <summary>
    /// 折扣描述
    /// </summary>
    public readonly int DiscountDesc;
    /// <summary>
    /// 领取奖励
    /// </summary>
    public readonly System.Collections.Generic.List<Battle.ItemStuff> Rewards;
   
    public const int __ID__ = -1009552034;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        foreach (var _e in Rewards) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Title:" + Title + ","
        + "Price:" + Price + ","
        + "DollarPrice:" + DollarPrice + ","
        + "OriginalDollarPrice:" + OriginalDollarPrice + ","
        + "OriginalPrice:" + OriginalPrice + ","
        + "GiftDesc:" + GiftDesc + ","
        + "DiscountDesc:" + DiscountDesc + ","
        + "Rewards:" + Luban.StringUtil.CollectionToString(Rewards) + ","
        + "}";
    }
}

}

