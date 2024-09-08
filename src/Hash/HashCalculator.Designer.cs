// Copyright © 2021-2024 Hibi_10000
// 
// This file is part of HashCalculator program.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using Hash.Core;

namespace Hash
{
    partial class HashCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashCalculator));
            CopyRight = new Label();
            CreatedBy = new Label();
            DL = new Label();
            DLLink1 = new LinkLabel();
            DropPanel = new Panel();
            DropText = new Label();
            SelectFileButton = new Button();
            HashFileURL = new TextBox();
            SelectFileDialog = new OpenFileDialog();
            hashAndVer = new Label();
            Tab = new TabControl();
            TabHash = new TabPage();
            checkUpper = new CheckBox();
            AllReset = new Button();
            checkHyphen = new CheckBox();
            compare2copy = new Button();
            compare1copy = new Button();
            HashCopy = new Button();
            HashOutputBox = new TextBox();
            HashSelector = new ComboBox();
            TabHashCompare = new TabPage();
            compareReset = new Button();
            compareResult = new Label();
            compareExecButton = new Button();
            paste1cb = new Button();
            paste2cb = new Button();
            compare2t = new Label();
            compare1t = new Label();
            compare2hashType = new ComboBox();
            compare1hashType = new ComboBox();
            compare2hash = new TextBox();
            compare1hash = new TextBox();
            TabReadme = new TabPage();
            Readme = new RichTextBox();
            TabSettings = new TabPage();
            pictureBox1 = new PictureBox();
            HashForContextEnable = new CheckBox();
            settingsLabel = new Label();
            HashVer = new Label();
            menuFile = new ToolStripMenuItem();
            menuFileSettings = new ToolStripMenuItem();
            menuFIleExit = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuHelpReadme = new ToolStripMenuItem();
            menuHelpVer = new ToolStripMenuItem();
            menu = new MenuStrip();
            richTextBox3 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            DropPanel.SuspendLayout();
            Tab.SuspendLayout();
            TabHash.SuspendLayout();
            TabHashCompare.SuspendLayout();
            TabReadme.SuspendLayout();
            TabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // CopyRight
            // 
            CopyRight.AutoSize = true;
            CopyRight.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CopyRight.Location = new Point(620, 611);
            CopyRight.Name = "CopyRight";
            CopyRight.Size = new Size(357, 25);
            CopyRight.TabIndex = 3;
            CopyRight.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSize = true;
            CreatedBy.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CreatedBy.Location = new Point(726, 42);
            CreatedBy.Name = "CreatedBy";
            CreatedBy.Size = new Size(195, 25);
            CreatedBy.TabIndex = 5;
            CreatedBy.Text = "CreatedBy : Hibi_10000";
            // 
            // DL
            // 
            DL.AutoSize = true;
            DL.Font = new Font("Yu Gothic UI", 9F);
            DL.Location = new Point(815, 71);
            DL.Name = "DL";
            DL.Size = new Size(42, 25);
            DL.TabIndex = 6;
            DL.Text = "DL :";
            // 
            // DLLink1
            // 
            DLLink1.AutoSize = true;
            DLLink1.Font = new Font("Yu Gothic UI", 9F);
            DLLink1.Location = new Point(853, 71);
            DLLink1.Name = "DLLink1";
            DLLink1.Size = new Size(68, 25);
            DLLink1.TabIndex = 7;
            DLLink1.TabStop = true;
            DLLink1.Text = "GitHub";
            DLLink1.LinkClicked += DLLink1_LinkClicked;
            // 
            // DropPanel
            // 
            DropPanel.AllowDrop = true;
            DropPanel.BackColor = SystemColors.Window;
            DropPanel.BorderStyle = BorderStyle.FixedSingle;
            DropPanel.Controls.Add(DropText);
            DropPanel.Controls.Add(SelectFileButton);
            DropPanel.ImeMode = ImeMode.NoControl;
            DropPanel.Location = new Point(6, 76);
            DropPanel.Margin = new Padding(3, 4, 3, 4);
            DropPanel.Name = "DropPanel";
            DropPanel.Size = new Size(892, 194);
            DropPanel.TabIndex = 8;
            DropPanel.DragDrop += DropPanel_DragDrop;
            DropPanel.DragEnter += DropPanel_DragEnter;
            // 
            // DropText
            // 
            DropText.AutoSize = true;
            DropText.Font = new Font("Yu Gothic UI", 20F);
            DropText.Location = new Point(112, 64);
            DropText.Name = "DropText";
            DropText.Size = new Size(413, 54);
            DropText.TabIndex = 9;
            DropText.Text = "① ここにファイルをドロップ";
            // 
            // SelectFileButton
            // 
            SelectFileButton.Font = new Font("游ゴシック Medium", 15F);
            SelectFileButton.Location = new Point(544, 64);
            SelectFileButton.Margin = new Padding(3, 4, 3, 4);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(258, 54);
            SelectFileButton.TabIndex = 10;
            SelectFileButton.Text = "① Select File";
            SelectFileButton.UseVisualStyleBackColor = true;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // HashFileURL
            // 
            HashFileURL.BorderStyle = BorderStyle.FixedSingle;
            HashFileURL.Cursor = Cursors.No;
            HashFileURL.Font = new Font("Yu Gothic UI", 10F);
            HashFileURL.Location = new Point(6, 8);
            HashFileURL.Margin = new Padding(3, 4, 3, 4);
            HashFileURL.Multiline = true;
            HashFileURL.Name = "HashFileURL";
            HashFileURL.ReadOnly = true;
            HashFileURL.Size = new Size(892, 60);
            HashFileURL.TabIndex = 9;
            HashFileURL.Text = "ファイルのパス";
            // 
            // SelectFileDialog
            // 
            SelectFileDialog.InitialDirectory = "@C:\\";
            SelectFileDialog.SupportMultiDottedExtensions = true;
            SelectFileDialog.Title = "ファイルを選択";
            // 
            // hashAndVer
            // 
            hashAndVer.AutoSize = true;
            hashAndVer.BackColor = SystemColors.Window;
            hashAndVer.BorderStyle = BorderStyle.FixedSingle;
            hashAndVer.Font = new Font("Yu Gothic UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            hashAndVer.ForeColor = Color.Lime;
            hashAndVer.ImeMode = ImeMode.NoControl;
            hashAndVer.Location = new Point(5, 37);
            hashAndVer.Name = "hashAndVer";
            hashAndVer.Size = new Size(374, 69);
            hashAndVer.TabIndex = 12;
            hashAndVer.Text = "HashCalculator";
            // 
            // Tab
            // 
            Tab.Controls.Add(TabHash);
            Tab.Controls.Add(TabHashCompare);
            Tab.Controls.Add(TabReadme);
            Tab.Controls.Add(TabSettings);
            Tab.Font = new Font("Yu Gothic UI", 9F);
            Tab.Location = new Point(5, 110);
            Tab.Margin = new Padding(3, 4, 3, 4);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new Size(916, 501);
            Tab.TabIndex = 13;
            // 
            // TabHash
            // 
            TabHash.BackColor = SystemColors.Window;
            TabHash.BorderStyle = BorderStyle.Fixed3D;
            TabHash.Controls.Add(checkUpper);
            TabHash.Controls.Add(AllReset);
            TabHash.Controls.Add(checkHyphen);
            TabHash.Controls.Add(compare2copy);
            TabHash.Controls.Add(compare1copy);
            TabHash.Controls.Add(HashCopy);
            TabHash.Controls.Add(HashOutputBox);
            TabHash.Controls.Add(HashSelector);
            TabHash.Controls.Add(DropPanel);
            TabHash.Controls.Add(HashFileURL);
            TabHash.Location = new Point(4, 34);
            TabHash.Margin = new Padding(3, 4, 3, 4);
            TabHash.Name = "TabHash";
            TabHash.Padding = new Padding(3, 4, 3, 4);
            TabHash.Size = new Size(908, 463);
            TabHash.TabIndex = 0;
            TabHash.Text = "Hash計算機";
            // 
            // UpperCheck
            // 
            checkUpper.AutoSize = true;
            checkUpper.Location = new Point(236, 280);
            checkUpper.Margin = new Padding(5, 6, 5, 6);
            checkUpper.Name = "checkUpper";
            checkUpper.Size = new Size(92, 29);
            checkUpper.TabIndex = 19;
            checkUpper.Text = "大文字";
            checkUpper.UseVisualStyleBackColor = true;
            checkUpper.CheckedChanged += HashSelector_Set;
            // 
            // AllReset
            // 
            AllReset.Font = new Font("游ゴシック Medium", 9F, FontStyle.Bold);
            AllReset.ForeColor = Color.FromArgb(192, 0, 0);
            AllReset.Location = new Point(608, 278);
            AllReset.Margin = new Padding(3, 4, 3, 4);
            AllReset.Name = "AllReset";
            AllReset.Size = new Size(290, 34);
            AllReset.TabIndex = 15;
            AllReset.Text = "値をリセット";
            AllReset.UseVisualStyleBackColor = true;
            AllReset.Click += AllReset_Click;
            // 
            // checkHyphen
            // 
            checkHyphen.AutoSize = true;
            checkHyphen.Location = new Point(338, 281);
            checkHyphen.Margin = new Padding(5, 6, 5, 6);
            checkHyphen.Name = "checkHyphen";
            checkHyphen.Size = new Size(90, 29);
            checkHyphen.TabIndex = 18;
            checkHyphen.Text = "ハイフン";
            checkHyphen.UseVisualStyleBackColor = true;
            checkHyphen.CheckedChanged += HashSelector_Set;
            // 
            // compare2copy
            // 
            compare2copy.Location = new Point(608, 418);
            compare2copy.Margin = new Padding(5, 4, 5, 4);
            compare2copy.Name = "compare2copy";
            compare2copy.Size = new Size(290, 34);
            compare2copy.TabIndex = 17;
            compare2copy.Text = "比較②にコピー";
            compare2copy.UseVisualStyleBackColor = true;
            compare2copy.Click += compare2copy_Click;
            // 
            // compare1copy
            // 
            compare1copy.Location = new Point(305, 418);
            compare1copy.Margin = new Padding(5, 4, 5, 4);
            compare1copy.Name = "compare1copy";
            compare1copy.Size = new Size(293, 34);
            compare1copy.TabIndex = 16;
            compare1copy.Text = "比較①にコピー";
            compare1copy.UseVisualStyleBackColor = true;
            compare1copy.Click += compare1copy_Click;
            // 
            // HashCopy
            // 
            HashCopy.Font = new Font("游ゴシック Medium", 9F);
            HashCopy.Location = new Point(6, 418);
            HashCopy.Margin = new Padding(3, 4, 3, 4);
            HashCopy.Name = "HashCopy";
            HashCopy.Size = new Size(291, 34);
            HashCopy.TabIndex = 14;
            HashCopy.Text = "Hash値をコピー";
            HashCopy.UseVisualStyleBackColor = true;
            HashCopy.Click += HashCopy_Click;
            // 
            // HashOutputBox
            // 
            HashOutputBox.BorderStyle = BorderStyle.FixedSingle;
            HashOutputBox.Font = new Font("Yu Gothic UI", 10F);
            HashOutputBox.Location = new Point(6, 319);
            HashOutputBox.Margin = new Padding(3, 4, 3, 4);
            HashOutputBox.Multiline = true;
            HashOutputBox.Name = "HashOutputBox";
            HashOutputBox.ReadOnly = true;
            HashOutputBox.Size = new Size(892, 91);
            HashOutputBox.TabIndex = 13;
            HashOutputBox.Text = "ここにHash値が表示されます";
            // 
            // HashSelector
            // 
            HashSelector.Font = new Font("游ゴシック", 10F);
            HashSelector.FormattingEnabled = true;
            HashSelector.Items.AddRange([ "②Hashを選択", ..HashCalculate.GetHashTypeNames() ]);
            HashSelector.Location = new Point(6, 278);
            HashSelector.Margin = new Padding(3, 4, 3, 4);
            HashSelector.Name = "HashSelector";
            HashSelector.Size = new Size(222, 34);
            HashSelector.TabIndex = 12;
            HashSelector.Text = "②Hashを選択";
            HashSelector.SelectedIndexChanged += HashSelector_Set;
            HashSelector.TextChanged += HashSelector_Set;
            // 
            // TabHashCompare
            // 
            TabHashCompare.BorderStyle = BorderStyle.Fixed3D;
            TabHashCompare.Controls.Add(compareReset);
            TabHashCompare.Controls.Add(compareResult);
            TabHashCompare.Controls.Add(compareExecButton);
            TabHashCompare.Controls.Add(paste1cb);
            TabHashCompare.Controls.Add(paste2cb);
            TabHashCompare.Controls.Add(compare2t);
            TabHashCompare.Controls.Add(compare1t);
            TabHashCompare.Controls.Add(compare2hashType);
            TabHashCompare.Controls.Add(compare1hashType);
            TabHashCompare.Controls.Add(compare2hash);
            TabHashCompare.Controls.Add(compare1hash);
            TabHashCompare.Font = new Font("游ゴシック Medium", 9F);
            TabHashCompare.Location = new Point(4, 34);
            TabHashCompare.Margin = new Padding(5, 4, 5, 4);
            TabHashCompare.Name = "TabHashCompare";
            TabHashCompare.Size = new Size(908, 463);
            TabHashCompare.TabIndex = 3;
            TabHashCompare.Text = "Hash比較";
            TabHashCompare.UseVisualStyleBackColor = true;
            // 
            // compareReset
            // 
            compareReset.Font = new Font("游ゴシック Medium", 9F);
            compareReset.ForeColor = Color.Red;
            compareReset.Location = new Point(781, 4);
            compareReset.Margin = new Padding(5, 4, 5, 4);
            compareReset.Name = "compareReset";
            compareReset.Size = new Size(118, 34);
            compareReset.TabIndex = 10;
            compareReset.Text = "リセット";
            compareReset.UseVisualStyleBackColor = true;
            compareReset.Click += compareReset_Click;
            // 
            // compareResult
            // 
            compareResult.AutoSize = true;
            compareResult.Font = new Font("Yu Gothic UI", 20F);
            compareResult.Location = new Point(186, 336);
            compareResult.Margin = new Padding(5, 0, 5, 0);
            compareResult.Name = "compareResult";
            compareResult.Size = new Size(214, 54);
            compareResult.TabIndex = 9;
            compareResult.Text = "比較 : 結果";
            // 
            // compareExecButton
            // 
            compareExecButton.Font = new Font("游ゴシック Medium", 30F);
            compareExecButton.Location = new Point(616, 264);
            compareExecButton.Margin = new Padding(5, 4, 5, 4);
            compareExecButton.Name = "compareExecButton";
            compareExecButton.Size = new Size(283, 188);
            compareExecButton.TabIndex = 8;
            compareExecButton.Text = "比較";
            compareExecButton.UseVisualStyleBackColor = true;
            compareExecButton.Click += compareExecButton_Click;
            // 
            // paste1cb
            // 
            paste1cb.ImeMode = ImeMode.NoControl;
            paste1cb.Location = new Point(186, 73);
            paste1cb.Margin = new Padding(5, 4, 5, 4);
            paste1cb.Name = "paste1cb";
            paste1cb.Size = new Size(345, 31);
            paste1cb.TabIndex = 7;
            paste1cb.Text = "クリップボードから①へ貼り付け";
            paste1cb.UseVisualStyleBackColor = true;
            paste1cb.Click += paste1cb_Click;
            // 
            // paste2cb
            // 
            paste2cb.Location = new Point(186, 181);
            paste2cb.Margin = new Padding(5, 4, 5, 4);
            paste2cb.Name = "paste2cb";
            paste2cb.Size = new Size(345, 31);
            paste2cb.TabIndex = 6;
            paste2cb.Text = "クリップボードから②へ貼り付け";
            paste2cb.UseVisualStyleBackColor = true;
            paste2cb.Click += paste2cb_Click;
            // 
            // compare2t
            // 
            compare2t.AutoSize = true;
            compare2t.BorderStyle = BorderStyle.FixedSingle;
            compare2t.Location = new Point(5, 152);
            compare2t.Margin = new Padding(5, 0, 5, 0);
            compare2t.Name = "compare2t";
            compare2t.Size = new Size(66, 25);
            compare2t.TabIndex = 5;
            compare2t.Text = "比較②";
            // 
            // compare1t
            // 
            compare1t.AutoSize = true;
            compare1t.BackColor = SystemColors.Window;
            compare1t.BorderStyle = BorderStyle.FixedSingle;
            compare1t.ImeMode = ImeMode.NoControl;
            compare1t.Location = new Point(5, 44);
            compare1t.Margin = new Padding(5, 0, 5, 0);
            compare1t.Name = "compare1t";
            compare1t.Size = new Size(66, 25);
            compare1t.TabIndex = 4;
            compare1t.Text = "比較①";
            // 
            // compare2hashType
            // 
            compare2hashType.Font = new Font("游ゴシック Medium", 9F);
            compare2hashType.FormattingEnabled = true;
            compare2hashType.Items.AddRange([ "比較②", ..HashCalculate.GetHashTypeNames() ]);
            compare2hashType.Location = new Point(5, 181);
            compare2hashType.Margin = new Padding(5, 4, 5, 4);
            compare2hashType.Name = "compare2hashType";
            compare2hashType.Size = new Size(171, 31);
            compare2hashType.TabIndex = 3;
            compare2hashType.Text = "比較②";
            // 
            // compare1hashType
            // 
            compare1hashType.Font = new Font("游ゴシック", 9F);
            compare1hashType.FormattingEnabled = true;
            compare1hashType.Items.AddRange([ "比較①", ..HashCalculate.GetHashTypeNames() ]);
            compare1hashType.Location = new Point(5, 73);
            compare1hashType.Margin = new Padding(5, 4, 5, 4);
            compare1hashType.Name = "compare1hashType";
            compare1hashType.Size = new Size(171, 31);
            compare1hashType.TabIndex = 2;
            compare1hashType.Text = "比較①";
            // 
            // compare2hash
            // 
            compare2hash.Location = new Point(5, 220);
            compare2hash.Margin = new Padding(5, 4, 5, 4);
            compare2hash.Name = "compare2hash";
            compare2hash.Size = new Size(894, 36);
            compare2hash.TabIndex = 1;
            // 
            // compare1hash
            // 
            compare1hash.Location = new Point(5, 112);
            compare1hash.Margin = new Padding(5, 4, 5, 4);
            compare1hash.Name = "compare1hash";
            compare1hash.Size = new Size(894, 36);
            compare1hash.TabIndex = 0;
            // 
            // TabReadme
            // 
            TabReadme.BorderStyle = BorderStyle.Fixed3D;
            TabReadme.Controls.Add(Readme);
            TabReadme.Location = new Point(4, 34);
            TabReadme.Margin = new Padding(5, 4, 5, 4);
            TabReadme.Name = "TabReadme";
            TabReadme.Size = new Size(908, 463);
            TabReadme.TabIndex = 4;
            TabReadme.Text = "Readme";
            TabReadme.UseVisualStyleBackColor = true;
            // 
            // Readme
            // 
            Readme.BackColor = SystemColors.Window;
            Readme.BorderStyle = BorderStyle.None;
            Readme.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Readme.Location = new Point(2, 2);
            Readme.Margin = new Padding(5, 4, 5, 4);
            Readme.Name = "Readme";
            Readme.ReadOnly = true;
            Readme.Size = new Size(903, 455);
            Readme.TabIndex = 0;
            Readme.Text = Properties.Resources.Readme;
            // 
            // TabSettings
            // 
            TabSettings.BorderStyle = BorderStyle.Fixed3D;
            TabSettings.Controls.Add(pictureBox1);
            TabSettings.Controls.Add(HashForContextEnable);
            TabSettings.Controls.Add(settingsLabel);
            TabSettings.Location = new Point(4, 34);
            TabSettings.Margin = new Padding(5, 4, 5, 4);
            TabSettings.Name = "TabSettings";
            TabSettings.Size = new Size(908, 463);
            TabSettings.TabIndex = 5;
            TabSettings.Text = "設定";
            TabSettings.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = new Bitmap(Properties.Resources.UAC, 24, 24);
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(101, 86);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 33);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // HashForContextEnable
            // 
            HashForContextEnable.AutoSize = true;
            HashForContextEnable.Checked = true;
            HashForContextEnable.CheckState = CheckState.Checked;
            HashForContextEnable.ImageAlign = ContentAlignment.MiddleLeft;
            HashForContextEnable.Location = new Point(78, 84);
            HashForContextEnable.Margin = new Padding(5, 6, 5, 6);
            HashForContextEnable.Name = "HashForContextEnable";
            HashForContextEnable.Size = new Size(290, 29);
            HashForContextEnable.TabIndex = 18;
            HashForContextEnable.Text = "    Hash for Context を有効にする";
            HashForContextEnable.UseVisualStyleBackColor = true;
            HashForContextEnable.CheckedChanged += HashForContextEnable_CheckedChanged;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.BorderStyle = BorderStyle.FixedSingle;
            settingsLabel.Font = new Font("Yu Gothic UI", 20F);
            settingsLabel.Location = new Point(0, 0);
            settingsLabel.Margin = new Padding(5, 0, 5, 0);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(105, 56);
            settingsLabel.TabIndex = 17;
            settingsLabel.Text = "設定";
            // 
            // HashVer
            // 
            HashVer.AutoSize = true;
            HashVer.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            HashVer.Location = new Point(5, 611);
            HashVer.Name = "HashVer";
            HashVer.Size = new Size(130, 25);
            HashVer.TabIndex = 14;
            HashVer.Text = "HashCalculator";
            // 
            // menuFile
            // 
            menuFile.AutoSize = false;
            menuFile.BackColor = SystemColors.ControlLight;
            menuFile.BackgroundImageLayout = ImageLayout.None;
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileSettings, menuFIleExit });
            menuFile.Name = "menuFile";
            menuFile.ShortcutKeyDisplayString = "";
            menuFile.ShowShortcutKeys = false;
            menuFile.Size = new Size(95, 24);
            menuFile.Text = "ファイル(&F)";
            // 
            // menuFileSettings
            // 
            menuFileSettings.BackColor = SystemColors.Window;
            menuFileSettings.Name = "menuFileSettings";
            menuFileSettings.ShortcutKeyDisplayString = "S";
            menuFileSettings.ShowShortcutKeys = false;
            menuFileSettings.Text = "設定(&S)";
            menuFileSettings.Click += menuFileSettings_Click;
            // 
            // menuFIleExit
            // 
            menuFIleExit.AutoSize = false;
            menuFIleExit.BackColor = SystemColors.Window;
            menuFIleExit.Name = "menuFIleExit";
            menuFIleExit.ShortcutKeyDisplayString = "X";
            menuFIleExit.ShowShortcutKeys = false;
            menuFIleExit.Text = "終了(&X)";
            menuFIleExit.Click += menuFIleExit_Click;
            // 
            // menuHelp
            // 
            menuHelp.BackColor = SystemColors.ControlLight;
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuHelpReadme, menuHelpVer });
            menuHelp.ImageScaling = ToolStripItemImageScaling.None;
            menuHelp.Name = "menuHelp";
            menuHelp.ShortcutKeyDisplayString = "H";
            menuHelp.Size = new Size(95, 24);
            menuHelp.Text = "ヘルプ(&H)";
            // 
            // menuHelpReadme
            // 
            menuHelpReadme.BackColor = SystemColors.Window;
            menuHelpReadme.Name = "menuHelpReadme";
            menuHelpReadme.ShortcutKeyDisplayString = "R";
            menuHelpReadme.ShowShortcutKeys = false;
            menuHelpReadme.Text = "Readme(&R)";
            menuHelpReadme.Click += menuHelpReadme_Click;
            // 
            // menuHelpVer
            // 
            menuHelpVer.BackColor = SystemColors.Window;
            menuHelpVer.Name = "menuHelpVer";
            menuHelpVer.ShortcutKeyDisplayString = "V";
            menuHelpVer.ShowShortcutKeys = false;
            menuHelpVer.Text = "バーション情報(&V)";
            menuHelpVer.Click += menuHelpVer_Click;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ControlLight;
            menu.Dock = DockStyle.None;
            menu.GripMargin = new Padding(2);
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { menuFile, menuHelp });
            menu.Location = new Point(-8, -4);
            menu.Name = "menu";
            menu.Padding = new Padding(8, 4, 0, 0);
            menu.Size = new Size(200, 37);
            menu.TabIndex = 15;
            menu.Text = "menu";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.ControlLight;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(0, 0);
            richTextBox3.Margin = new Padding(0);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(1010, 30);
            richTextBox3.TabIndex = 16;
            richTextBox3.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(0, 42);
            richTextBox1.Margin = new Padding(5, 6, 5, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(513, 40);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // HashCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(924, 639);
            Controls.Add(hashAndVer);
            Controls.Add(richTextBox1);
            Controls.Add(HashVer);
            Controls.Add(DL);
            Controls.Add(DLLink1);
            Controls.Add(CreatedBy);
            Controls.Add(CopyRight);
            Controls.Add(Tab);
            Controls.Add(menu);
            Controls.Add(richTextBox3);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.Icon;
            MainMenuStrip = menu;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "HashCalculator";
            StartPosition = FormStartPosition.Manual;
            Text = "HashCalculator";
            Load += Hash_Load;
            DropPanel.ResumeLayout(false);
            DropPanel.PerformLayout();
            Tab.ResumeLayout(false);
            TabHash.ResumeLayout(false);
            TabHash.PerformLayout();
            TabHashCompare.ResumeLayout(false);
            TabHashCompare.PerformLayout();
            TabReadme.ResumeLayout(false);
            TabSettings.ResumeLayout(false);
            TabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CopyRight;
        private Label CreatedBy;
        private Label DL;
        private LinkLabel DLLink1;
        private Panel DropPanel;
        private Label DropText;
        private TextBox HashFileURL;
        private Button SelectFileButton;
        private OpenFileDialog SelectFileDialog;
        private Label hashAndVer;
        private TabControl Tab;
        private TabPage TabHash;
        private Label HashVer;
        private ComboBox HashSelector;
        private Button AllReset;
        private Button HashCopy;
        private TextBox HashOutputBox;
        private TabPage TabHashCompare;
        private Button compare2copy;
        private Button compare1copy;
        private Label compare2t;
        private Label compare1t;
        private ComboBox compare2hashType;
        private ComboBox compare1hashType;
        private TextBox compare2hash;
        private TextBox compare1hash;
        private Label compareResult;
        private Button compareExecButton;
        private Button paste1cb;
        private Button paste2cb;
        private Button compareReset;
        private TabPage TabReadme;
        private TabPage TabSettings;
        private RichTextBox Readme;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuHelp;
        private MenuStrip menu;
        private RichTextBox richTextBox3;
        private ToolStripMenuItem menuFIleExit;
        private ToolStripMenuItem menuHelpVer;
        private ToolStripMenuItem menuHelpReadme;
        private ToolStripMenuItem menuFileSettings;
        private Label settingsLabel;
        private CheckBox HashForContextEnable;
        private PictureBox pictureBox1;
        private CheckBox checkUpper;
        private CheckBox checkHyphen;
        private RichTextBox richTextBox1;
    }
}
