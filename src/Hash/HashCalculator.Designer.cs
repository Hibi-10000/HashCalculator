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
            CopyRight = new System.Windows.Forms.Label();
            CreatedBy = new System.Windows.Forms.Label();
            DL = new System.Windows.Forms.Label();
            DLLink1 = new System.Windows.Forms.LinkLabel();
            DropPanel = new System.Windows.Forms.Panel();
            DropText = new System.Windows.Forms.Label();
            SelectFileButton = new System.Windows.Forms.Button();
            HashFileURL = new System.Windows.Forms.TextBox();
            SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
            hashandver = new System.Windows.Forms.Label();
            Tab = new System.Windows.Forms.TabControl();
            TabHash = new System.Windows.Forms.TabPage();
            UpperCheck = new System.Windows.Forms.CheckBox();
            AllReset = new System.Windows.Forms.Button();
            HihunCheck = new System.Windows.Forms.CheckBox();
            hikaku2copy = new System.Windows.Forms.Button();
            hikaku1copy = new System.Windows.Forms.Button();
            HashCopy = new System.Windows.Forms.Button();
            HashOutputBox = new System.Windows.Forms.TextBox();
            HashSelecter = new System.Windows.Forms.ComboBox();
            TabHashhikaku = new System.Windows.Forms.TabPage();
            hikakureset = new System.Windows.Forms.Button();
            hikakukekka = new System.Windows.Forms.Label();
            hikakub = new System.Windows.Forms.Button();
            paste1cb = new System.Windows.Forms.Button();
            paste2cb = new System.Windows.Forms.Button();
            hikaku2t = new System.Windows.Forms.Label();
            hikaku1t = new System.Windows.Forms.Label();
            hikaku2hashtype = new System.Windows.Forms.ComboBox();
            hikaku1hashtype = new System.Windows.Forms.ComboBox();
            hikaku2hash = new System.Windows.Forms.TextBox();
            hikaku1hash = new System.Windows.Forms.TextBox();
            TabReadme = new System.Windows.Forms.TabPage();
            Readme = new System.Windows.Forms.RichTextBox();
            TabSettings = new System.Windows.Forms.TabPage();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            HashForContextEnable = new System.Windows.Forms.CheckBox();
            settingslabel = new System.Windows.Forms.Label();
            HashVer = new System.Windows.Forms.Label();
            menuFile = new System.Windows.Forms.ToolStripMenuItem();
            menuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            menuFIleExit = new System.Windows.Forms.ToolStripMenuItem();
            menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            menuHelpReadme = new System.Windows.Forms.ToolStripMenuItem();
            menuHelpVer = new System.Windows.Forms.ToolStripMenuItem();
            menu = new System.Windows.Forms.MenuStrip();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            CopyRight.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            CopyRight.Location = new System.Drawing.Point(620, 611);
            CopyRight.Name = "CopyRight";
            CopyRight.Size = new System.Drawing.Size(357, 25);
            CopyRight.TabIndex = 3;
            CopyRight.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSize = true;
            CreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            CreatedBy.Location = new System.Drawing.Point(726, 42);
            CreatedBy.Name = "CreatedBy";
            CreatedBy.Size = new System.Drawing.Size(195, 25);
            CreatedBy.TabIndex = 5;
            CreatedBy.Text = "CreatedBy : Hibi_10000";
            // 
            // DL
            // 
            DL.AutoSize = true;
            DL.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            DL.Location = new System.Drawing.Point(817, 71);
            DL.Name = "DL";
            DL.Size = new System.Drawing.Size(42, 25);
            DL.TabIndex = 6;
            DL.Text = "DL :";
            // 
            // DLLink1
            // 
            DLLink1.AutoSize = true;
            DLLink1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            DLLink1.Location = new System.Drawing.Point(853, 71);
            DLLink1.Name = "DLLink1";
            DLLink1.Size = new System.Drawing.Size(68, 25);
            DLLink1.TabIndex = 7;
            DLLink1.TabStop = true;
            DLLink1.Text = "GitHub";
            DLLink1.LinkClicked += DLLink1_LinkClicked;
            // 
            // DropPanel
            // 
            DropPanel.AllowDrop = true;
            DropPanel.BackColor = System.Drawing.SystemColors.Window;
            DropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DropPanel.Controls.Add(DropText);
            DropPanel.Controls.Add(SelectFileButton);
            DropPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            DropPanel.Location = new System.Drawing.Point(6, 76);
            DropPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DropPanel.Name = "DropPanel";
            DropPanel.Size = new System.Drawing.Size(892, 194);
            DropPanel.TabIndex = 8;
            DropPanel.DragDrop += DropPanel_DragDrop;
            DropPanel.DragEnter += DropPanel_DragEnter;
            // 
            // DropText
            // 
            DropText.AutoSize = true;
            DropText.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            DropText.Location = new System.Drawing.Point(112, 64);
            DropText.Name = "DropText";
            DropText.Size = new System.Drawing.Size(413, 54);
            DropText.TabIndex = 9;
            DropText.Text = "① ここにファイルをドロップ";
            // 
            // SelectFileButton
            // 
            SelectFileButton.Font = new System.Drawing.Font("游ゴシック Medium", 15F);
            SelectFileButton.Location = new System.Drawing.Point(544, 64);
            SelectFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new System.Drawing.Size(258, 54);
            SelectFileButton.TabIndex = 10;
            SelectFileButton.Text = "① Select File";
            SelectFileButton.UseVisualStyleBackColor = true;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // HashFileURL
            // 
            HashFileURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            HashFileURL.Cursor = System.Windows.Forms.Cursors.No;
            HashFileURL.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            HashFileURL.Location = new System.Drawing.Point(6, 8);
            HashFileURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HashFileURL.Multiline = true;
            HashFileURL.Name = "HashFileURL";
            HashFileURL.ReadOnly = true;
            HashFileURL.Size = new System.Drawing.Size(892, 60);
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
            hashandver.BackColor = System.Drawing.SystemColors.Window;
            hashandver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hashandver.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 128);
            hashandver.ForeColor = System.Drawing.Color.Lime;
            hashandver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            hashandver.Location = new System.Drawing.Point(5, 37);
            hashandver.Name = "hashandver";
            hashandver.Size = new System.Drawing.Size(374, 69);
            hashandver.TabIndex = 12;
            hashandver.Text = "HashCalculator";
            // 
            // Tab
            // 
            Tab.Controls.Add(TabHash);
            Tab.Controls.Add(TabHashhikaku);
            Tab.Controls.Add(TabReadme);
            Tab.Controls.Add(TabSettings);
            Tab.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            Tab.Location = new System.Drawing.Point(5, 110);
            Tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new System.Drawing.Size(916, 501);
            Tab.TabIndex = 13;
            // 
            // TabHash
            // 
            TabHash.BackColor = System.Drawing.SystemColors.Window;
            TabHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            TabHash.Location = new System.Drawing.Point(4, 34);
            TabHash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabHash.Name = "TabHash";
            TabHash.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TabHash.Size = new System.Drawing.Size(908, 463);
            TabHash.TabIndex = 0;
            TabHash.Text = "Hash計算機";
            // 
            // UpperCheck
            // 
            UpperCheck.AutoSize = true;
            UpperCheck.Location = new System.Drawing.Point(236, 280);
            UpperCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            UpperCheck.Name = "UpperCheck";
            UpperCheck.Size = new System.Drawing.Size(92, 29);
            UpperCheck.TabIndex = 19;
            UpperCheck.Text = "大文字";
            UpperCheck.UseVisualStyleBackColor = true;
            UpperCheck.CheckedChanged += HashSelecter_Set;
            // 
            // AllReset
            // 
            AllReset.Font = new System.Drawing.Font("游ゴシック Medium", 9F, System.Drawing.FontStyle.Bold);
            AllReset.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            AllReset.Location = new System.Drawing.Point(608, 278);
            AllReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AllReset.Name = "AllReset";
            AllReset.Size = new System.Drawing.Size(290, 34);
            AllReset.TabIndex = 15;
            AllReset.Text = "値をリセット";
            AllReset.UseVisualStyleBackColor = true;
            AllReset.Click += AllReset_Click;
            // 
            // HihunCheck
            // 
            HihunCheck.AutoSize = true;
            HihunCheck.Location = new System.Drawing.Point(338, 281);
            HihunCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HihunCheck.Name = "HihunCheck";
            HihunCheck.Size = new System.Drawing.Size(90, 29);
            HihunCheck.TabIndex = 18;
            HihunCheck.Text = "ハイフン";
            HihunCheck.UseVisualStyleBackColor = true;
            HihunCheck.CheckedChanged += HashSelecter_Set;
            // 
            // hikaku2copy
            // 
            hikaku2copy.Location = new System.Drawing.Point(608, 418);
            hikaku2copy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikaku2copy.Name = "hikaku2copy";
            hikaku2copy.Size = new System.Drawing.Size(290, 34);
            hikaku2copy.TabIndex = 17;
            hikaku2copy.Text = "比較②にコピー";
            hikaku2copy.UseVisualStyleBackColor = true;
            hikaku2copy.Click += hikaku2copy_Click;
            // 
            // hikaku1copy
            // 
            hikaku1copy.Location = new System.Drawing.Point(305, 418);
            hikaku1copy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikaku1copy.Name = "hikaku1copy";
            hikaku1copy.Size = new System.Drawing.Size(293, 34);
            hikaku1copy.TabIndex = 16;
            hikaku1copy.Text = "比較①にコピー";
            hikaku1copy.UseVisualStyleBackColor = true;
            hikaku1copy.Click += hikaku1copy_Click;
            // 
            // HashCopy
            // 
            HashCopy.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            HashCopy.Location = new System.Drawing.Point(6, 418);
            HashCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HashCopy.Name = "HashCopy";
            HashCopy.Size = new System.Drawing.Size(291, 34);
            HashCopy.TabIndex = 14;
            HashCopy.Text = "Hash値をコピー";
            HashCopy.UseVisualStyleBackColor = true;
            HashCopy.Click += HashCopy_Click;
            // 
            // HashOutputBox
            // 
            HashOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            HashOutputBox.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            HashOutputBox.Location = new System.Drawing.Point(6, 319);
            HashOutputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HashOutputBox.Multiline = true;
            HashOutputBox.Name = "HashOutputBox";
            HashOutputBox.ReadOnly = true;
            HashOutputBox.Size = new System.Drawing.Size(892, 91);
            HashOutputBox.TabIndex = 13;
            HashOutputBox.Text = "ここにHash値が表示されます";
            // 
            // HashSelecter
            // 
            HashSelecter.Font = new System.Drawing.Font("游ゴシック", 10F);
            HashSelecter.FormattingEnabled = true;
            HashSelecter.Items.AddRange([ "②Hashを選択", ..HashCalculate.GetHashTypeNames() ]);
            HashSelecter.Location = new System.Drawing.Point(6, 278);
            HashSelecter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HashSelecter.Name = "HashSelecter";
            HashSelecter.Size = new System.Drawing.Size(222, 34);
            HashSelecter.TabIndex = 12;
            HashSelecter.Text = "②Hashを選択";
            HashSelecter.SelectedIndexChanged += HashSelecter_Set;
            HashSelecter.TextChanged += HashSelecter_Set;
            // 
            // TabHashhikaku
            // 
            TabHashhikaku.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            TabHashhikaku.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            TabHashhikaku.Location = new System.Drawing.Point(4, 34);
            TabHashhikaku.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            TabHashhikaku.Name = "TabHashhikaku";
            TabHashhikaku.Size = new System.Drawing.Size(908, 463);
            TabHashhikaku.TabIndex = 3;
            TabHashhikaku.Text = "Hash比較";
            TabHashhikaku.UseVisualStyleBackColor = true;
            // 
            // hikakureset
            // 
            hikakureset.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            hikakureset.ForeColor = System.Drawing.Color.Red;
            hikakureset.Location = new System.Drawing.Point(781, 4);
            hikakureset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikakureset.Name = "hikakureset";
            hikakureset.Size = new System.Drawing.Size(118, 34);
            hikakureset.TabIndex = 10;
            hikakureset.Text = "リセット";
            hikakureset.UseVisualStyleBackColor = true;
            hikakureset.Click += hikakureset_Click;
            // 
            // hikakukekka
            // 
            hikakukekka.AutoSize = true;
            hikakukekka.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            hikakukekka.Location = new System.Drawing.Point(186, 336);
            hikakukekka.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            hikakukekka.Name = "hikakukekka";
            hikakukekka.Size = new System.Drawing.Size(214, 54);
            hikakukekka.TabIndex = 9;
            hikakukekka.Text = "比較 : 結果";
            // 
            // hikakub
            // 
            hikakub.Font = new System.Drawing.Font("游ゴシック Medium", 30F);
            hikakub.Location = new System.Drawing.Point(616, 264);
            hikakub.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikakub.Name = "hikakub";
            hikakub.Size = new System.Drawing.Size(283, 188);
            hikakub.TabIndex = 8;
            hikakub.Text = "比較";
            hikakub.UseVisualStyleBackColor = true;
            hikakub.Click += hikakub_Click;
            // 
            // paste1cb
            // 
            paste1cb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            paste1cb.Location = new System.Drawing.Point(186, 73);
            paste1cb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            paste1cb.Name = "paste1cb";
            paste1cb.Size = new System.Drawing.Size(345, 31);
            paste1cb.TabIndex = 7;
            paste1cb.Text = "クリップボードから①へ貼り付け";
            paste1cb.UseVisualStyleBackColor = true;
            paste1cb.Click += paste1cb_Click;
            // 
            // paste2cb
            // 
            paste2cb.Location = new System.Drawing.Point(186, 181);
            paste2cb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            paste2cb.Name = "paste2cb";
            paste2cb.Size = new System.Drawing.Size(345, 31);
            paste2cb.TabIndex = 6;
            paste2cb.Text = "クリップボードから②へ貼り付け";
            paste2cb.UseVisualStyleBackColor = true;
            paste2cb.Click += paste2cb_Click;
            // 
            // hikaku2t
            // 
            hikaku2t.AutoSize = true;
            hikaku2t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hikaku2t.Location = new System.Drawing.Point(5, 152);
            hikaku2t.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            hikaku2t.Name = "hikaku2t";
            hikaku2t.Size = new System.Drawing.Size(66, 25);
            hikaku2t.TabIndex = 5;
            hikaku2t.Text = "比較②";
            // 
            // hikaku1t
            // 
            hikaku1t.AutoSize = true;
            hikaku1t.BackColor = System.Drawing.SystemColors.Window;
            hikaku1t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hikaku1t.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            hikaku1t.Location = new System.Drawing.Point(5, 44);
            hikaku1t.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            hikaku1t.Name = "hikaku1t";
            hikaku1t.Size = new System.Drawing.Size(66, 25);
            hikaku1t.TabIndex = 4;
            hikaku1t.Text = "比較①";
            // 
            // hikaku2hashtype
            // 
            hikaku2hashtype.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            hikaku2hashtype.FormattingEnabled = true;
            hikaku2hashtype.Items.AddRange([ "比較②", ..HashCalculate.GetHashTypeNames() ]);
            hikaku2hashtype.Location = new System.Drawing.Point(5, 181);
            hikaku2hashtype.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikaku2hashtype.Name = "hikaku2hashtype";
            hikaku2hashtype.Size = new System.Drawing.Size(171, 31);
            hikaku2hashtype.TabIndex = 3;
            hikaku2hashtype.Text = "比較②";
            // 
            // hikaku1hashtype
            // 
            hikaku1hashtype.Font = new System.Drawing.Font("游ゴシック", 9F);
            hikaku1hashtype.FormattingEnabled = true;
            hikaku1hashtype.Items.AddRange([ "比較①", ..HashCalculate.GetHashTypeNames() ]);
            hikaku1hashtype.Location = new System.Drawing.Point(5, 73);
            hikaku1hashtype.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikaku1hashtype.Name = "hikaku1hashtype";
            hikaku1hashtype.Size = new System.Drawing.Size(171, 31);
            hikaku1hashtype.TabIndex = 2;
            hikaku1hashtype.Text = "比較①";
            // 
            // hikaku2hash
            // 
            hikaku2hash.Location = new System.Drawing.Point(5, 220);
            hikaku2hash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikaku2hash.Name = "hikaku2hash";
            hikaku2hash.Size = new System.Drawing.Size(894, 36);
            hikaku2hash.TabIndex = 1;
            // 
            // hikaku1hash
            // 
            hikaku1hash.Location = new System.Drawing.Point(5, 112);
            hikaku1hash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            hikaku1hash.Name = "hikaku1hash";
            hikaku1hash.Size = new System.Drawing.Size(894, 36);
            hikaku1hash.TabIndex = 0;
            // 
            // TabReadme
            // 
            TabReadme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TabReadme.Controls.Add(Readme);
            TabReadme.Location = new System.Drawing.Point(4, 34);
            TabReadme.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            TabReadme.Name = "TabReadme";
            TabReadme.Size = new System.Drawing.Size(908, 463);
            TabReadme.TabIndex = 4;
            TabReadme.Text = "Readme";
            TabReadme.UseVisualStyleBackColor = true;
            // 
            // Readme
            // 
            Readme.BackColor = System.Drawing.SystemColors.Window;
            Readme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Readme.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            Readme.Location = new System.Drawing.Point(2, 2);
            Readme.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Readme.Name = "Readme";
            Readme.ReadOnly = true;
            Readme.Size = new System.Drawing.Size(903, 455);
            Readme.TabIndex = 0;
            Readme.Text = Properties.Resources.Readme;
            // 
            // TabSettings
            // 
            TabSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TabSettings.Controls.Add(pictureBox1);
            TabSettings.Controls.Add(HashForContextEnable);
            TabSettings.Controls.Add(settingslabel);
            TabSettings.Location = new System.Drawing.Point(4, 34);
            TabSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            TabSettings.Name = "TabSettings";
            TabSettings.Size = new System.Drawing.Size(908, 463);
            TabSettings.TabIndex = 5;
            TabSettings.Text = "設定";
            TabSettings.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = new System.Drawing.Bitmap(Properties.Resources.UAC, 24, 24);
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(101, 86);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(27, 33);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // HashForContextEnable
            // 
            HashForContextEnable.AutoSize = true;
            HashForContextEnable.Checked = true;
            HashForContextEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            HashForContextEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            HashForContextEnable.Location = new System.Drawing.Point(78, 84);
            HashForContextEnable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HashForContextEnable.Name = "HashForContextEnable";
            HashForContextEnable.Size = new System.Drawing.Size(290, 29);
            HashForContextEnable.TabIndex = 18;
            HashForContextEnable.Text = "    Hash for Context を有効にする";
            HashForContextEnable.UseVisualStyleBackColor = true;
            HashForContextEnable.CheckedChanged += HashForContextEnable_CheckedChanged;
            // 
            // settingslabel
            // 
            settingslabel.AutoSize = true;
            settingslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settingslabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            settingslabel.Location = new System.Drawing.Point(0, 0);
            settingslabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            settingslabel.Name = "settingslabel";
            settingslabel.Size = new System.Drawing.Size(105, 56);
            settingslabel.TabIndex = 17;
            settingslabel.Text = "設定";
            // 
            // HashVer
            // 
            HashVer.AutoSize = true;
            HashVer.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            HashVer.Location = new System.Drawing.Point(5, 611);
            HashVer.Name = "HashVer";
            HashVer.Size = new System.Drawing.Size(130, 25);
            HashVer.TabIndex = 14;
            HashVer.Text = "HashCalculator";
            // 
            // menuFile
            // 
            menuFile.AutoSize = false;
            menuFile.BackColor = System.Drawing.SystemColors.ControlLight;
            menuFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFileSettings, menuFIleExit });
            menuFile.Name = "menuFile";
            menuFile.ShortcutKeyDisplayString = "";
            menuFile.ShowShortcutKeys = false;
            menuFile.Size = new System.Drawing.Size(95, 29);
            menuFile.Text = "ファイル(&F)";
            // 
            // menuFileSettings
            // 
            menuFileSettings.BackColor = System.Drawing.SystemColors.Window;
            menuFileSettings.Name = "menuFileSettings";
            menuFileSettings.ShortcutKeyDisplayString = "S";
            menuFileSettings.ShowShortcutKeys = false;
            menuFileSettings.Size = new System.Drawing.Size(159, 34);
            menuFileSettings.Text = "設定(&S)";
            menuFileSettings.Click += menuFileSettings_Click;
            // 
            // menuFIleExit
            // 
            menuFIleExit.AutoSize = false;
            menuFIleExit.BackColor = System.Drawing.SystemColors.Window;
            menuFIleExit.Name = "menuFIleExit";
            menuFIleExit.ShortcutKeyDisplayString = "X";
            menuFIleExit.ShowShortcutKeys = false;
            menuFIleExit.Size = new System.Drawing.Size(159, 34);
            menuFIleExit.Text = "終了(&X)";
            menuFIleExit.Click += menuFIleExit_Click;
            // 
            // menuHelp
            // 
            menuHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuHelpReadme, menuHelpVer });
            menuHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            menuHelp.Name = "menuHelp";
            menuHelp.ShortcutKeyDisplayString = "H";
            menuHelp.Size = new System.Drawing.Size(95, 29);
            menuHelp.Text = "ヘルプ(&H)";
            // 
            // menuHelpReadme
            // 
            menuHelpReadme.BackColor = System.Drawing.SystemColors.Window;
            menuHelpReadme.Name = "menuHelpReadme";
            menuHelpReadme.ShortcutKeyDisplayString = "R";
            menuHelpReadme.ShowShortcutKeys = false;
            menuHelpReadme.Size = new System.Drawing.Size(224, 34);
            menuHelpReadme.Text = "Readme(&R)";
            menuHelpReadme.Click += menuHelpReadme_Click;
            // 
            // menuHelpVer
            // 
            menuHelpVer.BackColor = System.Drawing.SystemColors.Window;
            menuHelpVer.Name = "menuHelpVer";
            menuHelpVer.ShortcutKeyDisplayString = "V";
            menuHelpVer.ShowShortcutKeys = false;
            menuHelpVer.Size = new System.Drawing.Size(224, 34);
            menuHelpVer.Text = "バーション情報(&V)";
            menuHelpVer.Click += menuHelpVer_Click;
            // 
            // menu
            // 
            menu.BackColor = System.Drawing.SystemColors.ControlLight;
            menu.Dock = System.Windows.Forms.DockStyle.None;
            menu.GripMargin = new System.Windows.Forms.Padding(2);
            menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFile, menuHelp });
            menu.Location = new System.Drawing.Point(-8, -4);
            menu.Name = "menu";
            menu.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            menu.Size = new System.Drawing.Size(200, 37);
            menu.TabIndex = 15;
            menu.Text = "menu";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox3.Location = new System.Drawing.Point(0, 0);
            richTextBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new System.Drawing.Size(1010, 33);
            richTextBox3.TabIndex = 16;
            richTextBox3.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Location = new System.Drawing.Point(0, 42);
            richTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(513, 40);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // HashCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(924, 639);
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
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.Icon;
            MainMenuStrip = menu;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "HashCalculator";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Label CopyRight;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Label DL;
        private System.Windows.Forms.LinkLabel DLLink1;
        private System.Windows.Forms.Panel DropPanel;
        private System.Windows.Forms.Label DropText;
        private System.Windows.Forms.TextBox HashFileURL;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.OpenFileDialog SelectFileDialog;
        private System.Windows.Forms.Label hashandver;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage TabHash;
        private System.Windows.Forms.Label HashVer;
        private System.Windows.Forms.ComboBox HashSelecter;
        private System.Windows.Forms.Button AllReset;
        private System.Windows.Forms.Button HashCopy;
        private System.Windows.Forms.TextBox HashOutputBox;
        private System.Windows.Forms.TabPage TabHashhikaku;
        private System.Windows.Forms.Button hikaku2copy;
        private System.Windows.Forms.Button hikaku1copy;
        private System.Windows.Forms.Label hikaku2t;
        private System.Windows.Forms.Label hikaku1t;
        private System.Windows.Forms.ComboBox hikaku2hashtype;
        private System.Windows.Forms.ComboBox hikaku1hashtype;
        private System.Windows.Forms.TextBox hikaku2hash;
        private System.Windows.Forms.TextBox hikaku1hash;
        private System.Windows.Forms.Label hikakukekka;
        private System.Windows.Forms.Button hikakub;
        private System.Windows.Forms.Button paste1cb;
        private System.Windows.Forms.Button paste2cb;
        private System.Windows.Forms.Button hikakureset;
        private System.Windows.Forms.TabPage TabReadme;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.RichTextBox Readme;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ToolStripMenuItem menuFIleExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVer;
        private System.Windows.Forms.ToolStripMenuItem menuHelpReadme;
        private System.Windows.Forms.ToolStripMenuItem menuFileSettings;
        private System.Windows.Forms.Label settingslabel;
        private System.Windows.Forms.CheckBox HashForContextEnable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox HihunCheck;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
