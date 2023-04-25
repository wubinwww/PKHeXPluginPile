using PKHeX.Core;
using System.Buffers.Binary;
using System.Drawing.Imaging;

namespace PluginPile.SVProfilePictureViewer {
  public partial class PictureViewerForm : Form {

    private readonly SAV9SV sav;

    public PictureViewerForm(SAV9SV sav9sv) {
      InitializeComponent();
      HandleLanguageChange();
      sav = sav9sv;
      currentProfilePicture.Image = ExtractImage(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureHeight, Constants.CurrentProfilePictureWidth);
      currentProfileIcon.Image = ExtractImage(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconHeight, Constants.CurrentProfileIconWidth);
      initialProfilePicture.Image = ExtractImage(Constants.InitialProfilePictureImage, Constants.InitialProfilePictureHeight, Constants.InitialProfilePictureWidth);
      initialProfileIcon.Image = ExtractImage(Constants.InitialProfileIconImage, Constants.InitialProfileIconHeight, Constants.InitialProfileIconWidth);
    }

    private void HandleLanguageChange() {
      Text = Language.PluginName;
      exportButton.Text = Language.Export;
      currentProfilePicturePage.Text = Language.CurrentProfilePicture;
      currentProfileIconPage.Text = Language.CurrentProfileIcon;
      initialProfilePicturePage.Text = Language.InitialProfilePicture;
      initialProfileIconPage.Text = Language.InitialProfileIcon;
      importProfilePictureButton.Text = Language.ImportPicture;
      importProfileIconButton.Text = Language.ImportIcon;
    }

    private void saveButton_Click(object sender, EventArgs e) {
      (Image? image, string name) = tabs.SelectedIndex switch {
        0 => (currentProfilePicture.Image, "current_profile.png"),
        1 => (currentProfileIcon.Image, "current_icon.png"),
        2 => (initialProfilePicture.Image, "initial_profile.png"),
        3 => (currentProfileIcon.Image, "initial_icon.png"),
        _ => (null, string.Empty)
      };
      if (image == null) return;

      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = name;
      saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
      if (saveFileDialog.ShowDialog() == DialogResult.OK) {
        ImageFormat format = Path.GetExtension(saveFileDialog.FileName) switch {
          ".jpg" or ".jpeg" => ImageFormat.Jpeg,
          ".bmp" => ImageFormat.Bmp,
          ".png" or _ => ImageFormat.Png,
        };
        image.Save(saveFileDialog.FileName, format);
      }
    }

    /// <summary>
    /// Obtain Bitmap from BGR565 formated bytes in block
    /// </summary>
    private Bitmap ExtractImage(uint imageBlcok, uint heightBlock, uint widthBlock) {
      SCBlock image = sav.Blocks.GetBlock(imageBlcok);
      int height = (int)sav.Blocks.GetBlockValue<uint>(heightBlock);
      int width = (int)sav.Blocks.GetBlockValue<uint>(widthBlock);

      Color BytesToColor(int offset) {
        byte[] colourBytes = image.Data[offset..(offset + 2)];
        int colour = BinaryPrimitives.ReadUInt16LittleEndian(colourBytes);
        int b =  (colour & 0x001F) <<  3;
        int g = ((colour & 0x07E0) >>  5) << 2;
        int r = ((colour & 0xF800) >> 11) << 3;
        return Color.FromArgb(255, r, g, b);
      }

      Bitmap ExtractComponent(int offset, bool useMask = false) {
        Bitmap bitmap = new Bitmap(width / 4, height / 4);
        for (int y = 0, byteIndex = 0; y < bitmap.Height; y++) {
          for (int x = 0; x < bitmap.Width; x++, byteIndex += 8) {
            Color c = BytesToColor(byteIndex + offset);
            if (useMask) {
              Color m = BytesToColor(byteIndex + offset + 4);
              int alpha = (m.R + m.G + m.B) / 3;
              c = Color.FromArgb(alpha, c);
            }
            bitmap.SetPixel(x, y, c);
          }
        }
        return bitmap;
      }

      // TODO: Figure out how light mask is used.
      Bitmap light = ExtractComponent(0);
      Bitmap dark = ExtractComponent(2, true);
      Graphics g = Graphics.FromImage(light);
      g.DrawImage(dark, 0, 0);
      return light;
    }

    private Bitmap? SelectImage(int id) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = Language.ImportTitle;
      openFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        using Image image = Image.FromFile(openFileDialog.FileName);
        if (id == 1)
          return new Bitmap(image, 360, 208);
        else
          return new Bitmap(image, 56, 56);
      }
      return null;
    }

    private byte[] BitmapToBlockData(Bitmap bitmap, int size) {
      byte[] data = new byte[size];
      for (int y = 0, byteIndex = 0; y < bitmap.Height; y++) {
        for (int x = 0; x < bitmap.Width; x++, byteIndex += 8) {
          Color color = bitmap.GetPixel(x, y);
          int r = color.R;
          int g = color.G;
          int b = color.B;
          int color_int = ((r >> 3) << 11) | ((g >> 2) << 5) | (b >> 3);
          BinaryPrimitives.WriteUInt16LittleEndian(data.AsSpan(byteIndex..(byteIndex + 2)), (ushort)color_int);
        }
      }
      return data;
    }

    private void importProfilePictureButton_Click(object sender, EventArgs e) {
      Bitmap? bitmap = SelectImage(1);
      if (bitmap == null) return;
      sav.Blocks.SetBlockValue(Constants.CurrentProfilePictureWidth, (uint)1440);
      sav.Blocks.SetBlockValue(Constants.CurrentProfilePictureHeight, (uint)832);
      sav.Blocks.SetBlockValue(Constants.CurrentProfilePictureSize, (uint)599040);
      byte[] data = BitmapToBlockData(bitmap, 622080);
      sav.Blocks.GetBlock(Constants.CurrentProfilePictureImage).ChangeData(data);
      currentProfilePicture.Image = ExtractImage(Constants.CurrentProfilePictureImage, Constants.CurrentProfilePictureHeight, Constants.CurrentProfilePictureWidth);
      sav.State.Edited = true;
    }

    private void importProfileIconButton_Click(object sender, EventArgs e) {
      Bitmap? bitmap = SelectImage(2);
      if (bitmap == null) return;
      sav.Blocks.SetBlockValue(Constants.CurrentProfileIconWidth, (uint)224);
      sav.Blocks.SetBlockValue(Constants.CurrentProfileIconHeight, (uint)224);
      sav.Blocks.SetBlockValue(Constants.CurrentProfileIconSize, (uint)25088);
      byte[] data = BitmapToBlockData(bitmap, 61952);
      sav.Blocks.GetBlock(Constants.CurrentProfileIconImage).ChangeData(data);
      currentProfileIcon.Image = ExtractImage(Constants.CurrentProfileIconImage, Constants.CurrentProfileIconHeight, Constants.CurrentProfileIconWidth);
      sav.State.Edited = true;
    }
  }
}
