namespace FontGenRev
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.picPreview = new System.Windows.Forms.PictureBox();
      this.listFonts = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonMakeFont = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.numSize = new System.Windows.Forms.NumericUpDown();
      this.textCharSet = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.checkShadow = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.numPadding = new System.Windows.Forms.NumericUpDown();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.textName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textMagick = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.listWidth = new System.Windows.Forms.ComboBox();
      this.listHeight = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.labelCellSize = new System.Windows.Forms.Label();
      this.numShadowX = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.numShadowY = new System.Windows.Forms.NumericUpDown();
      this.checkBold = new System.Windows.Forms.CheckBox();
      this.buttonExtended = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPadding)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numShadowX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numShadowY)).BeginInit();
      this.SuspendLayout();
      // 
      // picPreview
      // 
      this.picPreview.Location = new System.Drawing.Point(12, 12);
      this.picPreview.Name = "picPreview";
      this.picPreview.Size = new System.Drawing.Size(512, 512);
      this.picPreview.TabIndex = 0;
      this.picPreview.TabStop = false;
      // 
      // listFonts
      // 
      this.listFonts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.listFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.listFonts.FormattingEnabled = true;
      this.listFonts.Location = new System.Drawing.Point(594, 345);
      this.listFonts.Name = "listFonts";
      this.listFonts.Size = new System.Drawing.Size(223, 21);
      this.listFonts.TabIndex = 1;
      this.listFonts.SelectedIndexChanged += new System.EventHandler(this.listFonts_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(557, 348);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Font:";
      // 
      // buttonSave
      // 
      this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSave.Location = new System.Drawing.Point(742, 499);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 3;
      this.buttonSave.Text = "Save";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // buttonMakeFont
      // 
      this.buttonMakeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonMakeFont.Location = new System.Drawing.Point(661, 499);
      this.buttonMakeFont.Name = "buttonMakeFont";
      this.buttonMakeFont.Size = new System.Drawing.Size(75, 23);
      this.buttonMakeFont.TabIndex = 4;
      this.buttonMakeFont.Text = "MakeFont";
      this.buttonMakeFont.UseVisualStyleBackColor = true;
      this.buttonMakeFont.Click += new System.EventHandler(this.buttonMakeFont_Click);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(536, 374);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Font size:";
      // 
      // numSize
      // 
      this.numSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numSize.Location = new System.Drawing.Point(594, 372);
      this.numSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.numSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.numSize.Name = "numSize";
      this.numSize.Size = new System.Drawing.Size(82, 20);
      this.numSize.TabIndex = 6;
      this.numSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
      // 
      // textCharSet
      // 
      this.textCharSet.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textCharSet.Location = new System.Drawing.Point(530, 25);
      this.textCharSet.Multiline = true;
      this.textCharSet.Name = "textCharSet";
      this.textCharSet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textCharSet.Size = new System.Drawing.Size(182, 110);
      this.textCharSet.TabIndex = 7;
      this.textCharSet.Text = " !\"$#%&\'()*+,-./01234\r\n56789:;<=>?@ABCDEFGHI\r\nJKLMNOPQRSTUVWXYZ[\\]^\r\n_`abcdefghij" +
    "klmnopqrs\r\ntuvwxyz{|}~ÄÀÁÂÇÆÈÐËÈ\r\nÉÊÍÌÎÏÖÒÓÔŠÜÙÚÑŽßäáàâ\r\nèæçðëéèêöóòôšüúùïíìîñ\r\n" +
    "ž¡¿";
      this.textCharSet.WordWrap = false;
      this.textCharSet.TextChanged += new System.EventHandler(this.textCharSet_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(530, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Character set:";
      // 
      // checkShadow
      // 
      this.checkShadow.AutoSize = true;
      this.checkShadow.Location = new System.Drawing.Point(594, 398);
      this.checkShadow.Name = "checkShadow";
      this.checkShadow.Size = new System.Drawing.Size(65, 17);
      this.checkShadow.TabIndex = 9;
      this.checkShadow.Text = "Shadow";
      this.checkShadow.UseVisualStyleBackColor = true;
      this.checkShadow.CheckedChanged += new System.EventHandler(this.checkShadow_CheckedChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(539, 449);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Padding:";
      // 
      // numPadding
      // 
      this.numPadding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numPadding.Location = new System.Drawing.Point(594, 447);
      this.numPadding.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.numPadding.Name = "numPadding";
      this.numPadding.Size = new System.Drawing.Size(82, 20);
      this.numPadding.TabIndex = 6;
      this.numPadding.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(718, 54);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(99, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "Alphanum";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(718, 112);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(99, 23);
      this.button2.TabIndex = 11;
      this.button2.Text = "Original";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(718, 25);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(99, 23);
      this.button3.TabIndex = 11;
      this.button3.Text = "Alphanum (lower)";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(550, 476);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Name:";
      // 
      // textName
      // 
      this.textName.Location = new System.Drawing.Point(594, 473);
      this.textName.Name = "textName";
      this.textName.Size = new System.Drawing.Size(100, 20);
      this.textName.TabIndex = 13;
      this.textName.Text = "Font";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(543, 144);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(45, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Magick:";
      // 
      // textMagick
      // 
      this.textMagick.Location = new System.Drawing.Point(594, 141);
      this.textMagick.Name = "textMagick";
      this.textMagick.Size = new System.Drawing.Size(223, 20);
      this.textMagick.TabIndex = 15;
      this.textMagick.Text = "C:\\Program Files (x86)\\ImageMagick-6.8.7-Q16";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(550, 170);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(38, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Width:";
      // 
      // listWidth
      // 
      this.listWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.listWidth.FormattingEnabled = true;
      this.listWidth.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048"});
      this.listWidth.Location = new System.Drawing.Point(594, 167);
      this.listWidth.Name = "listWidth";
      this.listWidth.Size = new System.Drawing.Size(69, 21);
      this.listWidth.TabIndex = 17;
      this.listWidth.SelectedIndexChanged += new System.EventHandler(this.listWidth_SelectedIndexChanged);
      // 
      // listHeight
      // 
      this.listHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.listHeight.FormattingEnabled = true;
      this.listHeight.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048"});
      this.listHeight.Location = new System.Drawing.Point(594, 194);
      this.listHeight.Name = "listHeight";
      this.listHeight.Size = new System.Drawing.Size(69, 21);
      this.listHeight.TabIndex = 17;
      this.listHeight.SelectedIndexChanged += new System.EventHandler(this.listHeight_SelectedIndexChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(547, 197);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(41, 13);
      this.label8.TabIndex = 16;
      this.label8.Text = "Height:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(558, 298);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(27, 13);
      this.label9.TabIndex = 18;
      this.label9.Text = "Cell:";
      // 
      // labelCellSize
      // 
      this.labelCellSize.AutoSize = true;
      this.labelCellSize.Location = new System.Drawing.Point(591, 298);
      this.labelCellSize.Name = "labelCellSize";
      this.labelCellSize.Size = new System.Drawing.Size(66, 13);
      this.labelCellSize.TabIndex = 18;
      this.labelCellSize.Text = "labelCellSize";
      // 
      // numShadowX
      // 
      this.numShadowX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numShadowX.Location = new System.Drawing.Point(594, 421);
      this.numShadowX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numShadowX.Name = "numShadowX";
      this.numShadowX.Size = new System.Drawing.Size(63, 20);
      this.numShadowX.TabIndex = 6;
      this.numShadowX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numShadowX.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(539, 423);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(49, 13);
      this.label10.TabIndex = 10;
      this.label10.Text = "Shadow:";
      // 
      // numShadowY
      // 
      this.numShadowY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numShadowY.Location = new System.Drawing.Point(663, 421);
      this.numShadowY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numShadowY.Name = "numShadowY";
      this.numShadowY.Size = new System.Drawing.Size(63, 20);
      this.numShadowY.TabIndex = 6;
      this.numShadowY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numShadowY.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
      // 
      // checkBold
      // 
      this.checkBold.AutoSize = true;
      this.checkBold.Location = new System.Drawing.Point(665, 398);
      this.checkBold.Name = "checkBold";
      this.checkBold.Size = new System.Drawing.Size(47, 17);
      this.checkBold.TabIndex = 9;
      this.checkBold.Text = "Bold";
      this.checkBold.UseVisualStyleBackColor = true;
      this.checkBold.CheckedChanged += new System.EventHandler(this.checkBold_CheckedChanged);
      // 
      // buttonExtended
      // 
      this.buttonExtended.Location = new System.Drawing.Point(718, 83);
      this.buttonExtended.Name = "buttonExtended";
      this.buttonExtended.Size = new System.Drawing.Size(99, 23);
      this.buttonExtended.TabIndex = 11;
      this.buttonExtended.Text = "Extended";
      this.buttonExtended.UseVisualStyleBackColor = true;
      this.buttonExtended.Click += new System.EventHandler(this.buttonExtended_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(829, 534);
      this.Controls.Add(this.labelCellSize);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.listHeight);
      this.Controls.Add(this.listWidth);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textMagick);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textName);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.buttonExtended);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.checkBold);
      this.Controls.Add(this.checkShadow);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textCharSet);
      this.Controls.Add(this.numShadowY);
      this.Controls.Add(this.numShadowX);
      this.Controls.Add(this.numPadding);
      this.Controls.Add(this.numSize);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.buttonMakeFont);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listFonts);
      this.Controls.Add(this.picPreview);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Font generator";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPadding)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numShadowX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numShadowY)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPreview;
    private System.Windows.Forms.ComboBox listFonts;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonMakeFont;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numSize;
    private System.Windows.Forms.TextBox textCharSet;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkShadow;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numPadding;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textMagick;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox listWidth;
    private System.Windows.Forms.ComboBox listHeight;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label labelCellSize;
    private System.Windows.Forms.NumericUpDown numShadowX;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.NumericUpDown numShadowY;
    private System.Windows.Forms.CheckBox checkBold;
    private System.Windows.Forms.Button buttonExtended;
  }
}

