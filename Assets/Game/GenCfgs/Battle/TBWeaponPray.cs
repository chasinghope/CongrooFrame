
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
public partial class TBWeaponPray
{
    private readonly System.Collections.Generic.Dictionary<int, Battle.CfWeaponPray> _dataMap;
    private readonly System.Collections.Generic.List<Battle.CfWeaponPray> _dataList;
    
    public TBWeaponPray(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Battle.CfWeaponPray>();
        _dataList = new System.Collections.Generic.List<Battle.CfWeaponPray>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Battle.CfWeaponPray _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Battle.CfWeaponPray.DeserializeCfWeaponPray(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Battle.CfWeaponPray> DataMap => _dataMap;
    public System.Collections.Generic.List<Battle.CfWeaponPray> DataList => _dataList;

    public Battle.CfWeaponPray GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Battle.CfWeaponPray Get(int key) => _dataMap[key];
    public Battle.CfWeaponPray this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

