namespace PluginPile.Unmaintained.BWTool {
  partial class PropcaseForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent() {
      Proplist = new ComboBox();
      HasPropCheckbox = new CheckBox();
      UnlockAll = new Button();
      HexValueLabel = new Label();
      PropHex = new Label();
      Exit = new Button();
      SaveButton = new Button();
      SpriteBox = new PictureBox();
      RemoveAll = new Button();
      ((System.ComponentModel.ISupportInitialize)SpriteBox).BeginInit();
      SuspendLayout();
      //
      // Proplist
      //
      Proplist.FormattingEnabled = true;
      Proplist.Items.AddRange(new object[] {
            "粉色发夹",
            "蓝色发夹",
            "红色发夹",
            "蓝色花朵",
            "红色围巾",
            "红色花朵",
            "大型发夹",
            "发箍",
            "方框眼镜",
            "条纹发夹",
            "小型发夹",
            "装饰缎带",
            "手提袋",
            "项链",
            "艳丽花朵",
            "圆形纽扣",
            "绿色发夹",
            "草帽",
            "雪结晶",
            "单枝的花",
            "画笔",
            "贝雷帽",
            "打蛋器",
            "汤勺",
            "蛋糕模型",
            "厨师帽",
            "平底锅",
            "围嘴",
            "红色阳伞",
            "伤风口罩",
            "铁锤",
            "缤纷阳伞",
            "扳手",
            "手提油灯",
            "发条",
            "安全头盔",
            "褶边围裙",
            "洋装领结",
            "丝质礼帽",
            "红色披风",
            "玩具刀",
            "玩具剑",
            "海贼帽",
            "牛仔帽",
            "坚硬盾牌",
            "漆黑之翼",
            "女巫帽子",
            "纯白之翼",
            "茶色皮带",
            "带角头盔",
            "三叉戟",
            "魔杖",
            "红鼻子",
            "小丑帽",
            "晕晕眼镜",
            "王冠",
            "黑色领带",
            "黑色披风",
            "华丽眼镜",
            "褶边头带",
            "白色面具",
            "白色披风",
            "绅士帽",
            "手杖",
            "斜纹领带",
            "小怀表",
            "蝴蝶领结",
            "后冠",
            "蔷薇花",
            "单片眼镜",
            "横纹领带",
            "爆炸头",
            "立式话筒",
            "铃鼓",
            "小帽子",
            "手持话筒",
            "响葫芦",
            "喇叭",
            "桂冠",
            "白色绒球",
            "旗子",
            "球",
            "优胜腰带",
            "球拍",
            "电吉他",
            "玩具钓竿",
            "笑笑面具",
            "假肚脐",
            "博士帽",
            "草裙",
            "厚重的书",
            "捧花",
            "骨头仿品",
            "圆圆蘑菇",
            "手里剑",
            "红色帽子",
            "大布袋",
            "糖果",
            "密密胡子",
            "礼物盒"});
      Proplist.Location = new Point(30, 32);
      Proplist.Margin = new Padding(4, 3, 4, 3);
      Proplist.Name = "Proplist";
      Proplist.Size = new Size(140, 23);
      Proplist.TabIndex = 0;
      Proplist.SelectedIndexChanged += ProplistSelectedIndexChanged;
      //
      // HasPropCheckbox
      //
      HasPropCheckbox.Location = new Point(196, 32);
      HasPropCheckbox.Margin = new Padding(4, 3, 4, 3);
      HasPropCheckbox.Name = "HasPropCheckbox";
      HasPropCheckbox.Size = new Size(121, 28);
      HasPropCheckbox.TabIndex = 1;
      HasPropCheckbox.Text = "已获得";
      HasPropCheckbox.UseVisualStyleBackColor = true;
      HasPropCheckbox.CheckedChanged += Hasprop_checkboxCheckedChanged;
      //
      // UnlockAll
      //
      UnlockAll.Location = new Point(30, 78);
      UnlockAll.Margin = new Padding(4, 3, 4, 3);
      UnlockAll.Name = "UnlockAll";
      UnlockAll.Size = new Size(119, 27);
      UnlockAll.TabIndex = 2;
      UnlockAll.Text = "解锁全部";
      UnlockAll.UseVisualStyleBackColor = true;
      UnlockAll.Click += UnlockAll_Click;
      //
      // HexValueLabel
      //
      HexValueLabel.Location = new Point(30, 108);
      HexValueLabel.Margin = new Padding(4, 0, 4, 0);
      HexValueLabel.Name = "HexValueLabel";
      HexValueLabel.Size = new Size(117, 27);
      HexValueLabel.TabIndex = 3;
      HexValueLabel.Text = "十六进制:";
      //
      // PropHex
      //
      PropHex.Location = new Point(108, 108);
      PropHex.Margin = new Padding(4, 0, 4, 0);
      PropHex.Name = "PropHex";
      PropHex.Size = new Size(338, 27);
      PropHex.TabIndex = 4;
      PropHex.Text = "0x";
      //
      // Exit
      //
      Exit.Location = new Point(30, 128);
      Exit.Margin = new Padding(4, 3, 4, 3);
      Exit.Name = "Exit";
      Exit.Size = new Size(119, 27);
      Exit.TabIndex = 21;
      Exit.Text = "退出";
      Exit.UseVisualStyleBackColor = true;
      Exit.Click += Exit_Click;
      //
      // SaveButton
      //
      SaveButton.Location = new Point(155, 128);
      SaveButton.Margin = new Padding(4, 3, 4, 3);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(119, 27);
      SaveButton.TabIndex = 20;
      SaveButton.Text = "保存";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += Save_Click;
      //
      // SpriteBox
      //
      SpriteBox.Location = new Point(296, 21);
      SpriteBox.Margin = new Padding(4, 3, 4, 3);
      SpriteBox.Name = "SpriteBox";
      SpriteBox.Size = new Size(129, 73);
      SpriteBox.SizeMode = PictureBoxSizeMode.AutoSize;
      SpriteBox.TabIndex = 22;
      SpriteBox.TabStop = false;
      //
      // RemoveAll
      //
      RemoveAll.Location = new Point(155, 78);
      RemoveAll.Margin = new Padding(4, 3, 4, 3);
      RemoveAll.Name = "RemoveAll";
      RemoveAll.Size = new Size(119, 27);
      RemoveAll.TabIndex = 23;
      RemoveAll.Text = "移除全部";
      RemoveAll.UseVisualStyleBackColor = true;
      RemoveAll.Click += RemoveAll_Click;
      //
      // PropcaseForm
      //
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(458, 163);
      Controls.Add(RemoveAll);
      Controls.Add(UnlockAll);
      Controls.Add(SpriteBox);
      Controls.Add(Exit);
      Controls.Add(SaveButton);
      Controls.Add(PropHex);
      Controls.Add(HexValueLabel);
      Controls.Add(HasPropCheckbox);
      Controls.Add(Proplist);
      Margin = new Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "PropcaseForm";
      Text = "物品箱编辑器";
      ((System.ComponentModel.ISupportInitialize)SpriteBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private System.Windows.Forms.Button RemoveAll;
    private System.Windows.Forms.PictureBox SpriteBox;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Button Exit;
    private System.Windows.Forms.Label PropHex;
    private System.Windows.Forms.Label HexValueLabel;
    private System.Windows.Forms.Button UnlockAll;
    private System.Windows.Forms.CheckBox HasPropCheckbox;
    private System.Windows.Forms.ComboBox Proplist;
  }
}
