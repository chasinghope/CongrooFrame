
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.Battle
{
public partial class TBWeaponAttribute
{
    private readonly System.Collections.Generic.Dictionary<int, Battle.CfWeaponAttribute> _dataMap;
    private readonly System.Collections.Generic.List<Battle.CfWeaponAttribute> _dataList;
    
    public TBWeaponAttribute(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Battle.CfWeaponAttribute>();
        _dataList = new System.Collections.Generic.List<Battle.CfWeaponAttribute>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Battle.CfWeaponAttribute _v;
            _v = Battle.CfWeaponAttribute.DeserializeCfWeaponAttribute(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Battle.CfWeaponAttribute> DataMap => _dataMap;
    public System.Collections.Generic.List<Battle.CfWeaponAttribute> DataList => _dataList;

    public Battle.CfWeaponAttribute GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Battle.CfWeaponAttribute Get(int key) => _dataMap[key];
    public Battle.CfWeaponAttribute this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

