
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
public partial class TBShopGem
{
    private readonly System.Collections.Generic.Dictionary<int, Battle.CfShopGem> _dataMap;
    private readonly System.Collections.Generic.List<Battle.CfShopGem> _dataList;
    
    public TBShopGem(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Battle.CfShopGem>();
        _dataList = new System.Collections.Generic.List<Battle.CfShopGem>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Battle.CfShopGem _v;
            _v = Battle.CfShopGem.DeserializeCfShopGem(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Battle.CfShopGem> DataMap => _dataMap;
    public System.Collections.Generic.List<Battle.CfShopGem> DataList => _dataList;

    public Battle.CfShopGem GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Battle.CfShopGem Get(int key) => _dataMap[key];
    public Battle.CfShopGem this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

