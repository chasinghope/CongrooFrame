
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
public partial class TBLevel
{
    private readonly System.Collections.Generic.Dictionary<int, Battle.CfLevel> _dataMap;
    private readonly System.Collections.Generic.List<Battle.CfLevel> _dataList;
    
    public TBLevel(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Battle.CfLevel>();
        _dataList = new System.Collections.Generic.List<Battle.CfLevel>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Battle.CfLevel _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Battle.CfLevel.DeserializeCfLevel(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Battle.CfLevel> DataMap => _dataMap;
    public System.Collections.Generic.List<Battle.CfLevel> DataList => _dataList;

    public Battle.CfLevel GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Battle.CfLevel Get(int key) => _dataMap[key];
    public Battle.CfLevel this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

