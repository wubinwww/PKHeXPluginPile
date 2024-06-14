using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public class RaidParameters {
  private static readonly string[] LocationNames = [
    "牙牙湖之眼",
    "桥间空地",
    "沐光森林",
    "沙尘洼地",
    "牙牙湖东岸",
    "巨人帽岩",
    "巨人镜湖",
    "巨人凳岩",
    "拳关丘陵",
    "逆鳞湖",
    "机擎河岸",
    "美纳斯湖北岸",
    "煦丽草原",
    "美纳斯湖西岸",
    "巨石原野",
    "瞭望塔旧址",
    "牙牙湖西岸",
    //
    "揖礼原野",
    "清凉湿原",
    "专注森林",
    "挑战海滩",
    "战斗洞窟",
    "挑战之路",
    "斗志洞窟",
    "圆环海湾",
    "锻炼平原",
    //"Warm-Up Tunnel",
    "锅底沙漠",
    "健身之海",
    "列岛海域",
    "离岛海域",
    "蜂巢海",
    "蜂巢岛",
    "起橇雪原",
    "冰点雪原",
    "巨人睡榻",
    "远古墓地",
    "雪中溪谷",
    "通顶雪道",
    "王冠神殿",
    "巨人鞋底",
    "冻海",
    "三岔平原",
    "球湖湖畔",
    "巨树丘陵"
  ];

  public readonly int Flags;
  public readonly RaidType Type;
  public readonly bool IsActive;
  public readonly bool IsEvent;
  public readonly bool IsRare;
  public readonly bool IsCrystal;
  public readonly bool IsWishingPiece;
  public readonly bool WattsHarvested;
  public readonly ulong Seed;
  public readonly int Index;
  public readonly int Stars;
  public readonly int RandRoll;
  public readonly int X;
  public readonly int Y;
  public readonly string Location;

  public RaidParameters(int index, RaidSpawnDetail detail, int location, int x, int y)
      : this(index, detail.Seed, detail.Stars, detail.RandRoll, detail.Flags, detail.DenType, location, x, y) { }

  public RaidParameters(int index, ulong seed, int stars, int randRoll, int flags, RaidType type, int location, int x, int y) {
    Seed = seed;
    Flags = flags;
    Type = type;
    IsActive = type > 0;
    IsCrystal = index == 16;
    IsRare = Type == RaidType.Rare || Type == RaidType.RareWish;
    IsEvent = IsActive && (Flags & 2) == 2;
    IsWishingPiece = Type == RaidType.Common || Type == RaidType.RareWish;
    WattsHarvested = (Flags & 1) == 1;
    Stars = stars;
    RandRoll = randRoll;
    Index = index;
    Location = LocationNames[location];
    X = x;
    Y = y;
  }
}
