using PKHeX.Core;

namespace PluginPile.Unmaintained.SwShRaidTool;
public partial class SeedFinder : Form {
  private readonly uint TID;
  private readonly uint SID;

  public SeedFinder(uint tid, uint sid) {
    TID = tid;
    SID = sid;
    InitializeComponent();
    CenterToParent();
  }

  public void LoadPKM(PKM pkm) {
    PIDBox.Text = $"{pkm.PID:X8}";
    ECBox.Text = $"{pkm.EncryptionConstant:X8}";

    minHP.Text = $"{pkm.GetIV(0):00}";
    minAtk.Text = $"{pkm.GetIV(1):00}";
    minDef.Text = $"{pkm.GetIV(2):00}";
    MinSpe.Text = $"{pkm.GetIV(3):00}";
    minSpa.Text = $"{pkm.GetIV(4):00}";
    minSpd.Text = $"{pkm.GetIV(5):00}";
  }

  private void SeedBox_KeyPress(object sender, KeyPressEventArgs e) {
    char c = e.KeyChar;
    if (!(Util.IsHex(c) || char.IsControl(e.KeyChar)))
      e.Handled = true;
  }

  private void SeedSlow_Click(object sender, EventArgs e) {
    DialogResult result = WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "这可能需要几分钟。这种方法只能在快速方法不能产生结果的情况下使用。确实要使用此方法吗?");
    if (result == DialogResult.Yes) {
      if (ECBox.Text.Length == 0) return;
      if (PIDBox.Text.Length == 0) return;
      uint ec = uint.Parse(ECBox.Text, System.Globalization.NumberStyles.HexNumber);
      uint pid = uint.Parse(PIDBox.Text, System.Globalization.NumberStyles.HexNumber);
      int[] ivs = [(int)minHP.Value, (int)minAtk.Value, (int)minDef.Value, (int)minSpa.Value, (int)minSpd.Value, (int)MinSpe.Value,];
      IEnumerable<ulong> seeds = BruteForceSearch.FindSeeds(ec, pid, TID, SID);
      SeedResult.Text = FindFirstSeed(seeds, ivs);
    }
  }

  private static string FindFirstSeed(IEnumerable<ulong> potential_seeds, int[] ivs) {
    foreach (ulong seed in potential_seeds) {
      // Verify the IVs; at most 5 can match
      for (int i = 1; i <= 5; i++) { // fixed IV count
        if (!BruteForceSearch.IsMatch(seed, ivs, i))
          continue;
        return $"{seed:X16}";
      }
    }
    return "没找到Seed";
  }

  private void SeedFast_Click(object sender, EventArgs e) {
    if (ECBox.Text.Length == 0) return;
    if (PIDBox.Text.Length == 0) return;
    uint ec = uint.Parse(ECBox.Text, System.Globalization.NumberStyles.HexNumber);
    uint pid = uint.Parse(PIDBox.Text, System.Globalization.NumberStyles.HexNumber);
    int[] ivs = [(int)minHP.Value, (int)minAtk.Value, (int)minDef.Value, (int)minSpa.Value, (int)minSpd.Value, (int)MinSpe.Value];
    try {
      IEnumerable<ulong> seeds = Z3Search.GetSeeds(ec, pid);
      SeedResult.Text = FindFirstSeed(seeds, ivs);
    } catch (Exception ex) {
      WinFormsUtil.Error("此方法需要 Z3. 请将 Z3添加到路径中." + Environment.NewLine + ex.Message, "无法计算seed");
    }
  }

  private void ECBox_Enter(object sender, EventArgs e) {
    TextBox textBox = (TextBox)sender;

    textBox.SelectAll();
  }

  private void MinHP_Enter(object sender, EventArgs e) {
    NumericUpDown numbox = (NumericUpDown)sender;
    numbox.Select(0, numbox.Text.Length);
  }
}
