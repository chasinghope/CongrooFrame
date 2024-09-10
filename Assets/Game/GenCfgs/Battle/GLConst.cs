
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
public sealed partial class GLConst : Luban.BeanBase
{
    public GLConst(ByteBuf _buf) 
    {
        PoisonDamage = _buf.ReadInt();
        TestMaxHp = _buf.ReadFloat();
        TestMaxPower = _buf.ReadFloat();
        MaxInjuredPercent = _buf.ReadFloat();
        EnergyFreeLimit = _buf.ReadInt();
        EnergyVipLimit = _buf.ReadInt();
        EnergyBuyAdLimit = _buf.ReadInt();
        EnergyBuyAdReward = _buf.ReadInt();
        EnergyBuyGemLimit = _buf.ReadInt();
        EnergyBuyGemReward = _buf.ReadInt();
        EnergyBuyGemNum = _buf.ReadInt();
        ShareEnergyNum = _buf.ReadInt();
        CheckpointConsumeEnergy = _buf.ReadInt();
        SweepConsumeEnergy = _buf.ReadInt();
        SweepAdLimit = _buf.ReadInt();
        SweepEnergyLimit = _buf.ReadInt();
        SweepVipAdditionNum = _buf.ReadInt();
        SweepSuperVipAdditionNum = _buf.ReadInt();
        NewbiePower = _buf.ReadInt();
        SilverCoinPerRound = _buf.ReadInt();
        TalentUnlockId = _buf.ReadInt();
        AdRefresh = _buf.ReadInt();
        AdItemRefresh = _buf.ReadInt();
        SilverBag = _buf.ReadInt();
        PlayerBaseHP = _buf.ReadInt();
        NormalTalentMaterial = _buf.ReadInt();
        SpecialTalentMaterial = _buf.ReadInt();
        PrayLuckyValuePerfect = _buf.ReadInt();
        PrayLuckyValueRare = _buf.ReadInt();
        PrayLuckyValueLegendary = _buf.ReadInt();
        BattleShopRefreshPrice = _buf.ReadInt();
        MonsterBornInverval = _buf.ReadFloat();
        NormalFirstTalent = _buf.ReadInt();
        SpecialFirstTalent = _buf.ReadInt();
    }

    public static GLConst DeserializeGLConst(ByteBuf _buf)
    {
        return new Battle.GLConst(_buf);
    }

    /// <summary>
    /// 每点毒伤害
    /// </summary>
    public readonly int PoisonDamage;
    /// <summary>
    /// 测试最大生命值
    /// </summary>
    public readonly float TestMaxHp;
    /// <summary>
    /// 测试最大力度
    /// </summary>
    public readonly float TestMaxPower;
    /// <summary>
    /// 最大免伤百分比
    /// </summary>
    public readonly float MaxInjuredPercent;
    /// <summary>
    /// 免费体力上限
    /// </summary>
    public readonly int EnergyFreeLimit;
    /// <summary>
    /// 付费体力上限
    /// </summary>
    public readonly int EnergyVipLimit;
    /// <summary>
    /// 体力购买广告次数上限
    /// </summary>
    public readonly int EnergyBuyAdLimit;
    /// <summary>
    /// 体力购买广告获取体力
    /// </summary>
    public readonly int EnergyBuyAdReward;
    /// <summary>
    /// 体力购买钻石次数上限
    /// </summary>
    public readonly int EnergyBuyGemLimit;
    /// <summary>
    /// 体力购买钻石获取体力
    /// </summary>
    public readonly int EnergyBuyGemReward;
    /// <summary>
    /// 体力购买钻石消耗
    /// </summary>
    public readonly int EnergyBuyGemNum;
    /// <summary>
    /// 分享奖励体力
    /// </summary>
    public readonly int ShareEnergyNum;
    /// <summary>
    /// 关卡体力消耗
    /// </summary>
    public readonly int CheckpointConsumeEnergy;
    /// <summary>
    /// 扫荡消耗体力
    /// </summary>
    public readonly int SweepConsumeEnergy;
    /// <summary>
    /// 扫荡广告上限
    /// </summary>
    public readonly int SweepAdLimit;
    /// <summary>
    /// 扫荡体力上限
    /// </summary>
    public readonly int SweepEnergyLimit;
    /// <summary>
    /// 超值月卡扫荡收益+5%(金币\经验)
    /// </summary>
    public readonly int SweepVipAdditionNum;
    /// <summary>
    /// 特权月卡扫荡收益+15%(金币\经验)
    /// </summary>
    public readonly int SweepSuperVipAdditionNum;
    /// <summary>
    /// 角色初始战力
    /// </summary>
    public readonly int NewbiePower;
    /// <summary>
    /// 每轮银币增加10
    /// </summary>
    public readonly int SilverCoinPerRound;
    /// <summary>
    /// 第一章节第6关天赋解锁
    /// </summary>
    public readonly int TalentUnlockId;
    /// <summary>
    /// 战斗中广告刷新次数
    /// </summary>
    public readonly int AdRefresh;
    /// <summary>
    /// 战斗中广告卷刷新次数
    /// </summary>
    public readonly int AdItemRefresh;
    /// <summary>
    /// 银币钱袋
    /// </summary>
    public readonly int SilverBag;
    /// <summary>
    /// 基础血量
    /// </summary>
    public readonly int PlayerBaseHP;
    /// <summary>
    /// 普通天赋书ID
    /// </summary>
    public readonly int NormalTalentMaterial;
    /// <summary>
    /// 智慧宝典ID
    /// </summary>
    public readonly int SpecialTalentMaterial;
    /// <summary>
    /// 祈愿精良幸运值
    /// </summary>
    public readonly int PrayLuckyValuePerfect;
    /// <summary>
    /// 祈愿稀有幸运值
    /// </summary>
    public readonly int PrayLuckyValueRare;
    /// <summary>
    /// 祈愿传说幸运值
    /// </summary>
    public readonly int PrayLuckyValueLegendary;
    /// <summary>
    /// 战斗商店刷新价格
    /// </summary>
    public readonly int BattleShopRefreshPrice;
    /// <summary>
    /// 怪物生成间隔时间
    /// </summary>
    public readonly float MonsterBornInverval;
    /// <summary>
    /// 第一个普通天赋ID
    /// </summary>
    public readonly int NormalFirstTalent;
    /// <summary>
    /// 第一个特殊天赋ID
    /// </summary>
    public readonly int SpecialFirstTalent;
   
    public const int __ID__ = -120325528;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "PoisonDamage:" + PoisonDamage + ","
        + "TestMaxHp:" + TestMaxHp + ","
        + "TestMaxPower:" + TestMaxPower + ","
        + "MaxInjuredPercent:" + MaxInjuredPercent + ","
        + "EnergyFreeLimit:" + EnergyFreeLimit + ","
        + "EnergyVipLimit:" + EnergyVipLimit + ","
        + "EnergyBuyAdLimit:" + EnergyBuyAdLimit + ","
        + "EnergyBuyAdReward:" + EnergyBuyAdReward + ","
        + "EnergyBuyGemLimit:" + EnergyBuyGemLimit + ","
        + "EnergyBuyGemReward:" + EnergyBuyGemReward + ","
        + "EnergyBuyGemNum:" + EnergyBuyGemNum + ","
        + "ShareEnergyNum:" + ShareEnergyNum + ","
        + "CheckpointConsumeEnergy:" + CheckpointConsumeEnergy + ","
        + "SweepConsumeEnergy:" + SweepConsumeEnergy + ","
        + "SweepAdLimit:" + SweepAdLimit + ","
        + "SweepEnergyLimit:" + SweepEnergyLimit + ","
        + "SweepVipAdditionNum:" + SweepVipAdditionNum + ","
        + "SweepSuperVipAdditionNum:" + SweepSuperVipAdditionNum + ","
        + "NewbiePower:" + NewbiePower + ","
        + "SilverCoinPerRound:" + SilverCoinPerRound + ","
        + "TalentUnlockId:" + TalentUnlockId + ","
        + "AdRefresh:" + AdRefresh + ","
        + "AdItemRefresh:" + AdItemRefresh + ","
        + "SilverBag:" + SilverBag + ","
        + "PlayerBaseHP:" + PlayerBaseHP + ","
        + "NormalTalentMaterial:" + NormalTalentMaterial + ","
        + "SpecialTalentMaterial:" + SpecialTalentMaterial + ","
        + "PrayLuckyValuePerfect:" + PrayLuckyValuePerfect + ","
        + "PrayLuckyValueRare:" + PrayLuckyValueRare + ","
        + "PrayLuckyValueLegendary:" + PrayLuckyValueLegendary + ","
        + "BattleShopRefreshPrice:" + BattleShopRefreshPrice + ","
        + "MonsterBornInverval:" + MonsterBornInverval + ","
        + "NormalFirstTalent:" + NormalFirstTalent + ","
        + "SpecialFirstTalent:" + SpecialFirstTalent + ","
        + "}";
    }
}

}

