using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FontGenRev
{
  public partial class Form1 : Form
  {
    string strOriginalCharSet = "";
    Size sizeCellSize = new Size();

    bool initing = true;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      strOriginalCharSet = textCharSet.Text;

      listWidth.SelectedIndex = 2;
      listHeight.SelectedIndex = 2;

      int iCounter = 0;
      int iBoink = 0;

      foreach (FontFamily fontFamily in FontFamily.Families) {
        listFonts.Items.Add(fontFamily.Name);

        // find Boink
        if (fontFamily.Name == "Boink LET") {
          iBoink = iCounter;
        }

        iCounter++;
      }

      listFonts.SelectedIndex = iBoink;

      initing = false;
      picPreview.Image = RenderFontTexture(true);
    }

    public Size GetCellSize(Graphics g, string strText, Font font)
    {
      Size ret = new Size();

      char cWidest = ' ';
      char cTallest = ' ';

      for (int i = 0; i < strText.Length; i++) {
        // ignore newline and carriage return
        if (strText[i] == '\n' || strText[i] == '\r') {
          continue;
        }

        // get size of character
        SizeF sizeChar = g.MeasureString("" + strText[i], font, 1000, StringFormat.GenericTypographic);

        // update max width
        if (sizeChar.Width > ret.Width) {
          ret.Width = (int)Math.Ceiling(sizeChar.Width);
          cWidest = strText[i];
        }

        // update max height
        if (sizeChar.Height > ret.Height) {
          ret.Height = (int)Math.Ceiling(sizeChar.Height);
          cTallest = strText[i];
        }
      }

      // add additional padding for when shadows are used
      if (checkShadow.Checked) {
        ret.Width += (int)Math.Abs(numShadowX.Value);
        ret.Height += (int)Math.Abs(numShadowY.Value);
      }

      // add optional user padding
      ret.Width += (int)numPadding.Value;
      ret.Height += (int)numPadding.Value;

      return ret;
    }

    public Bitmap RenderFontTexture(bool bPreview)
    {
      if (initing) {
        return null;
      }

      Bitmap bmp = new Bitmap(int.Parse(listWidth.SelectedItem.ToString()), int.Parse(listHeight.SelectedItem.ToString()));

      using (Graphics g = Graphics.FromImage(bmp)) {
        Font font = null;
        try {
          font = new Font(FontFamily.Families[listFonts.SelectedIndex],
            (float)numSize.Value, checkBold.Checked ? FontStyle.Bold : FontStyle.Regular);
        } catch (Exception ex) {
          MessageBox.Show("You can't use this font because: \"" + ex.Message + "\"", "FontGenRev",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return null;
        }

        Size cellSize = GetCellSize(g, textCharSet.Text, font);
        sizeCellSize = cellSize;

        labelCellSize.Text = cellSize.Width + ", " + cellSize.Height;

        int iColumn = 0;
        int iRow = 0;

        string strText = textCharSet.Text;

        for (int i = 0; i < strText.Length; i++) {
          char c = strText[i];

          // ignore carriage returns
          if (c == '\r') {
            continue;
          }

          // handle newline
          if (c == '\n') {
            iColumn = 0;
            iRow++;
            continue;
          }

          // get single character size
          SizeF singleCharSize = g.MeasureString("" + c, font);

          // get shadow values
          int iShadowX = (int)numShadowX.Value;
          int iShadowY = (int)numShadowY.Value;

          // render cell preview
          if (bPreview) {
            g.FillRectangle(i % 2 == 0 ? Brushes.DarkMagenta : Brushes.Fuchsia,
              new Rectangle(iColumn * cellSize.Width, iRow * cellSize.Height, cellSize.Width, cellSize.Height));
          }

          // create a new temporary rendertarget for the single character
          using (Bitmap bmpChar = new Bitmap(cellSize.Width, cellSize.Height)) {
            using (Graphics gChar = Graphics.FromImage(bmpChar)) {
              gChar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

              // render shadow of character if needed
              if (checkShadow.Checked && (iShadowX != 0 || iShadowY != 0)) {
                gChar.DrawString("" + c, font, Brushes.Black, new PointF(
                  Math.Max(0, iShadowX),
                  Math.Max(0, iShadowY)),
                  StringFormat.GenericTypographic);
              }

              // render character
              gChar.DrawString("" + c, font, Brushes.White, new PointF(
                -Math.Min(0, iShadowX),
                -Math.Min(0, iShadowY)),
                StringFormat.GenericTypographic);

              // render the temporary rendertarget to the actual fontmap
              g.DrawImage(bmpChar, iColumn * cellSize.Width, iRow * cellSize.Height);
            }
          }

          /*
          // render shadow of character if needed
          if (checkShadow.Checked && (iShadowX != 0 || iShadowY != 0)) {
            g.DrawString("" + c, font, Brushes.Black, new PointF(
              iColumn * cellSize.Width + Math.Max(0, iShadowX),
              iRow * cellSize.Height + Math.Max(0, iShadowY)),
              StringFormat.GenericTypographic);
          }

          // render character
          g.DrawString("" + c, font, Brushes.White, new PointF(
            iColumn * cellSize.Width + -Math.Min(0, iShadowX),
            iRow * cellSize.Height + -Math.Min(0, iShadowY)),
            StringFormat.GenericTypographic);
          */

          iColumn++;
        }
      }

      return bmp;
    }

    private void listFonts_SelectedIndexChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void numSize_ValueChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void textCharSet_TextChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void checkShadow_CheckedChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void checkBold_CheckedChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void listWidth_SelectedIndexChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void listHeight_SelectedIndexChanged(object sender, EventArgs e)
    {
      picPreview.Image = RenderFontTexture(true);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textCharSet.Text =
        @" ABCDEFGHIJKL
MNOPQRSTUVWXY
Z0123456789";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textCharSet.Text = strOriginalCharSet;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      textCharSet.Text =
        @" ABCDEFGHIJKL
MNOPQRSTUVWXY
Zabcdefghijkl
mnopqrstuvwxy
z0123456789";
    }

    private void buttonExtended_Click(object sender, EventArgs e)
    {
      textCharSet.Text = @" !""#$%&'()*+,-./012345678
9:;<=>?@ABCDEFGHIJKLMNOPQ
RSTUVWXYZ[\]^_`abcdefghij
klmnopqrstuvwxyz{|}~¡¢£¤¥
¦§¨©ª«¬®°±²³´µ¶·¸¹º»¼½¾¿À
ÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙ
ÚÛÜÝÞßàáâãäåæçèéêëìíîïðñò
óôõö÷øùúûüýþÿŒœŠšŸŽžƒˆ°˜–
‘’‚“”„†‡•…‰‹›°€™*/";
    }

    string GetGamePath(string strSubPath)
    {
      string strPath = strSubPath;
      int iSafety = 10;
      do {
        if (iSafety-- <= 0) {
          strPath = "";
          break;
        }

        strPath = Path.GetFullPath(strPath + "..\\");
      } while (!File.Exists(strPath + "Bin\\SeriousSam.exe"));
      return strPath;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      // save as PNG first
      Bitmap bmp = RenderFontTexture(false);
      bmp.Save(textName.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

      // convert to tga using ImageMagick
      Process.Start(textMagick.Text + "\\convert.exe", textName.Text + ".png " + textName.Text + ".tga");

      // copy to Fonts directory
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Title = "Save " + textName.Text + ".tga in the Fonts directory";
      sfd.FileName = textName.Text + ".tga";
      if (sfd.ShowDialog() != DialogResult.OK) {
        return;
      }

      File.Copy(textName.Text + ".tga", sfd.FileName, true);

      // copy charset file
      string strPathFonts = sfd.FileName.Replace(Path.GetFileName(sfd.FileName), "");
      File.WriteAllText(strPathFonts + textName.Text + ".txt", textCharSet.Text);

      // check if Sed is running or not
      bool bSeriousEditorRunning = false;
      Process[] procs = Process.GetProcesses();
      foreach (Process proc in procs) {
        if (proc.ProcessName.ToLower().Contains("seriouseditor")) {
          bSeriousEditorRunning = true;
          break;
        }
      }

      // if Sed is not running, run it (if it can be found)
      if (!bSeriousEditorRunning) {
        string strPathToSed = GetGamePath(strPathFonts) + "Bin\\SeriousEditor.exe";
        if (File.Exists(strPathToSed)) {
          Process.Start(strPathToSed);
        }
      }
    }

    private void buttonMakeFont_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Title = "Locate your generated .tex file in the Fonts directory";
      ofd.Filter = "Font texture file (*.tex)|*.tex";
      if (ofd.ShowDialog() != DialogResult.OK) {
        return;
      }

      string strFilename = Path.GetFileName(ofd.FileName);
      string strPath = GetGamePath(ofd.FileName.Replace(strFilename, ""));
      string strFontPath = strPath + "Fonts\\";

      ProcessStartInfo psi = new ProcessStartInfo();
      psi.WorkingDirectory = strPath;
      psi.FileName = strPath + "Bin\\MakeFONT.exe";
      /*psi.Arguments = "\"" + strFontPath + strFilename + "\" " + sizeCellSize.Width + " " + sizeCellSize.Height + " \"" + strFontPath + strFilename.Replace("tex", "txt") + "\"" +
        (MessageBox.Show("Is this a fixed width font?", "Font generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? " -A" : "");*/
      psi.Arguments = "\"" + ofd.FileName + "\" " + sizeCellSize.Width + " " + sizeCellSize.Height + " \"" + ofd.FileName.Replace("tex", "txt") + "\"";
      Process.Start(psi);
    }
  }
}
