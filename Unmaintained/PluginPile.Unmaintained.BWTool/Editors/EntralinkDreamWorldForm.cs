using PKHeX.Core;

namespace PluginPile.Unmaintained.BWTool;

public partial class EntralinkDreamWorldForm : Form {

  private readonly SAV5 SAV;
  private readonly ExtralinkForest forest;
  private readonly int world = 0;

  public EntralinkDreamWorldForm(SAV5 sav, ExtralinkForest forest, int DW, string Area) {
    InitializeComponent();
    SAV = sav;
    area_label.Text = Area;
    exclusive_label.Text = "";
    this.forest = forest;
    world = DW;
    SetupWorld();
    if (DW < 8) {
      moveboxA.Visible = true;
      moveboxC.Visible = true;
      atkA.Visible = true;
      atkB.Visible = true;
      atkC.Visible = true;

      Move.Text = "招式";

      pgl_region_box.Visible = false;
      region_lab.Visible = false;
      move_lab.Visible = false;
    } else if (DW == 8) {
      moveboxA.Visible = false;
      moveboxC.Visible = false;
      atkA.Visible = false;
      atkB.Visible = false;
      atkC.Visible = false;

      Move.Text = "Info";

      pgl_region_box.Visible = true;
      region_lab.Visible = true;
      move_lab.Visible = true;
    }
  }

  private void SetupWorld() {
    switch (world) {
      case 0://Pleasant forest
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "小拉达",
        "尼多兰(BW*)",
        "尼多朗(BW*)",
        "走路草",
        "喇叭芽",
        "小火马",
        "大葱鸭",
        "嘟嘟",
        "蛋蛋",
        "大舌头",
        "蔓藤怪",
        "袋兽",
        "尾立",
        "宝宝丁(BW*)",
        "咩利羊",
        "毽子草(BW*)",
        "向日种子",
        "惊角鹿",
        "土狼犬",
        "莲叶童子(BW*)",
        "傲骨燕(BW*)",
        "溜溜糖球",
        "大牙狸",
        "小猫怪",
        "圆蝌蚪(B2W2*)",
        "木棉球(B2W2*)",
        "百合根娃娃(B2W2*)",
        "盖盖虫(B2W2*)",
        "小嘴蜗(B2W2*)",
        "魅力喵",
        "蜈蚣王(B2W2*)",
        "可达鸭",
        "卡蒂狗",
        "飞天螳螂",
        "肯泰罗",
        "玛力露",
        "树才怪",
        "麒麟奇",
        "大奶罐",
        "蛇纹熊",
        "落雷兽(BW*)",
        "飘浮泡泡(BW*)",
        "帕奇利兹(BW*)",
        "卷卷耳",
        "六尾",
        "蚊香蝌蚪",
        "天然雀",
        "电击怪",
        "向尾喵"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 1://Windskept Sky
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "巴大蝶(BW*)",
        "波波",
        "烈雀",
        "超音蝠",
        "化石翼龙",
        "咕咕(BW*)",
        "芭瓢虫",
        "毽子草",
        "蜻蜻蜓",
        "黑暗鸦",
        "天蝎",
        "信使鸟",
        "傲骨燕",
        "长翅鸥(BW*)",
        "青绵鸟(BW*)",
        "姆克鸟",
        "豆豆鸽(B2W2*)",
        "象征鸟(B2W2*)",
        "鸭宝宝(B2W2*)",
        "电飞鼠(B2W2*)",
        "盔甲鸟",
        "热带龙",
        "飘飘球(BW*)",
        "聒噪鸟(BW*)"]);
    speciesbox.SelectedIndex = 0;
    break;
      case 2:
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
            "呆呆兽(BW*)",
        "小海狮",
        "大舌贝",
        "大钳蟹(BW*)",
        "墨海马",
        "角金鱼",
        "金鱼王(BW*)",
        "海星星(BW*)",
        "鲤鱼王",
        "菊石兽",
        "化石盔",
        "灯笼鱼",
        "乌波",
        "千针鱼",
        "太阳珊瑚(BW*)",
        "铁炮鱼",
        "巨翅飞鱼",
        "吼吼鲸",
        "泥泥鳅",
        "珍珠贝",
        "古空棘鱼",
        "爱心鱼",
        "泳圈鼬",
        "荧光鱼",
        "野蛮鲈鱼(红条纹的样子)(B2W2*)",
        "野蛮鲈鱼(蓝条纹的样子)(B2W2*)",
        "保姆曼波(B2W2*)",
        "泥巴鱼(B2W2*)",
        "原盖海龟(B2W2*)",
        "玛瑙水母",
        "利牙鱼",
        "龙虾小兵",
        "触手百合",
        "太古羽虫",
        "丑丑鱼",
        "无壳海兔(西海)(BW*)",
        "无壳海兔(东海)(BW*)",
        "拉普拉斯",
        "迷你龙"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 3: // Spooky Mannor
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "鬼斯",
        "催眠貘",
        "魔墙人偶",
        "圆丝蛛",
        "梦妖",
        "果然翁(BW*)",
        "戴鲁比",
        "迷唇娃(BW*)",
        "大嘴娃(BW*)",
        "玛沙那(BW*)",
        "跳跳猪",
        "怨影娃娃",
        "夜巡灵",
        "风铃铃",
        "臭鼬噗",
        "铜镜怪(BW*)",
        "小灰怪(B2W2*)",
        "驹刀小兵(B2W2*)",
        "电蜘蛛(B2W2*)",
        "喵喵(BW*)",
        "布鲁",
        "图图犬",
        "电萤虫",
        "甜甜萤",
        "洛托姆(BW*)",
        "凯西",
        "拉鲁拉丝(BW*)",
        "勾魂眼(BW*)",
        "花岩怪(BW*)",
        "双卵细胞球(B2W2*)",
        "泥偶小人(B2W2*)"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 4:
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "猴怪(BW*)",
        "腕力",
        "小磁怪",
        "瓦斯弹",
        "独角犀牛(BW*)",
        "熔岩虫",
        "小小象(BW*)",
        "幼基拉斯",
        "煤炭龟",
        "大颚蚁",
        "刺球仙人掌",
        "结草儿",
        "沙河马",
        "钳尾蝎(BW*)",
        "熔蚁兽(B2W2*)",
        "铁蚁(B2W2*)",
        "沙铃仙人掌(B2W2*)",
        "岩殿居蟹(B2W2*)",
        "鸭嘴宝宝",
        "熊宝宝(BW*)",
        "幕下力士(BW*)",
        "呆火驼",
        "晃晃斑(BW*)",
        "阿勃梭鲁",
        "铁哑铃(BW*)",
        "不良蛙",
        "无畏小子",
        "宝贝龙",
        "流氓鳄(B2W2*)",
        "利欧路(BW*)"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 5: //Icy cave
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "穿山鼠",
        "小拳石",
        "大岩蛇",
        "霹雳电球",
        "卡拉卡拉",
        "皮宝宝(BW*)",
        "壶壶(BW*)",
        "咕妞妞",
        "朝北鼻(BW*)",
        "可可多拉",
        "月石",
        "太阳岩",
        "天秤偶",
        "海豹球(BW*)",
        "头盖龙(BW*)",
        "雪笠怪",
        "螺钉地鼠(B2W2*)",
        "赤面龙(B2W2*)",
        "地鼠",
        "土龙弟弟(BW*)",
        "地幔岩(B2W2*)",
        "多多冰(B2W2*)",
        "齿轮组(B2W2*)",
        "狃拉",
        "雪童子",
        "盾甲龙(BW*)",
        "小山猪",
        "圆陆鲨",
        "牙牙(B2W2*)"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 6: //Dream Park
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "派拉斯",
        "榛果球",
        "刺尾虫",
        "橡实果",
        "懒人獭",
        "土居忍士",
        "正电拍拍",
        "负电拍拍",
        "溶食兽",
        "变隐龙",
        "圆法师",
        "樱花宝",
        "尖牙笼",
        "差不多娃娃(B2W2*)",
        "投摔鬼(B2W2*)",
        "打击鬼(B2W2*)",
        "滑滑小子(B2W2*)",
        "毛球(BW*)",
        "臭泥(BW*)",
        "三蜜蜂(BW*)",
        "大针蜂(BW*)",
        "阿柏蛇",
        "波克比",
        "长尾怪手",
        "蘑蘑菇",
        "铁骨土人(B2W2*)",
        "毒蔷薇",
        "猫鼬斩(BW*)",
        "饭匙蛇(BW*)",
        "吉利蛋",
        "凯罗斯",
        "伊布",
        "卡比兽",
        "赫拉克罗斯"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 7://Pokemon Cafe forest
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "蚊香君",
        "伊布",
        "图图犬",
        "结草儿"]);
    speciesbox.SelectedIndex = 0;
        break;
      case 8://PGL Promotions
        speciesbox.Items.Clear();
        speciesbox.Items.AddRange([
        "水伊布",
        "雷伊布",
        "火伊布",
        "太阳伊布",
        "月亮伊布",
        "叶伊布",
        "冰伊布",
        "妙蛙种子",
        "小火龙",
        "杰尼龟",
        "不良蛙",
        "草苗龟",
        "小火焰猴",
        "波加曼",
        "阿尔宙斯",
        "木守宫",
        "火稚鸡",
        "水跃鱼",
        "波克基斯",
        "象牙猪",
        "多边兽",
        "烈空坐",
        "诅咒娃娃",
        "不良蛙",
        "七夕青鸟",
        "幸福蛋",
        "路卡利欧",
        "哥德小童",
        "皮卡丘",
        "毽子棉",
        "花椰猴",
        "爆香猴",
        "冷水猴",
        "草苗龟",
        "小火焰猴",
        "波加曼",
        "哥德小童",
        "巨钳螳螂",
        "烈咬陆鲨",
        "快龙",
        "班基拉斯",
        "快龙",
        "巨金怪"]);
        speciesbox.SelectedIndex = 0;
        break;
    }
    atkA.Checked = true;
    UpdateAtk();
  }
  void Ok_butClick(object sender, EventArgs e) {
    if (world < 8) {
      //Handle forms
      if (world == 2 && (speciesbox.SelectedIndex == 25 || speciesbox.SelectedIndex == 36)) //Blue basculin, East Sea shellos
        EntralinkForm.DreamPkm = ExtralinkForest.CreatePkm(WorldSpecies[world][speciesbox.SelectedIndex], WorldAttacks[world][speciesbox.SelectedIndex][atk], gender, 1, RandomFormAnim());
      else
        EntralinkForm.DreamPkm = ExtralinkForest.CreatePkm(WorldSpecies[world][speciesbox.SelectedIndex], WorldAttacks[world][speciesbox.SelectedIndex][atk], gender, 0, RandomFormAnim());
    } else if (world == 8) {
      int anim = 0;
      //Random Animation disabled and set to 0, as I've seen several PGL pokemon with Animation 0 (Arceus, porygon, banette, croagunk, togekiss and lucario) and also a gothorita in a white 2 savegame
      //anim = RandomFormAnim();
      if (WorldSpecies[world][speciesbox.SelectedIndex] == 473)
        anim = 4; //But Mamoswine has, for some reason, Animation 04, being the only known exception (would need more legit saves with the events)
      EntralinkForm.DreamPkm = ExtralinkForest.CreatePkm(WorldSpecies[world][speciesbox.SelectedIndex], PGLAttacks[speciesbox.SelectedIndex], gender, 0, anim);
    }
    this.Close();
  }
  void Cancel_butClick(object sender, EventArgs e) {
    this.Close();
  }
  void SpeciesboxSelectedIndexChanged(object sender, EventArgs e) {
    //atkA.Checked = true;
    UpdateAtk();
    UpdateGnd();

    bool exclusive = false;
    if (world < 8) {
      if (SAV is SAV5B2W2) {
        for (int i = 0; i < WorldBW1Exclusives[world].Length; i++) {
          if (WorldBW1Exclusives[world][i] == WorldSpecies[world][speciesbox.SelectedIndex]) {
            exclusive = true;
          }
        }
        if (exclusive) {
          exclusive_label.Text = "仅黑白";
          ok_but.Enabled = false;
        }

      } else {
        for (int i = 0; i < WorldBW2Exclusives[world].Length; i++) {
          if (WorldBW2Exclusives[world][i] == WorldSpecies[world][speciesbox.SelectedIndex]) {
            exclusive = true;
          }
        }
        if (exclusive) {
          exclusive_label.Text = "仅黑白2";
          ok_but.Enabled = false;
        }
      }

    } else if (world == 8) {
      if (SAV is SAV5B2W2) {
        if (PGL_exclusives[speciesbox.SelectedIndex] == 0) {
          exclusive_label.Text = "仅黑白";
          ok_but.Enabled = false;
          exclusive = true;
        }
      } else {
        if (PGL_exclusives[speciesbox.SelectedIndex] == 1) {
          exclusive_label.Text = "仅黑白2";
          ok_but.Enabled = false;
          exclusive = true;
        }
      }

      pgl_region_box.SelectedIndex = speciesbox.SelectedIndex;
    }

    if (!exclusive) {
      exclusive_label.Text = "";
      ok_but.Enabled = true;
    }

  }

  private readonly int[][] WorldSpecies = [
    [019, 029, 032, 043, 069, 077, 083, 084, 102, 108, 114, 115, 161, 174, 179, 187, 191, 234, 261, 270, 276, 283, 399, 403, 535, 546, 548, 588, 616, 431, 545, 054, 058, 123, 128, 183, 185, 203, 241, 263, 309, 351, 417, 427, 037, 060, 177, 239, 300],
    [12, 16, 21, 41, 142, 163, 165, 187, 193, 198, 207, 225, 276, 278, 333, 397, 519, 561, 580, 587, 227, 357, 425, 441],
    [79, 86, 90, 98, 116, 118, 119, 120, 129, 138, 140, 170, 194, 211, 222, 223, 226, 320, 339, 366, 369, 370, 418, 456, 550, 550, 594, 618, 564, 72, 318, 341, 345, 347, 349, 422, 422, 131, 147],
    [92, 96, 122, 167, 200, 202, 228, 238, 303, 307, 325, 353, 355, 358, 434, 436, 605, 624, 596, 52, 209, 235, 313, 314, 479, 63, 280, 302, 442, 578, 622],
    [56, 66, 81, 109, 111, 218, 231, 246, 324, 328, 331, 412, 449, 451, 631, 632, 556, 558, 240, 216, 296, 322, 327, 359, 374, 453, 236, 371, 553, 447],
    [27, 74, 95, 100, 104, 173, 213, 293, 299, 304, 337, 338, 343, 363, 408, 459, 529, 621, 50, 206, 525, 583, 600, 215, 361, 410, 220, 443, 610],
    [46, 204, 265, 273, 287, 290, 311, 312, 316, 352, 401, 420, 455, 531, 538, 539, 559, 48, 88, 415, 15, 23, 175, 190, 285, 533, 315, 335, 336, 113, 127, 133, 143, 214],
    [061, 133, 235, 412], //Pokemon Cafe forest
    [134, 135, 136, 196, 197, 470, 471, 1, 4, 7, 453, 387, 390, 393, 493, 252, 255, 258, 468, 473, 137, 384, 354, 453, 334, 242, 448, 575, 25, 189, 511, 513, 515, 387, 390, 393, 575, 212, 445, 149, 248, 149, 376, 376]
  ];

  private readonly int[][][] WorldAttacks = [
    [[98, 382, 231], [10, 389, 162], [64, 68, 162], [230, 298, 202], [22, 235, 402], [33, 37, 257], [210, 355, 348], [45, 175, 355], [140, 235, 202], [122, 214, 431], [79, 73, 402], [252, 68, 409], [10, 203, 343], [47, 313, 270], [84, 115, 351], [235, 270, 331], [72, 230, 414], [33, 50, 285], [336, 305, 399], [71, 73, 352], [64, 119, 366], [145, 56, 202], [33, 401, 290], [268, 393, 400], [496, 414, 352], [73, 227, 388], [79, 204, 230], [203, 224, 450], [51, 226, 227], [252, 372, 290], [342, 390, 276], [346, 227, 362], [44, 34, 203], [98, 226, 366], [99, 231, 431], [111, 453, 8], [175, 205, 272], [93, 243, 285], [111, 174, 231], [33, 271, 387], [86, 423, 324], [52, 466, 352], [98, 343, 351], [193, 252, 409], [46, 257, 399], [95, 54, 214], [101, 297, 202], [84, 238, 393], [193, 321, 445]],
    [[93, 355, 314], [16, 211, 290], [64, 185, 211], [48, 95, 162], [44, 372, 446], [193, 101, 278], [4, 450, 9], [235, 227, 340], [98, 364, 202], [64, 109, 355], [28, 364, 366], [217, 420, 264], [64, 203, 413], [55, 239, 351], [64, 297, 355], [17, 297, 366], [16, 95, 234], [95, 500, 257], [432, 362, 382], [98, 403, 204], [64, 65, 355], [16, 73, 318], [107, 95, 285], [119, 417, 272]],
    [[281, 335, 362], [29, 333, 214], [110, 112, 196], [11, 133, 290], [145, 190, 362], [64, 60, 352], [352, 214, 203], [55, 278, 196], [150, 175, 340], [44, 330, 196], [71, 175, 446], [86, 133, 351], [55, 34, 401], [40, 453, 290], [145, 109, 446], [199, 350, 362], [48, 243, 314], [55, 214, 340], [189, 214, 209], [250, 445, 392], [55, 214, 414], [204, 300, 196], [346, 163, 352], [213, 186, 352], [29, 97, 428], [29, 97, 428], [392, 243, 220], [189, 174, 281], [205, 175, 334], [48, 367, 202], [44, 37, 399], [106, 232, 283], [51, 243, 202], [10, 446, 440], [150, 445, 243], [189, 281, 290], [189, 281, 290], [109, 32, 196], [86, 352, 225]],
    [[95, 50, 482], [95, 427, 409], [112, 298, 285], [40, 527, 450], [149, 194, 517], [243, 204, 227], [336, 364, 399], [186, 445, 285], [313, 424, 8], [96, 409, 203], [149, 285, 278], [101, 194, 220], [50, 220, 271], [35, 95, 304], [103, 492, 389], [95, 285, 356], [377, 112, 417], [210, 427, 389], [486, 50, 228], [10, 95, 290], [204, 370, 38], [166, 445, 214], [148, 271, 366], [204, 313, 366], [86, 351, 324], [100, 285, 356], [93, 194, 270], [193, 389, 180], [180, 220, 196], [105, 286, 271], [205, 7, 9]],
    [[67, 179, 9], [67, 418, 270], [319, 278, 356], [123, 399, 482], [30, 68, 38], [52, 517, 257], [175, 484, 402], [44, 399, 446], [52, 90, 446], [44, 324, 202], [71, 298, 9], [182, 450, 173], [44, 254, 276], [44, 97, 401], [510, 257, 202], [210, 203, 422], [42, 73, 191], [157, 68, 400], [52, 9, 257], [313, 242, 264], [292, 270, 8], [52, 34, 257], [383, 252, 276], [364, 224, 276], [36, 428, 442], [40, 409, 441], [252, 364, 183], [44, 349, 200], [242, 68, 212], [203, 418, 264]],
    [[28, 68, 162], [111, 446, 431], [20, 446, 431], [268, 324, 363], [125, 195, 67], [227, 312, 214], [227, 270, 504], [253, 283, 428], [33, 446, 246], [106, 283, 457], [93, 414, 236], [93, 428, 234], [229, 356, 428], [181, 90, 401], [29, 442, 7], [75, 419, 202], [229, 319, 431], [44, 424, 389], [28, 251, 446], [111, 277, 446], [479, 174, 484], [429, 420, 286], [451, 356, 393], [269, 8, 67], [181, 311, 352], [182, 68, 90], [316, 246, 333], [82, 200, 203], [82, 68, 400]],
    [[78, 440, 235], [120, 390, 356], [40, 450, 173], [74, 331, 492], [281, 400, 389], [141, 203, 400], [86, 435, 324], [86, 435, 324], [139, 151, 202], [185, 285, 513], [522, 283, 253], [73, 505, 331], [44, 476, 380], [270, 227, 281], [20, 8, 276], [249, 9, 530], [67, 252, 409], [50, 226, 285], [139, 114, 425], [16, 366, 314], [31, 314, 210], [40, 251, 399], [118, 381, 253], [10, 252, 7], [78, 331, 264], [67, 183, 409], [74, 79, 129], [98, 458, 67], [44, 34, 401], [45, 68, 270], [11, 370, 382], [28, 204, 129], [133, 7, 278], [30, 175, 264]],
    [[240, 114, 352], [270, 204, 129], [166, 445, 214], [182, 450, 173]] //Pokemon Cafe forest
  ];

  private readonly int[] PGLAttacks = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 217, 0, 0, 0, 538, 398, 206, 0, 418, 243, 29, 206, 437, 257, 56, 254, 252, 297, 286, 211, 0, 9, 69, 245, 38];

  /*
  //Method deprecated, it seems there's no gender restriction outside pokemon being male/female only or genderless
  private readonly int[][] WorldGender = [
    // 0: only male, 1: only female, 2: genderless, 3: male/female
    [0, 0],
    [0, 0],
    [0, 0],
    [0, 0],
    [0, 0],
    [0, 0],
    [0, 0],
    [3, 3, 3, 3] //Pokemon Cafe forest
  ];
  */

  private readonly int[][] WorldBW1Exclusives = [
    [029, 032, 174, 187, 270, 276, 283, 309, 351, 417],//Pleasant Forest
    [012, 163, 278, 333, 425, 441],//Windswept Sky
    [079, 098, 119, 120, 222, 422, 422],
    [202, 238, 303, 307, 436, 052, 479, 280, 302, 442],
    [056, 111, 231, 451, 216, 296, 327, 374, 447],
    [173, 213, 299, 363, 408, 206, 410],
    [048, 88, 415, 15, 335, 336],
    [0] //Pokemon Cafe forest
  ];

  private readonly int[][] WorldBW2Exclusives = [
    [535, 546, 548, 588, 616, 545],//Pleasant Forest
    [519, 561, 580, 587],//Windswept Sky
    [550, 550, 594, 618, 564],
    [605, 624, 596, 578],
    [631, 632, 556, 558, 553],
    [529, 621, 525, 583, 600, 610],
    [531, 538, 539, 559, 533],
    [0] //Pokemon Cafe forest
  ];

  private readonly int[] PGL_exclusives = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2];

  public static int RandomFormAnim() {
    Random rnd = new Random(Guid.NewGuid().GetHashCode());
    int anim = rnd.Next(15);
    if (IsOdd(anim))
      anim--;
    return anim;
  }
  public static bool IsOdd(int value) {
    return value % 2 != 0;
  }

  private int atk = 0;
  private void UpdateAtk() {
    if (world < 8) {
      if (atkA.Checked)
        atk = 0;
      else if (atkB.Checked)
        atk = 1;
      else if (atkC.Checked)
        atk = 2;

      moveboxA.SelectedIndex = WorldAttacks[world][speciesbox.SelectedIndex][0];
      movebox.SelectedIndex = WorldAttacks[world][speciesbox.SelectedIndex][1];
      moveboxC.SelectedIndex = WorldAttacks[world][speciesbox.SelectedIndex][2];
    } else if (world == 8) {
      movebox.SelectedIndex = PGLAttacks[speciesbox.SelectedIndex];
    }
  }
  void AtkACheckedChanged(object sender, EventArgs e) {
    UpdateAtk();
  }
  void AtkBCheckedChanged(object sender, EventArgs e) {
    UpdateAtk();
  }
  void AtkCCheckedChanged(object sender, EventArgs e) {
    UpdateAtk();
  }

  private int gender = 0;
  private void UpdateGnd() {
    //Handle genders
    bool special_gender = false;
    for (int i = 0; i < EntralinkForm.BWFemaleOnly.Length; i++) {
      if (WorldSpecies[world][speciesbox.SelectedIndex] == EntralinkForm.BWFemaleOnly[i]) {
        //Only female
        special_gender = true;
        gnd_female.Checked = true;
        gnd_male.Enabled = false;
        gnd_female.Enabled = true;
        gnd_none.Enabled = false;
      }
    }

    for (int i = 0; i < EntralinkForm.BWMaleOnly.Length; i++) {
      if (WorldSpecies[world][speciesbox.SelectedIndex] == EntralinkForm.BWMaleOnly[i]) {
        //Only male
        special_gender = true;
        gnd_male.Checked = true;
        gnd_male.Enabled = true;
        gnd_female.Enabled = false;
        gnd_none.Enabled = false;
      }
    }

    for (int i = 0; i < EntralinkForm.BWGenderless.Length; i++) {
      if (WorldSpecies[world][speciesbox.SelectedIndex] == EntralinkForm.BWGenderless[i]) {
        //Only genderless
        special_gender = true;
        gnd_none.Checked = true;
        gnd_male.Enabled = false;
        gnd_female.Enabled = false;
        gnd_none.Enabled = true;
      }
    }

    if (!special_gender) {
      //Male/female
      if (gender == 2 || (world == 8)) {
        if (world == 8 && speciesbox.SelectedIndex == 22) { //Banette is the only female pokemon distributed via PGL
          gnd_female.Checked = true;
          gnd_male.Enabled = false;
          gnd_female.Enabled = true;
        } else {
          if (world == 8)
            gnd_female.Enabled = false;
          gnd_male.Checked = true;
          gnd_male.Enabled = true;
        }
      }
      if (!gnd_male.Checked && !gnd_female.Checked && !gnd_none.Checked) {
        if (world == 8 && speciesbox.SelectedIndex == 22) { //Banette is the only female pokemon distributed via PGL
          gnd_female.Enabled = true;
          gnd_female.Checked = true;
          gnd_male.Enabled = false;
        } else {
          if (world == 8)
            gnd_female.Enabled = false;
          gnd_male.Checked = true;
          gnd_male.Enabled = true;
        }
      }
      if (world != 8)
        gnd_male.Enabled = true;
      if (world != 8)
        gnd_female.Enabled = true;
      gnd_none.Enabled = false;
    }

    /*
      switch(WorldGender[world][speciesbox.SelectedIndex])
      {
        case 0://male only
          gnd_male.Checked = true;
          gnd_male.Enabled = true;
          gnd_female.Enabled = false;
          gnd_none.Enabled = false;
          break;
        case 1://female only
          gnd_female.Checked = true;
          gnd_male.Enabled = false;
          gnd_female.Enabled = true;
          gnd_none.Enabled = false;
          break;
        case 2://genderless
          gnd_none.Checked = true;
          gnd_male.Enabled = false;
          gnd_female.Enabled = false;
          gnd_none.Enabled = true;
          break;
        default://male/female
          if (Gender == 2)
            gnd_male.Checked = true;
          if (!gnd_male.Checked && !gnd_female.Checked && !gnd_none.Checked)
            gnd_male.Checked = true;
          gnd_male.Enabled = true;
          gnd_female.Enabled = true;
          gnd_none.Enabled = false;
          break;
      }
     */

    if (gnd_male.Checked)
      gender = 0;
    else if (gnd_female.Checked)
      gender = 1;
    else if (gnd_none.Checked)
      gender = 2;
  }

  void Gnd_maleCheckedChanged(object sender, EventArgs e) {
    UpdateGnd();
  }
  void Gnd_femaleCheckedChanged(object sender, EventArgs e) {
    UpdateGnd();
  }
  void Gnd_noneCheckedChanged(object sender, EventArgs e) {
    UpdateGnd();
  }

}
