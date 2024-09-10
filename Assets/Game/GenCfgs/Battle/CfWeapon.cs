
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
public sealed partial class CfWeapon : Luban.BeanBase
{
    public CfWeapon(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["ItemName"].IsNumber) { throw new SerializationException(); }  ItemName = _buf["ItemName"]; }
        { if(!_buf["IsInBag"].IsBoolean) { throw new SerializationException(); }  IsInBag = _buf["IsInBag"]; }
        { var __json0 = _buf["AttributeList"]; if(!__json0.IsArray) { throw new SerializationException(); } AttributeList = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  AttributeList.Add(__v0); }   }
        { if(!_buf["TargetSelectType"].IsNumber) { throw new SerializationException(); }  TargetSelectType = (Battle.TargetSelectType)_buf["TargetSelectType"].AsInt; }
        { if(!_buf["AttackNum"].IsNumber) { throw new SerializationException(); }  AttackNum = _buf["AttackNum"]; }
        { if(!_buf["GridX"].IsNumber) { throw new SerializationException(); }  GridX = _buf["GridX"]; }
        { if(!_buf["GridY"].IsNumber) { throw new SerializationException(); }  GridY = _buf["GridY"]; }
        { if(!_buf["WeaponSound"].IsString) { throw new SerializationException(); }  WeaponSound = _buf["WeaponSound"]; }
        { if(!_buf["CellType"].IsNumber) { throw new SerializationException(); }  CellType = (Battle.CellType)_buf["CellType"].AsInt; }
        { if(!_buf["IconName"].IsString) { throw new SerializationException(); }  IconName = _buf["IconName"]; }
        { if(!_buf["ItemType"].IsNumber) { throw new SerializationException(); }  ItemType = (Battle.ItemType)_buf["ItemType"].AsInt; }
        { if(!_buf["ElementType"].IsNumber) { throw new SerializationException(); }  ElementType = (Battle.ElementType)_buf["ElementType"].AsInt; }
        { if(!_buf["Quality"].IsNumber) { throw new SerializationException(); }  Quality = (Battle.ItemQuality)_buf["Quality"].AsInt; }
    }

    public static CfWeapon DeserializeCfWeapon(JSONNode _buf)
    {
        return new Battle.CfWeapon(_buf);
    }

    /// <summary>
    /// 道具id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 道具名称
    /// </summary>
    public readonly int ItemName;
    /// <summary>
    /// 类型
    /// </summary>
    public readonly bool IsInBag;
    /// <summary>
    /// 属性列表
    /// </summary>
    public readonly System.Collections.Generic.List<int> AttributeList;
    /// <summary>
    /// 攻击目标
    /// </summary>
    public readonly Battle.TargetSelectType TargetSelectType;
    /// <summary>
    /// 攻击个数
    /// </summary>
    public readonly int AttackNum;
    /// <summary>
    /// 占格长
    /// </summary>
    public readonly int GridX;
    /// <summary>
    /// 占格宽
    /// </summary>
    public readonly int GridY;
    /// <summary>
    /// 子弹音效
    /// </summary>
    public readonly string WeaponSound;
    /// <summary>
    /// 网格型号
    /// </summary>
    public readonly Battle.CellType CellType;
    /// <summary>
    /// 图形名称
    /// </summary>
    public readonly string IconName;
    /// <summary>
    /// 道具类型
    /// </summary>
    public readonly Battle.ItemType ItemType;
    /// <summary>
    /// 元素类型
    /// </summary>
    public readonly Battle.ElementType ElementType;
    /// <summary>
    /// 品质类型
    /// </summary>
    public readonly Battle.ItemQuality Quality;
   
    public const int __ID__ = 51818709;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "ItemName:" + ItemName + ","
        + "IsInBag:" + IsInBag + ","
        + "AttributeList:" + Luban.StringUtil.CollectionToString(AttributeList) + ","
        + "TargetSelectType:" + TargetSelectType + ","
        + "AttackNum:" + AttackNum + ","
        + "GridX:" + GridX + ","
        + "GridY:" + GridY + ","
        + "WeaponSound:" + WeaponSound + ","
        + "CellType:" + CellType + ","
        + "IconName:" + IconName + ","
        + "ItemType:" + ItemType + ","
        + "ElementType:" + ElementType + ","
        + "Quality:" + Quality + ","
        + "}";
    }
}

}

