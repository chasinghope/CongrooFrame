
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
public partial class TBShopGold
{
    private readonly System.Collections.Generic.Dictionary<int, Battle.CfShopGold> _dataMap;
    private readonly System.Collections.Generic.List<Battle.CfShopGold> _dataList;
    
    public TBShopGold(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Battle.CfShopGold>();
        _dataList = new System.Collections.Generic.List<Battle.CfShopGold>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Battle.CfShopGold _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Battle.CfShopGold.DeserializeCfShopGold(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Battle.CfShopGold> DataMap => _dataMap;
    public System.Collections.Generic.List<Battle.CfShopGold> DataList => _dataList;

    public Battle.CfShopGold GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Battle.CfShopGold Get(int key) => _dataMap[key];
    public Battle.CfShopGold this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

