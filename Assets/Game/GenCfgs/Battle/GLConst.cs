
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
public sealed partial class GLConst : Luban.BeanBase
{
    public GLConst(JSONNode _buf) 
    {
        { if(!_buf["PoisonDamage"].IsNumber) { throw new SerializationException(); }  PoisonDamage = _buf["PoisonDamage"]; }
        { if(!_buf["TestMaxHp"].IsNumber) { throw new SerializationException(); }  TestMaxHp = _buf["TestMaxHp"]; }
        { if(!_buf["TestMaxPower"].IsNumber) { throw new SerializationException(); }  TestMaxPower = _buf["TestMaxPower"]; }
        { if(!_buf["MaxInjuredPercent"].IsNumber) { throw new SerializationException(); }  MaxInjuredPercent = _buf["MaxInjuredPercent"]; }
        { if(!_buf["EnergyFreeLimit"].IsNumber) { throw new SerializationException(); }  EnergyFreeLimit = _buf["EnergyFreeLimit"]; }
        { if(!_buf["EnergyVipLimit"].IsNumber) { throw new SerializationException(); }  EnergyVipLimit = _buf["EnergyVipLimit"]; }
        { if(!_buf["EnergyBuyAdLimit"].IsNumber) { throw new SerializationException(); }  EnergyBuyAdLimit = _buf["EnergyBuyAdLimit"]; }
        { if(!_buf["EnergyBuyAdReward"].IsNumber) { throw new SerializationException(); }  EnergyBuyAdReward = _buf["EnergyBuyAdReward"]; }
        { if(!_buf["EnergyBuyGemLimit"].IsNumber) { throw new SerializationException(); }  EnergyBuyGemLimit = _buf["EnergyBuyGemLimit"]; }
        { if(!_buf["EnergyBuyGemReward"].IsNumber) { throw new SerializationException(); }  EnergyBuyGemReward = _buf["EnergyBuyGemReward"]; }
        { if(!_buf["EnergyBuyGemNum"].IsNumber) { throw new SerializationException(); }  EnergyBuyGemNum = _buf["EnergyBuyGemNum"]; }
        { if(!_buf["ShareEnergyNum"].IsNumber) { throw new SerializationException(); }  ShareEnergyNum = _buf["ShareEnergyNum"]; }
        { if(!_buf["CheckpointConsumeEnergy"].IsNumber) { throw new SerializationException(); }  CheckpointConsumeEnergy = _buf["CheckpointConsumeEnergy"]; }
        { if(!_buf["SweepConsumeEnergy"].IsNumber) { throw new SerializationException(); }  SweepConsumeEnergy = _buf["SweepConsumeEnergy"]; }
        { if(!_buf["SweepAdLimit"].IsNumber) { throw new SerializationException(); }  SweepAdLimit = _buf["SweepAdLimit"]; }
        { if(!_buf["SweepEnergyLimit"].IsNumber) { throw new SerializationException(); }  SweepEnergyLimit = _buf["SweepEnergyLimit"]; }
        { if(!_buf["SweepVipAdditionNum"].IsNumber) { throw new SerializationException(); }  SweepVipAdditionNum = _buf["SweepVipAdditionNum"]; }
        { if(!_buf["SweepSuperVipAdditionNum"].IsNumber) { throw new SerializationException(); }  SweepSuperVipAdditionNum = _buf["SweepSuperVipAdditionNum"]; }
        { if(!_buf["NewbiePower"].IsNumber) { throw new SerializationException(); }  NewbiePower = _buf["NewbiePower"]; }
        { if(!_buf["SilverCoinPerRound"].IsNumber) { throw new SerializationException(); }  SilverCoinPerRound = _buf["SilverCoinPerRound"]; }
        { if(!_buf["TalentUnlockId"].IsNumber) { throw new SerializationException(); }  TalentUnlockId = _buf["TalentUnlockId"]; }
        { if(!_buf["AdRefresh"].IsNumber) { throw new SerializationException(); }  AdRefresh = _buf["AdRefresh"]; }
        { if(!_buf["AdItemRefresh"].IsNumber) { throw new SerializationException(); }  AdItemRefresh = _buf["AdItemRefresh"]; }
        { if(!_buf["SilverBag"].IsNumber) { throw new SerializationException(); }  SilverBag = _buf["SilverBag"]; }
        { if(!_buf["PlayerBaseHP"].IsNumber) { throw new SerializationException(); }  PlayerBaseHP = _buf["PlayerBaseHP"]; }
        { if(!_buf["NormalTalentMaterial"].IsNumber) { throw new SerializationException(); }  NormalTalentMaterial = _buf["NormalTalentMaterial"]; }
        { if(!_buf["SpecialTalentMaterial"].IsNumber) { throw new SerializationException(); }  SpecialTalentMaterial = _buf["SpecialTalentMaterial"]; }
        { if(!_buf["PrayLuckyValuePerfect"].IsNumber) { throw new SerializationException(); }  PrayLuckyValuePerfect = _buf["PrayLuckyValuePerfect"]; }
        { if(!_buf["PrayLuckyValueRare"].IsNumber) { throw new SerializationException(); }  PrayLuckyValueRare = _buf["PrayLuckyValueRare"]; }
        { if(!_buf["PrayLuckyValueLegendary"].IsNumber) { throw new SerializationException(); }  PrayLuckyValueLegendary = _buf["PrayLuckyValueLegendary"]; }
        { if(!_buf["BattleShopRefreshPrice"].IsNumber) { throw new SerializationException(); }  BattleShopRefreshPrice = _buf["BattleShopRefreshPrice"]; }
        { if(!_buf["MonsterBornInverval"].IsNumber) { throw new SerializationException(); }  MonsterBornInverval = _buf["MonsterBornInverval"]; }
        { if(!_buf["NormalFirstTalent"].IsNumber) { throw new SerializationException(); }  NormalFirstTalent = _buf["NormalFirstTalent"]; }
        { if(!_buf["SpecialFirstTalent"].IsNumber) { throw new SerializationException(); }  SpecialFirstTalent = _buf["SpecialFirstTalent"]; }
    }

    public static GLConst DeserializeGLConst(JSONNode _buf)
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

