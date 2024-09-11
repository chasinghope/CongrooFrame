using System;
using System.Linq;
using System.Reflection;
using cfg;
using UnityEngine;
using Congroo.Core;
using Luban;
using SimpleJSON;

public interface ITablePostProcess
{
    void PostProcess(Tables tables);
}

/// <summary>
/// 配置表
/// </summary>
public class CfgTable :  Singleton<CfgTable>
{
    public Tables Table { get; private set; }
    private CfgTable() { }
    
    public void Init()
    {
        var tablesCtor = typeof(Tables).GetConstructors()[0];
        var loaderReturnType = tablesCtor.GetParameters()[0].ParameterType.GetGenericArguments()[1];
        // 根据cfg.Tables的构造函数的Loader的返回值类型决定使用json还是ByteBuf Loader
        System.Delegate loader = loaderReturnType == typeof(ByteBuf) ?
            new System.Func<string, ByteBuf>(LoadByteBuf)
            : (System.Delegate)new System.Func<string, JSONNode>(LoadJson);
        Table = (cfg.Tables)tablesCtor.Invoke(new object[] { loader });
        
        
        // 后处理数据
        PostProcess(Table);
        Debug.Log("CfgTable init success");
    }
    
    
    private JSONNode LoadJson(string file)
    {
        var jsonFile = ResMgr.LoadAsset<TextAsset>($"cfgs/jsons/{file}.json");
        return JSON.Parse(jsonFile.text);
    }
    
    private ByteBuf LoadByteBuf(string file)
    {
        var cfg = ResMgr.LoadAsset<TextAsset>($"cfgs/bytes/{file}.bytes");

        return new ByteBuf(cfg.bytes);
    }
    
    private void PostProcess(Tables tables)
    {
        Type tablesType = typeof(Tables);
        PropertyInfo[] properties = tablesType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        Type interfaceType = typeof(ITablePostProcess);
        foreach (PropertyInfo property in properties)
        {
            if (interfaceType.IsAssignableFrom(property.PropertyType))
            {
                ITablePostProcess tableProcessor = property.GetValue(tables) as ITablePostProcess;
                if (tableProcessor != null)
                {
                    tableProcessor.PostProcess(tables);
                }
            }
        }
    }
}
