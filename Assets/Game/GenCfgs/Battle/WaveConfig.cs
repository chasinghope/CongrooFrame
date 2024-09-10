
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
/// <summary>
/// 波次配置
/// </summary>
public sealed partial class WaveConfig : Luban.BeanBase
{
    public WaveConfig(ByteBuf _buf) 
    {
        Duration = _buf.ReadFloat();
        MonsterId = _buf.ReadInt();
        Num = _buf.ReadInt();
    }

    public static WaveConfig DeserializeWaveConfig(ByteBuf _buf)
    {
        return new Battle.WaveConfig(_buf);
    }

    /// <summary>
    /// 等待时间
    /// </summary>
    public readonly float Duration;
    /// <summary>
    /// 怪物id
    /// </summary>
    public readonly int MonsterId;
    /// <summary>
    /// 生成数量
    /// </summary>
    public readonly int Num;
   
    public const int __ID__ = 697887377;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "duration:" + Duration + ","
        + "monsterId:" + MonsterId + ","
        + "num:" + Num + ","
        + "}";
    }
}

}

