
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
            this.CopyRight = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.Label();
            this.DLLink1 = new System.Windows.Forms.LinkLabel();
            this.DropPanel = new System.Windows.Forms.Panel();
            this.DropText = new System.Windows.Forms.Label();
            this.HashFileURL = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.hashandver = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.TabHash = new System.Windows.Forms.TabPage();
            this.oomojicheck = new System.Windows.Forms.CheckBox();
            this.hyhuncheck = new System.Windows.Forms.CheckBox();
            this.hikaku2copy = new System.Windows.Forms.Button();
            this.hikaku1copy = new System.Windows.Forms.Button();
            this.AllReset = new System.Windows.Forms.Button();
            this.HashCopy = new System.Windows.Forms.Button();
            this.HashABox = new System.Windows.Forms.TextBox();
            this.HashSelectBox = new System.Windows.Forms.ComboBox();
            this.TabHashhikaku = new System.Windows.Forms.TabPage();
            this.hikakureset = new System.Windows.Forms.Button();
            this.hikakukekka = new System.Windows.Forms.Label();
            this.hikakub = new System.Windows.Forms.Button();
            this.paste1cb = new System.Windows.Forms.Button();
            this.paste2cb = new System.Windows.Forms.Button();
            this.hikaku2t = new System.Windows.Forms.Label();
            this.hikaku1t = new System.Windows.Forms.Label();
            this.hikaku2hashtype = new System.Windows.Forms.ComboBox();
            this.hikaku1hashtype = new System.Windows.Forms.ComboBox();
            this.hikaku2hash = new System.Windows.Forms.TextBox();
            this.hikaku1hash = new System.Windows.Forms.TextBox();
            this.TabReadme = new System.Windows.Forms.TabPage();
            this.Readme = new System.Windows.Forms.RichTextBox();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HashForContextEnable = new System.Windows.Forms.CheckBox();
            this.settingslabel = new System.Windows.Forms.Label();
            this.HashVer = new System.Windows.Forms.Label();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFIleExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.DropPanel.SuspendLayout();
            this.Tab.SuspendLayout();
            this.TabHash.SuspendLayout();
            this.TabHashhikaku.SuspendLayout();
            this.TabReadme.SuspendLayout();
            this.TabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyRight
            // 
            this.CopyRight.AutoSize = true;
            this.CopyRight.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CopyRight.Location = new System.Drawing.Point(287, 386);
            this.CopyRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Size = new System.Drawing.Size(272, 15);
            this.CopyRight.TabIndex = 3;
            this.CopyRight.Text = "CopyRight © 2022 Hibi_10000  All Rights Reserved.";
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreatedBy.Location = new System.Drawing.Point(423, 24);
            this.CreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(126, 15);
            this.CreatedBy.TabIndex = 5;
            this.CreatedBy.Text = "CreatedBy : Hibi_10000";
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.DL.Location = new System.Drawing.Point(474, 39);
            this.DL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(27, 15);
            this.DL.TabIndex = 6;
            this.DL.Text = "DL :";
            // 
            // DLLink1
            // 
            this.DLLink1.AutoSize = true;
            this.DLLink1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.DLLink1.Location = new System.Drawing.Point(503, 39);
            this.DLLink1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DLLink1.Name = "DLLink1";
            this.DLLink1.Size = new System.Drawing.Size(45, 15);
            this.DLLink1.TabIndex = 7;
            this.DLLink1.TabStop = true;
            this.DLLink1.Text = "GitHub";
            this.DLLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DLLink1_LinkClicked);
            // 
            // DropPanel
            // 
            this.DropPanel.AllowDrop = true;
            this.DropPanel.BackColor = System.Drawing.SystemColors.Window;
            this.DropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DropPanel.Controls.Add(this.DropText);
            this.DropPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DropPanel.Location = new System.Drawing.Point(5, 47);
            this.DropPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DropPanel.Name = "DropPanel";
            this.DropPanel.Size = new System.Drawing.Size(534, 127);
            this.DropPanel.TabIndex = 8;
            this.DropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragDrop);
            this.DropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragEnter);
            // 
            // DropText
            // 
            this.DropText.AutoSize = true;
            this.DropText.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.DropText.Location = new System.Drawing.Point(124, 39);
            this.DropText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DropText.Name = "DropText";
            this.DropText.Size = new System.Drawing.Size(289, 37);
            this.DropText.TabIndex = 9;
            this.DropText.Text = "①  ここにファイルをドロップ";
            // 
            // HashFileURL
            // 
            this.HashFileURL.Cursor = System.Windows.Forms.Cursors.No;
            this.HashFileURL.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.HashFileURL.Location = new System.Drawing.Point(5, 4);
            this.HashFileURL.Margin = new System.Windows.Forms.Padding(2);
            this.HashFileURL.Multiline = true;
            this.HashFileURL.Name = "HashFileURL";
            this.HashFileURL.ReadOnly = true;
            this.HashFileURL.Size = new System.Drawing.Size(358, 39);
            this.HashFileURL.TabIndex = 9;
            this.HashFileURL.Text = "ファイルのパス";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("游ゴシック Medium", 15F);
            this.SelectFileButton.Location = new System.Drawing.Point(366, 4);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(173, 39);
            this.SelectFileButton.TabIndex = 10;
            this.SelectFileButton.Text = " ①  Select File    ";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SelectFileDialog
            // 
            this.SelectFileDialog.InitialDirectory = "@C:\\";
            this.SelectFileDialog.SupportMultiDottedExtensions = true;
            this.SelectFileDialog.Title = "ファイルを選択";
            // 
            // hashandver
            // 
            this.hashandver.AutoSize = true;
            this.hashandver.BackColor = System.Drawing.SystemColors.Window;
            this.hashandver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hashandver.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hashandver.ForeColor = System.Drawing.Color.Lime;
            this.hashandver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hashandver.Location = new System.Drawing.Point(7, 27);
            this.hashandver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hashandver.Name = "hashandver";
            this.hashandver.Size = new System.Drawing.Size(312, 47);
            this.hashandver.TabIndex = 12;
            this.hashandver.Text = "HashCalculator Ver.";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TabHash);
            this.Tab.Controls.Add(this.TabHashhikaku);
            this.Tab.Controls.Add(this.TabReadme);
            this.Tab.Controls.Add(this.TabSettings);
            this.Tab.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.Tab.Location = new System.Drawing.Point(3, 77);
            this.Tab.Margin = new System.Windows.Forms.Padding(2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(556, 307);
            this.Tab.TabIndex = 13;
            // 
            // TabHash
            // 
            this.TabHash.BackColor = System.Drawing.SystemColors.Window;
            this.TabHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabHash.Controls.Add(this.oomojicheck);
            this.TabHash.Controls.Add(this.hyhuncheck);
            this.TabHash.Controls.Add(this.hikaku2copy);
            this.TabHash.Controls.Add(this.hikaku1copy);
            this.TabHash.Controls.Add(this.AllReset);
            this.TabHash.Controls.Add(this.HashCopy);
            this.TabHash.Controls.Add(this.HashABox);
            this.TabHash.Controls.Add(this.HashSelectBox);
            this.TabHash.Controls.Add(this.SelectFileButton);
            this.TabHash.Controls.Add(this.DropPanel);
            this.TabHash.Controls.Add(this.HashFileURL);
            this.TabHash.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabHash.Location = new System.Drawing.Point(4, 24);
            this.TabHash.Margin = new System.Windows.Forms.Padding(2);
            this.TabHash.Name = "TabHash";
            this.TabHash.Padding = new System.Windows.Forms.Padding(2);
            this.TabHash.Size = new System.Drawing.Size(548, 279);
            this.TabHash.TabIndex = 0;
            this.TabHash.Text = "Hash計算機";
            // 
            // oomojicheck
            // 
            this.oomojicheck.AutoSize = true;
            this.oomojicheck.Location = new System.Drawing.Point(247, 181);
            this.oomojicheck.Name = "oomojicheck";
            this.oomojicheck.Size = new System.Drawing.Size(62, 19);
            this.oomojicheck.TabIndex = 19;
            this.oomojicheck.Text = "大文字";
            this.oomojicheck.UseVisualStyleBackColor = true;
            this.oomojicheck.Visible = false;
            // 
            // hyhuncheck
            // 
            this.hyhuncheck.AutoSize = true;
            this.hyhuncheck.Location = new System.Drawing.Point(170, 181);
            this.hyhuncheck.Name = "hyhuncheck";
            this.hyhuncheck.Size = new System.Drawing.Size(61, 19);
            this.hyhuncheck.TabIndex = 18;
            this.hyhuncheck.Text = "ハイフン";
            this.hyhuncheck.UseVisualStyleBackColor = true;
            this.hyhuncheck.Visible = false;
            // 
            // hikaku2copy
            // 
            this.hikaku2copy.Location = new System.Drawing.Point(186, 251);
            this.hikaku2copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikaku2copy.Name = "hikaku2copy";
            this.hikaku2copy.Size = new System.Drawing.Size(175, 23);
            this.hikaku2copy.TabIndex = 17;
            this.hikaku2copy.Text = "比較②にコピー";
            this.hikaku2copy.UseVisualStyleBackColor = true;
            this.hikaku2copy.Click += new System.EventHandler(this.hikaku2copy_Click);
            // 
            // hikaku1copy
            // 
            this.hikaku1copy.Location = new System.Drawing.Point(5, 251);
            this.hikaku1copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikaku1copy.Name = "hikaku1copy";
            this.hikaku1copy.Size = new System.Drawing.Size(175, 23);
            this.hikaku1copy.TabIndex = 16;
            this.hikaku1copy.Text = "比較①にコピー";
            this.hikaku1copy.UseVisualStyleBackColor = true;
            this.hikaku1copy.Click += new System.EventHandler(this.hikaku1copy_Click);
            // 
            // AllReset
            // 
            this.AllReset.Font = new System.Drawing.Font("游ゴシック Medium", 9F, System.Drawing.FontStyle.Bold);
            this.AllReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllReset.Location = new System.Drawing.Point(366, 251);
            this.AllReset.Margin = new System.Windows.Forms.Padding(2);
            this.AllReset.Name = "AllReset";
            this.AllReset.Size = new System.Drawing.Size(174, 23);
            this.AllReset.TabIndex = 15;
            this.AllReset.Text = "値をリセット";
            this.AllReset.UseVisualStyleBackColor = true;
            this.AllReset.Click += new System.EventHandler(this.AllReset_Click);
            // 
            // HashCopy
            // 
            this.HashCopy.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            this.HashCopy.Location = new System.Drawing.Point(335, 178);
            this.HashCopy.Margin = new System.Windows.Forms.Padding(2);
            this.HashCopy.Name = "HashCopy";
            this.HashCopy.Size = new System.Drawing.Size(205, 25);
            this.HashCopy.TabIndex = 14;
            this.HashCopy.Text = "Hash値をコピー";
            this.HashCopy.UseVisualStyleBackColor = true;
            this.HashCopy.Click += new System.EventHandler(this.HashCopy_Click);
            // 
            // HashABox
            // 
            this.HashABox.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.HashABox.Location = new System.Drawing.Point(5, 207);
            this.HashABox.Margin = new System.Windows.Forms.Padding(2);
            this.HashABox.Multiline = true;
            this.HashABox.Name = "HashABox";
            this.HashABox.ReadOnly = true;
            this.HashABox.Size = new System.Drawing.Size(534, 40);
            this.HashABox.TabIndex = 13;
            this.HashABox.Text = "ここにHash値が表示されます";
            // 
            // HashSelectBox
            // 
            this.HashSelectBox.Font = new System.Drawing.Font("游ゴシック", 10F);
            this.HashSelectBox.FormattingEnabled = true;
            this.HashSelectBox.Items.AddRange(new object[] {
            "②Hashを選択",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.HashSelectBox.Location = new System.Drawing.Point(5, 178);
            this.HashSelectBox.Margin = new System.Windows.Forms.Padding(2);
            this.HashSelectBox.Name = "HashSelectBox";
            this.HashSelectBox.Size = new System.Drawing.Size(149, 25);
            this.HashSelectBox.TabIndex = 12;
            this.HashSelectBox.Text = "②Hashを選択";
            this.HashSelectBox.SelectedIndexChanged += new System.EventHandler(this.HashSelectBox_Set);
            // 
            // TabHashhikaku
            // 
            this.TabHashhikaku.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabHashhikaku.Controls.Add(this.hikakureset);
            this.TabHashhikaku.Controls.Add(this.hikakukekka);
            this.TabHashhikaku.Controls.Add(this.hikakub);
            this.TabHashhikaku.Controls.Add(this.paste1cb);
            this.TabHashhikaku.Controls.Add(this.paste2cb);
            this.TabHashhikaku.Controls.Add(this.hikaku2t);
            this.TabHashhikaku.Controls.Add(this.hikaku1t);
            this.TabHashhikaku.Controls.Add(this.hikaku2hashtype);
            this.TabHashhikaku.Controls.Add(this.hikaku1hashtype);
            this.TabHashhikaku.Controls.Add(this.hikaku2hash);
            this.TabHashhikaku.Controls.Add(this.hikaku1hash);
            this.TabHashhikaku.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            this.TabHashhikaku.Location = new System.Drawing.Point(4, 24);
            this.TabHashhikaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabHashhikaku.Name = "TabHashhikaku";
            this.TabHashhikaku.Size = new System.Drawing.Size(548, 279);
            this.TabHashhikaku.TabIndex = 3;
            this.TabHashhikaku.Text = "Hash比較";
            this.TabHashhikaku.UseVisualStyleBackColor = true;
            // 
            // hikakureset
            // 
            this.hikakureset.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            this.hikakureset.ForeColor = System.Drawing.Color.Red;
            this.hikakureset.Location = new System.Drawing.Point(468, 2);
            this.hikakureset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikakureset.Name = "hikakureset";
            this.hikakureset.Size = new System.Drawing.Size(71, 23);
            this.hikakureset.TabIndex = 10;
            this.hikakureset.Text = "リセット";
            this.hikakureset.UseVisualStyleBackColor = true;
            this.hikakureset.Click += new System.EventHandler(this.hikakureset_Click);
            // 
            // hikakukekka
            // 
            this.hikakukekka.AutoSize = true;
            this.hikakukekka.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.hikakukekka.Location = new System.Drawing.Point(104, 202);
            this.hikakukekka.Name = "hikakukekka";
            this.hikakukekka.Size = new System.Drawing.Size(145, 37);
            this.hikakukekka.TabIndex = 9;
            this.hikakukekka.Text = "比較 : 結果";
            // 
            // hikakub
            // 
            this.hikakub.Font = new System.Drawing.Font("游ゴシック Medium", 30F);
            this.hikakub.Location = new System.Drawing.Point(369, 183);
            this.hikakub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikakub.Name = "hikakub";
            this.hikakub.Size = new System.Drawing.Size(170, 90);
            this.hikakub.TabIndex = 8;
            this.hikakub.Text = "比較";
            this.hikakub.UseVisualStyleBackColor = true;
            this.hikakub.Click += new System.EventHandler(this.hikakub_Click);
            // 
            // paste1cb
            // 
            this.paste1cb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paste1cb.Location = new System.Drawing.Point(113, 47);
            this.paste1cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paste1cb.Name = "paste1cb";
            this.paste1cb.Size = new System.Drawing.Size(207, 24);
            this.paste1cb.TabIndex = 7;
            this.paste1cb.Text = "クリップボードから①へ貼り付け";
            this.paste1cb.UseVisualStyleBackColor = true;
            this.paste1cb.Click += new System.EventHandler(this.paste1cb_Click);
            // 
            // paste2cb
            // 
            this.paste2cb.Location = new System.Drawing.Point(113, 124);
            this.paste2cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paste2cb.Name = "paste2cb";
            this.paste2cb.Size = new System.Drawing.Size(207, 24);
            this.paste2cb.TabIndex = 6;
            this.paste2cb.Text = "クリップボードから②へ貼り付け";
            this.paste2cb.UseVisualStyleBackColor = true;
            this.paste2cb.Click += new System.EventHandler(this.paste2cb_Click);
            // 
            // hikaku2t
            // 
            this.hikaku2t.AutoSize = true;
            this.hikaku2t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hikaku2t.Location = new System.Drawing.Point(3, 104);
            this.hikaku2t.Name = "hikaku2t";
            this.hikaku2t.Size = new System.Drawing.Size(45, 18);
            this.hikaku2t.TabIndex = 5;
            this.hikaku2t.Text = "比較②";
            // 
            // hikaku1t
            // 
            this.hikaku1t.AutoSize = true;
            this.hikaku1t.BackColor = System.Drawing.SystemColors.Window;
            this.hikaku1t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hikaku1t.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hikaku1t.Location = new System.Drawing.Point(3, 27);
            this.hikaku1t.Name = "hikaku1t";
            this.hikaku1t.Size = new System.Drawing.Size(45, 18);
            this.hikaku1t.TabIndex = 4;
            this.hikaku1t.Text = "比較①";
            // 
            // hikaku2hashtype
            // 
            this.hikaku2hashtype.AutoCompleteCustomSource.AddRange(new string[] {
            "比較②",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hikaku2hashtype.Font = new System.Drawing.Font("游ゴシック Medium", 9F);
            this.hikaku2hashtype.FormattingEnabled = true;
            this.hikaku2hashtype.Items.AddRange(new object[] {
            "比較②",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hikaku2hashtype.Location = new System.Drawing.Point(3, 124);
            this.hikaku2hashtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikaku2hashtype.Name = "hikaku2hashtype";
            this.hikaku2hashtype.Size = new System.Drawing.Size(104, 24);
            this.hikaku2hashtype.TabIndex = 3;
            this.hikaku2hashtype.Text = "比較②";
            // 
            // hikaku1hashtype
            // 
            this.hikaku1hashtype.Font = new System.Drawing.Font("游ゴシック", 9F);
            this.hikaku1hashtype.FormattingEnabled = true;
            this.hikaku1hashtype.Items.AddRange(new object[] {
            "比較①",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hikaku1hashtype.Location = new System.Drawing.Point(3, 47);
            this.hikaku1hashtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikaku1hashtype.Name = "hikaku1hashtype";
            this.hikaku1hashtype.Size = new System.Drawing.Size(104, 24);
            this.hikaku1hashtype.TabIndex = 2;
            this.hikaku1hashtype.Text = "比較①";
            // 
            // hikaku2hash
            // 
            this.hikaku2hash.Location = new System.Drawing.Point(3, 152);
            this.hikaku2hash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikaku2hash.Name = "hikaku2hash";
            this.hikaku2hash.Size = new System.Drawing.Size(536, 27);
            this.hikaku2hash.TabIndex = 1;
            // 
            // hikaku1hash
            // 
            this.hikaku1hash.Location = new System.Drawing.Point(3, 75);
            this.hikaku1hash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikaku1hash.Name = "hikaku1hash";
            this.hikaku1hash.Size = new System.Drawing.Size(536, 27);
            this.hikaku1hash.TabIndex = 0;
            // 
            // TabReadme
            // 
            this.TabReadme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabReadme.Controls.Add(this.Readme);
            this.TabReadme.Location = new System.Drawing.Point(4, 24);
            this.TabReadme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabReadme.Name = "TabReadme";
            this.TabReadme.Size = new System.Drawing.Size(548, 279);
            this.TabReadme.TabIndex = 4;
            this.TabReadme.Text = "Readme";
            this.TabReadme.UseVisualStyleBackColor = true;
            // 
            // Readme
            // 
            this.Readme.BackColor = System.Drawing.SystemColors.Window;
            this.Readme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Readme.Cursor = System.Windows.Forms.Cursors.Default;
            this.Readme.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Readme.Location = new System.Drawing.Point(1, 1);
            this.Readme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Readme.Name = "Readme";
            this.Readme.ReadOnly = true;
            this.Readme.Size = new System.Drawing.Size(542, 272);
            this.Readme.TabIndex = 0;
            this.Readme.Text = resources.GetString("Readme.Text");
            // 
            // TabSettings
            // 
            this.TabSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabSettings.Controls.Add(this.pictureBox1);
            this.TabSettings.Controls.Add(this.HashForContextEnable);
            this.TabSettings.Controls.Add(this.settingslabel);
            this.TabSettings.Location = new System.Drawing.Point(4, 24);
            this.TabSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Size = new System.Drawing.Size(548, 279);
            this.TabSettings.TabIndex = 5;
            this.TabSettings.Text = "設定";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Hash.Properties.Resources.UAC;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(73, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // HashForContextEnable
            // 
            this.HashForContextEnable.AutoSize = true;
            this.HashForContextEnable.Checked = true;
            this.HashForContextEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HashForContextEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HashForContextEnable.Location = new System.Drawing.Point(59, 60);
            this.HashForContextEnable.Name = "HashForContextEnable";
            this.HashForContextEnable.Size = new System.Drawing.Size(191, 19);
            this.HashForContextEnable.TabIndex = 18;
            this.HashForContextEnable.Text = "    Hash for Context を有効にする";
            this.HashForContextEnable.UseVisualStyleBackColor = true;
            this.HashForContextEnable.CheckedChanged += new System.EventHandler(this.HashForContextEnable_CheckedChanged);
            // 
            // settingslabel
            // 
            this.settingslabel.AutoSize = true;
            this.settingslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingslabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.settingslabel.Location = new System.Drawing.Point(0, 0);
            this.settingslabel.Name = "settingslabel";
            this.settingslabel.Size = new System.Drawing.Size(73, 39);
            this.settingslabel.TabIndex = 17;
            this.settingslabel.Text = "設定";
            // 
            // HashVer
            // 
            this.HashVer.AutoSize = true;
            this.HashVer.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HashVer.Location = new System.Drawing.Point(0, 386);
            this.HashVer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HashVer.Name = "HashVer";
            this.HashVer.Size = new System.Drawing.Size(108, 15);
            this.HashVer.TabIndex = 14;
            this.HashVer.Text = "HashCalculator Ver.";
            // 
            // menuFile
            // 
            this.menuFile.AutoSize = false;
            this.menuFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSettings,
            this.menuFIleExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeyDisplayString = "";
            this.menuFile.ShowShortcutKeys = false;
            this.menuFile.Size = new System.Drawing.Size(65, 20);
            this.menuFile.Text = "ファイル(&F)";
            // 
            // menuFileSettings
            // 
            this.menuFileSettings.Name = "menuFileSettings";
            this.menuFileSettings.ShortcutKeyDisplayString = "S";
            this.menuFileSettings.ShowShortcutKeys = false;
            this.menuFileSettings.Size = new System.Drawing.Size(106, 22);
            this.menuFileSettings.Text = "設定(&S)";
            this.menuFileSettings.Click += new System.EventHandler(this.menuFileSettings_Click);
            // 
            // menuFIleExit
            // 
            this.menuFIleExit.AutoSize = false;
            this.menuFIleExit.Name = "menuFIleExit";
            this.menuFIleExit.ShortcutKeyDisplayString = "X";
            this.menuFIleExit.ShowShortcutKeys = false;
            this.menuFIleExit.Size = new System.Drawing.Size(180, 22);
            this.menuFIleExit.Text = "終了(&X)";
            this.menuFIleExit.Click += new System.EventHandler(this.menuFIleExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpReadme,
            this.menuHelpVer});
            this.menuHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.ShortcutKeyDisplayString = "H";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "ヘルプ(&H)";
            // 
            // menuHelpReadme
            // 
            this.menuHelpReadme.Name = "menuHelpReadme";
            this.menuHelpReadme.ShortcutKeyDisplayString = "R";
            this.menuHelpReadme.ShowShortcutKeys = false;
            this.menuHelpReadme.Size = new System.Drawing.Size(150, 22);
            this.menuHelpReadme.Text = "Readme(&R)";
            this.menuHelpReadme.Click += new System.EventHandler(this.menuHelpReadme_Click);
            // 
            // menuHelpVer
            // 
            this.menuHelpVer.Name = "menuHelpVer";
            this.menuHelpVer.ShortcutKeyDisplayString = "V";
            this.menuHelpVer.ShowShortcutKeys = false;
            this.menuHelpVer.Size = new System.Drawing.Size(150, 22);
            this.menuHelpVer.Text = "バーション情報(&V)";
            this.menuHelpVer.Click += new System.EventHandler(this.menuHelpVer_Click);
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(-5, -2);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(137, 24);
            this.menu.TabIndex = 15;
            this.menu.Text = "menu";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox3.Font = new System.Drawing.Font("Yu Gothic UI", 1F);
            this.richTextBox3.Location = new System.Drawing.Point(3, 0);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(606, 20);
            this.richTextBox3.TabIndex = 16;
            this.richTextBox3.Text = "_________________________________________________________________________________" +
    "____________________________";
            // 
            // HashCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(560, 403);
            this.Controls.Add(this.HashVer);
            this.Controls.Add(this.DL);
            this.Controls.Add(this.hashandver);
            this.Controls.Add(this.DLLink1);
            this.Controls.Add(this.CreatedBy);
            this.Controls.Add(this.CopyRight);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.richTextBox3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HashCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HashCalculator Ver.";
            this.Load += new System.EventHandler(this.Hash_Load);
            this.DropPanel.ResumeLayout(false);
            this.DropPanel.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.TabHash.ResumeLayout(false);
            this.TabHash.PerformLayout();
            this.TabHashhikaku.ResumeLayout(false);
            this.TabHashhikaku.PerformLayout();
            this.TabReadme.ResumeLayout(false);
            this.TabSettings.ResumeLayout(false);
            this.TabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox HashSelectBox;
        private System.Windows.Forms.Button AllReset;
        private System.Windows.Forms.Button HashCopy;
        private System.Windows.Forms.TextBox HashABox;
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
        private System.Windows.Forms.CheckBox oomojicheck;
        private System.Windows.Forms.CheckBox hyhuncheck;
    }
}

