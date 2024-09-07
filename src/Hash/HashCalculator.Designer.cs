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
            hashandver = new Label();
            Tab = new TabControl();
            TabHash = new TabPage();
            UpperCheck = new CheckBox();
            AllReset = new Button();
            HihunCheck = new CheckBox();
            hikaku2copy = new Button();
            hikaku1copy = new Button();
            HashCopy = new Button();
            HashOutputBox = new TextBox();
            HashSelecter = new ComboBox();
            TabHashhikaku = new TabPage();
            hikakureset = new Button();
            hikakukekka = new Label();
            hikakub = new Button();
            paste1cb = new Button();
            paste2cb = new Button();
            hikaku2t = new Label();
            hikaku1t = new Label();
            hikaku2hashtype = new ComboBox();
            hikaku1hashtype = new ComboBox();
            hikaku2hash = new TextBox();
            hikaku1hash = new TextBox();
            TabReadme = new TabPage();
            Readme = new RichTextBox();
            TabSettings = new TabPage();
            pictureBox1 = new PictureBox();
            HashForContextEnable = new CheckBox();
            settingslabel = new Label();
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
            TabHashhikaku.SuspendLayout();
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
            // hashandver
            // 
            hashandver.AutoSize = true;
            hashandver.BackColor = SystemColors.Window;
            hashandver.BorderStyle = BorderStyle.FixedSingle;
            hashandver.Font = new Font("Yu Gothic UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            hashandver.ForeColor = Color.Lime;
            hashandver.ImeMode = ImeMode.NoControl;
            hashandver.Location = new Point(5, 37);
            hashandver.Name = "hashandver";
            hashandver.Size = new Size(374, 69);
            hashandver.TabIndex = 12;
            hashandver.Text = "HashCalculator";
            // 
            // Tab
            // 
            Tab.Controls.Add(TabHash);
            Tab.Controls.Add(TabHashhikaku);
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
            TabHash.Controls.Add(UpperCheck);
            TabHash.Controls.Add(AllReset);
            TabHash.Controls.Add(HihunCheck);
            TabHash.Controls.Add(hikaku2copy);
            TabHash.Controls.Add(hikaku1copy);
            TabHash.Controls.Add(HashCopy);
            TabHash.Controls.Add(HashOutputBox);
            TabHash.Controls.Add(HashSelecter);
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
            UpperCheck.AutoSize = true;
            UpperCheck.Location = new Point(236, 280);
            UpperCheck.Margin = new Padding(5, 6, 5, 6);
            UpperCheck.Name = "UpperCheck";
            UpperCheck.Size = new Size(92, 29);
            UpperCheck.TabIndex = 19;
            UpperCheck.Text = "大文字";
            UpperCheck.UseVisualStyleBackColor = true;
            UpperCheck.CheckedChanged += HashSelecter_Set;
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
            // HihunCheck
            // 
            HihunCheck.AutoSize = true;
            HihunCheck.Location = new Point(338, 281);
            HihunCheck.Margin = new Padding(5, 6, 5, 6);
            HihunCheck.Name = "HihunCheck";
            HihunCheck.Size = new Size(90, 29);
            HihunCheck.TabIndex = 18;
            HihunCheck.Text = "ハイフン";
            HihunCheck.UseVisualStyleBackColor = true;
            HihunCheck.CheckedChanged += HashSelecter_Set;
            // 
            // hikaku2copy
            // 
            hikaku2copy.Location = new Point(608, 418);
            hikaku2copy.Margin = new Padding(5, 4, 5, 4);
            hikaku2copy.Name = "hikaku2copy";
            hikaku2copy.Size = new Size(290, 34);
            hikaku2copy.TabIndex = 17;
            hikaku2copy.Text = "比較②にコピー";
            hikaku2copy.UseVisualStyleBackColor = true;
            hikaku2copy.Click += hikaku2copy_Click;
            // 
            // hikaku1copy
            // 
            hikaku1copy.Location = new Point(305, 418);
            hikaku1copy.Margin = new Padding(5, 4, 5, 4);
            hikaku1copy.Name = "hikaku1copy";
            hikaku1copy.Size = new Size(293, 34);
            hikaku1copy.TabIndex = 16;
            hikaku1copy.Text = "比較①にコピー";
            hikaku1copy.UseVisualStyleBackColor = true;
            hikaku1copy.Click += hikaku1copy_Click;
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
            // HashSelecter
            // 
            HashSelecter.Font = new Font("游ゴシック", 10F);
            HashSelecter.FormattingEnabled = true;
            HashSelecter.Items.AddRange([ "②Hashを選択", ..HashCalculate.GetHashTypeNames() ]);
            HashSelecter.Location = new Point(6, 278);
            HashSelecter.Margin = new Padding(3, 4, 3, 4);
            HashSelecter.Name = "HashSelecter";
            HashSelecter.Size = new Size(222, 34);
            HashSelecter.TabIndex = 12;
            HashSelecter.Text = "②Hashを選択";
            HashSelecter.SelectedIndexChanged += HashSelecter_Set;
            HashSelecter.TextChanged += HashSelecter_Set;
            // 
            // TabHashhikaku
            // 
            TabHashhikaku.BorderStyle = BorderStyle.Fixed3D;
            TabHashhikaku.Controls.Add(hikakureset);
            TabHashhikaku.Controls.Add(hikakukekka);
            TabHashhikaku.Controls.Add(hikakub);
            TabHashhikaku.Controls.Add(paste1cb);
            TabHashhikaku.Controls.Add(paste2cb);
            TabHashhikaku.Controls.Add(hikaku2t);
            TabHashhikaku.Controls.Add(hikaku1t);
            TabHashhikaku.Controls.Add(hikaku2hashtype);
            TabHashhikaku.Controls.Add(hikaku1hashtype);
            TabHashhikaku.Controls.Add(hikaku2hash);
            TabHashhikaku.Controls.Add(hikaku1hash);
            TabHashhikaku.Font = new Font("游ゴシック Medium", 9F);
            TabHashhikaku.Location = new Point(4, 34);
            TabHashhikaku.Margin = new Padding(5, 4, 5, 4);
            TabHashhikaku.Name = "TabHashhikaku";
            TabHashhikaku.Size = new Size(908, 463);
            TabHashhikaku.TabIndex = 3;
            TabHashhikaku.Text = "Hash比較";
            TabHashhikaku.UseVisualStyleBackColor = true;
            // 
            // hikakureset
            // 
            hikakureset.Font = new Font("游ゴシック Medium", 9F);
            hikakureset.ForeColor = Color.Red;
            hikakureset.Location = new Point(781, 4);
            hikakureset.Margin = new Padding(5, 4, 5, 4);
            hikakureset.Name = "hikakureset";
            hikakureset.Size = new Size(118, 34);
            hikakureset.TabIndex = 10;
            hikakureset.Text = "リセット";
            hikakureset.UseVisualStyleBackColor = true;
            hikakureset.Click += hikakureset_Click;
            // 
            // hikakukekka
            // 
            hikakukekka.AutoSize = true;
            hikakukekka.Font = new Font("Yu Gothic UI", 20F);
            hikakukekka.Location = new Point(186, 336);
            hikakukekka.Margin = new Padding(5, 0, 5, 0);
            hikakukekka.Name = "hikakukekka";
            hikakukekka.Size = new Size(214, 54);
            hikakukekka.TabIndex = 9;
            hikakukekka.Text = "比較 : 結果";
            // 
            // hikakub
            // 
            hikakub.Font = new Font("游ゴシック Medium", 30F);
            hikakub.Location = new Point(616, 264);
            hikakub.Margin = new Padding(5, 4, 5, 4);
            hikakub.Name = "hikakub";
            hikakub.Size = new Size(283, 188);
            hikakub.TabIndex = 8;
            hikakub.Text = "比較";
            hikakub.UseVisualStyleBackColor = true;
            hikakub.Click += hikakub_Click;
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
            // hikaku2t
            // 
            hikaku2t.AutoSize = true;
            hikaku2t.BorderStyle = BorderStyle.FixedSingle;
            hikaku2t.Location = new Point(5, 152);
            hikaku2t.Margin = new Padding(5, 0, 5, 0);
            hikaku2t.Name = "hikaku2t";
            hikaku2t.Size = new Size(66, 25);
            hikaku2t.TabIndex = 5;
            hikaku2t.Text = "比較②";
            // 
            // hikaku1t
            // 
            hikaku1t.AutoSize = true;
            hikaku1t.BackColor = SystemColors.Window;
            hikaku1t.BorderStyle = BorderStyle.FixedSingle;
            hikaku1t.ImeMode = ImeMode.NoControl;
            hikaku1t.Location = new Point(5, 44);
            hikaku1t.Margin = new Padding(5, 0, 5, 0);
            hikaku1t.Name = "hikaku1t";
            hikaku1t.Size = new Size(66, 25);
            hikaku1t.TabIndex = 4;
            hikaku1t.Text = "比較①";
            // 
            // hikaku2hashtype
            // 
            hikaku2hashtype.Font = new Font("游ゴシック Medium", 9F);
            hikaku2hashtype.FormattingEnabled = true;
            hikaku2hashtype.Items.AddRange([ "比較②", ..HashCalculate.GetHashTypeNames() ]);
            hikaku2hashtype.Location = new Point(5, 181);
            hikaku2hashtype.Margin = new Padding(5, 4, 5, 4);
            hikaku2hashtype.Name = "hikaku2hashtype";
            hikaku2hashtype.Size = new Size(171, 31);
            hikaku2hashtype.TabIndex = 3;
            hikaku2hashtype.Text = "比較②";
            // 
            // hikaku1hashtype
            // 
            hikaku1hashtype.Font = new Font("游ゴシック", 9F);
            hikaku1hashtype.FormattingEnabled = true;
            hikaku1hashtype.Items.AddRange([ "比較①", ..HashCalculate.GetHashTypeNames() ]);
            hikaku1hashtype.Location = new Point(5, 73);
            hikaku1hashtype.Margin = new Padding(5, 4, 5, 4);
            hikaku1hashtype.Name = "hikaku1hashtype";
            hikaku1hashtype.Size = new Size(171, 31);
            hikaku1hashtype.TabIndex = 2;
            hikaku1hashtype.Text = "比較①";
            // 
            // hikaku2hash
            // 
            hikaku2hash.Location = new Point(5, 220);
            hikaku2hash.Margin = new Padding(5, 4, 5, 4);
            hikaku2hash.Name = "hikaku2hash";
            hikaku2hash.Size = new Size(894, 36);
            hikaku2hash.TabIndex = 1;
            // 
            // hikaku1hash
            // 
            hikaku1hash.Location = new Point(5, 112);
            hikaku1hash.Margin = new Padding(5, 4, 5, 4);
            hikaku1hash.Name = "hikaku1hash";
            hikaku1hash.Size = new Size(894, 36);
            hikaku1hash.TabIndex = 0;
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
            TabSettings.Controls.Add(settingslabel);
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
            // settingslabel
            // 
            settingslabel.AutoSize = true;
            settingslabel.BorderStyle = BorderStyle.FixedSingle;
            settingslabel.Font = new Font("Yu Gothic UI", 20F);
            settingslabel.Location = new Point(0, 0);
            settingslabel.Margin = new Padding(5, 0, 5, 0);
            settingslabel.Name = "settingslabel";
            settingslabel.Size = new Size(105, 56);
            settingslabel.TabIndex = 17;
            settingslabel.Text = "設定";
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
            Controls.Add(hashandver);
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
            TabHashhikaku.ResumeLayout(false);
            TabHashhikaku.PerformLayout();
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
        private Label hashandver;
        private TabControl Tab;
        private TabPage TabHash;
        private Label HashVer;
        private ComboBox HashSelecter;
        private Button AllReset;
        private Button HashCopy;
        private TextBox HashOutputBox;
        private TabPage TabHashhikaku;
        private Button hikaku2copy;
        private Button hikaku1copy;
        private Label hikaku2t;
        private Label hikaku1t;
        private ComboBox hikaku2hashtype;
        private ComboBox hikaku1hashtype;
        private TextBox hikaku2hash;
        private TextBox hikaku1hash;
        private Label hikakukekka;
        private Button hikakub;
        private Button paste1cb;
        private Button paste2cb;
        private Button hikakureset;
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
        private Label settingslabel;
        private CheckBox HashForContextEnable;
        private PictureBox pictureBox1;
        private CheckBox UpperCheck;
        private CheckBox HihunCheck;
        private RichTextBox richTextBox1;
    }
}
