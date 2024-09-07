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
    partial class HashForContext
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            Copyright = new Label();
            OK = new Button();
            Title = new Label();
            HashSelecter = new ComboBox();
            HashOutputBox = new TextBox();
            HashFileURL = new TextBox();
            HashReset = new Button();
            HashCopy = new Button();
            CreatedBy = new Label();
            DL = new Label();
            DLGithub = new LinkLabel();
            StartHash = new Button();
            DebugUse = new Button();
            DebugUseDialog = new OpenFileDialog();
            UpperCheck = new CheckBox();
            HihunCheck = new CheckBox();
            SuspendLayout();
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Copyright.Location = new Point(14, 320);
            Copyright.Margin = new Padding(5, 0, 5, 0);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(352, 25);
            Copyright.TabIndex = 1;
            Copyright.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // OK
            // 
            OK.Font = new Font("Yu Gothic UI", 10F);
            OK.Location = new Point(731, 298);
            OK.Margin = new Padding(5, 6, 5, 6);
            OK.Name = "OK";
            OK.Size = new Size(148, 47);
            OK.TabIndex = 2;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = SystemColors.Window;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("Yu Gothic UI Semibold", 20.25F);
            Title.ForeColor = Color.Lime;
            Title.Location = new Point(14, 9);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(448, 57);
            Title.TabIndex = 3;
            Title.Text = "Hash for ContextMenu";
            // 
            // HashSelecter
            // 
            HashSelecter.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            HashSelecter.FormattingEnabled = true;
            HashSelecter.Items.AddRange([ "Hashを選択してください", ..HashCalculate.GetHashTypeNames() ]);
            HashSelecter.Location = new Point(14, 164);
            HashSelecter.Margin = new Padding(5, 6, 5, 6);
            HashSelecter.Name = "HashSelecter";
            HashSelecter.Size = new Size(222, 33);
            HashSelecter.TabIndex = 4;
            HashSelecter.Text = "Hashを選択してください";
            HashSelecter.SelectedIndexChanged += HashSelecter_Set;
            HashSelecter.TextChanged += HashSelecter_Set;
            // 
            // HashOutputBox
            // 
            HashOutputBox.BackColor = SystemColors.Window;
            HashOutputBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            HashOutputBox.Location = new Point(14, 209);
            HashOutputBox.Margin = new Padding(5, 6, 5, 6);
            HashOutputBox.Multiline = true;
            HashOutputBox.Name = "HashOutputBox";
            HashOutputBox.ReadOnly = true;
            HashOutputBox.Size = new Size(865, 77);
            HashOutputBox.TabIndex = 5;
            HashOutputBox.Text = "ここにHash値が表示されます";
            // 
            // HashFileURL
            // 
            HashFileURL.BackColor = SystemColors.Window;
            HashFileURL.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            HashFileURL.Location = new Point(14, 91);
            HashFileURL.Margin = new Padding(5, 6, 5, 6);
            HashFileURL.Multiline = true;
            HashFileURL.Name = "HashFileURL";
            HashFileURL.ReadOnly = true;
            HashFileURL.Size = new Size(865, 61);
            HashFileURL.TabIndex = 6;
            HashFileURL.Text = "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)";
            // 
            // HashReset
            // 
            HashReset.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            HashReset.ForeColor = Color.Red;
            HashReset.Location = new Point(696, 164);
            HashReset.Margin = new Padding(5, 6, 5, 6);
            HashReset.Name = "HashReset";
            HashReset.Size = new Size(183, 33);
            HashReset.TabIndex = 7;
            HashReset.Text = "Hashをリセット";
            HashReset.UseVisualStyleBackColor = true;
            HashReset.Click += HashReset_Click;
            // 
            // HashCopy
            // 
            HashCopy.Font = new Font("Yu Gothic UI", 9F);
            HashCopy.Location = new Point(489, 164);
            HashCopy.Margin = new Padding(5, 6, 5, 6);
            HashCopy.Name = "HashCopy";
            HashCopy.Size = new Size(197, 33);
            HashCopy.TabIndex = 8;
            HashCopy.Text = "Hashをコピー";
            HashCopy.UseVisualStyleBackColor = true;
            HashCopy.Click += HashCopy_Click;
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSize = true;
            CreatedBy.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CreatedBy.Location = new Point(689, 9);
            CreatedBy.Margin = new Padding(5, 0, 5, 0);
            CreatedBy.Name = "CreatedBy";
            CreatedBy.Size = new Size(190, 25);
            CreatedBy.TabIndex = 9;
            CreatedBy.Text = "CreatedBy: Hibi_10000";
            // 
            // DL
            // 
            DL.AutoSize = true;
            DL.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            DL.Location = new Point(776, 34);
            DL.Margin = new Padding(5, 0, 5, 0);
            DL.Name = "DL";
            DL.Size = new Size(42, 25);
            DL.TabIndex = 10;
            DL.Text = "DL :";
            // 
            // DLGithub
            // 
            DLGithub.AutoSize = true;
            DLGithub.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            DLGithub.Location = new Point(814, 34);
            DLGithub.Margin = new Padding(5, 0, 5, 0);
            DLGithub.Name = "DLGithub";
            DLGithub.Size = new Size(65, 25);
            DLGithub.TabIndex = 11;
            DLGithub.TabStop = true;
            DLGithub.Text = "GitHub";
            DLGithub.LinkClicked += DLGithub_LinkClicked;
            // 
            // StartHash
            // 
            StartHash.Font = new Font("Yu Gothic UI", 10F);
            StartHash.Location = new Point(489, 298);
            StartHash.Margin = new Padding(5, 6, 5, 6);
            StartHash.Name = "StartHash";
            StartHash.Size = new Size(232, 47);
            StartHash.TabIndex = 12;
            StartHash.Text = "Hash計算機を起動";
            StartHash.UseVisualStyleBackColor = true;
            StartHash.Click += StartHash_Click;
            // 
            // DebugUse
            // 
            DebugUse.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            DebugUse.Location = new Point(354, 297);
            DebugUse.Margin = new Padding(5, 6, 5, 6);
            DebugUse.Name = "DebugUse";
            DebugUse.Size = new Size(125, 48);
            DebugUse.TabIndex = 13;
            DebugUse.Text = "DebugUse";
            DebugUse.UseVisualStyleBackColor = true;
            DebugUse.Visible = false;
            DebugUse.Click += DebugUse_Click;
            // 
            // UpperCheck
            // 
            UpperCheck.AutoSize = true;
            UpperCheck.Location = new Point(246, 166);
            UpperCheck.Margin = new Padding(5, 6, 5, 6);
            UpperCheck.Name = "UpperCheck";
            UpperCheck.Size = new Size(92, 29);
            UpperCheck.TabIndex = 14;
            UpperCheck.Text = "大文字";
            UpperCheck.UseVisualStyleBackColor = true;
            UpperCheck.CheckedChanged += HashSelecter_Set;
            // 
            // HihunCheck
            // 
            HihunCheck.AutoSize = true;
            HihunCheck.Location = new Point(348, 166);
            HihunCheck.Margin = new Padding(5, 6, 5, 6);
            HihunCheck.Name = "HihunCheck";
            HihunCheck.Size = new Size(90, 29);
            HihunCheck.TabIndex = 15;
            HihunCheck.Text = "ハイフン";
            HihunCheck.UseVisualStyleBackColor = true;
            HihunCheck.CheckedChanged += HashSelecter_Set;
            // 
            // HashForContext
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 354);
            Controls.Add(HihunCheck);
            Controls.Add(UpperCheck);
            Controls.Add(DebugUse);
            Controls.Add(StartHash);
            Controls.Add(DLGithub);
            Controls.Add(DL);
            Controls.Add(CreatedBy);
            Controls.Add(HashCopy);
            Controls.Add(HashReset);
            Controls.Add(HashFileURL);
            Controls.Add(HashOutputBox);
            Controls.Add(HashSelecter);
            Controls.Add(Title);
            Controls.Add(OK);
            Controls.Add(Copyright);
            Icon = Properties.Resources.Icon;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "HashForContext";
            Text = "Hash for ContextMenu";
            Load += HashForContext_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Copyright;
        private Button OK;
        private Label Title;
        private ComboBox HashSelecter;
        private TextBox HashOutputBox;
        private TextBox HashFileURL;
        private Button HashReset;
        private Button HashCopy;
        private Label CreatedBy;
        private Label DL;
        private LinkLabel DLGithub;
        private Button StartHash;
        private Button DebugUse;
        private OpenFileDialog DebugUseDialog;
        private CheckBox UpperCheck;
        private CheckBox HihunCheck;
    }
}
