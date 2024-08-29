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
            Copyright = new System.Windows.Forms.Label();
            OK = new System.Windows.Forms.Button();
            Title = new System.Windows.Forms.Label();
            HashSelecter = new System.Windows.Forms.ComboBox();
            HashOutputBox = new System.Windows.Forms.TextBox();
            HashFileURL = new System.Windows.Forms.TextBox();
            HashReset = new System.Windows.Forms.Button();
            HashCopy = new System.Windows.Forms.Button();
            CreatedBy = new System.Windows.Forms.Label();
            DL = new System.Windows.Forms.Label();
            DLGithub = new System.Windows.Forms.LinkLabel();
            StartHash = new System.Windows.Forms.Button();
            DebugUse = new System.Windows.Forms.Button();
            DebugUseDialog = new System.Windows.Forms.OpenFileDialog();
            UpperCheck = new System.Windows.Forms.CheckBox();
            HihunCheck = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            Copyright.Location = new System.Drawing.Point(14, 320);
            Copyright.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Copyright.Name = "Copyright";
            Copyright.Size = new System.Drawing.Size(352, 25);
            Copyright.TabIndex = 1;
            Copyright.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // OK
            // 
            OK.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            OK.Location = new System.Drawing.Point(731, 298);
            OK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            OK.Name = "OK";
            OK.Size = new System.Drawing.Size(148, 47);
            OK.TabIndex = 2;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = System.Drawing.SystemColors.Window;
            Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F);
            Title.ForeColor = System.Drawing.Color.Lime;
            Title.Location = new System.Drawing.Point(14, 9);
            Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(448, 57);
            Title.TabIndex = 3;
            Title.Text = "Hash for ContextMenu";
            // 
            // HashSelecter
            // 
            HashSelecter.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            HashSelecter.FormattingEnabled = true;
            HashSelecter.Items.AddRange([ "Hashを選択してください", ..HashCalculate.GetHashTypeNames() ]);
            HashSelecter.Location = new System.Drawing.Point(14, 164);
            HashSelecter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HashSelecter.Name = "HashSelecter";
            HashSelecter.Size = new System.Drawing.Size(222, 33);
            HashSelecter.TabIndex = 4;
            HashSelecter.Text = "Hashを選択してください";
            HashSelecter.SelectedIndexChanged += HashSelecter_Set;
            HashSelecter.TextChanged += HashSelecter_Set;
            // 
            // HashOutputBox
            // 
            HashOutputBox.BackColor = System.Drawing.SystemColors.Window;
            HashOutputBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            HashOutputBox.Location = new System.Drawing.Point(14, 209);
            HashOutputBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HashOutputBox.Multiline = true;
            HashOutputBox.Name = "HashOutputBox";
            HashOutputBox.ReadOnly = true;
            HashOutputBox.Size = new System.Drawing.Size(865, 77);
            HashOutputBox.TabIndex = 5;
            HashOutputBox.Text = "ここにHash値が表示されます";
            // 
            // HashFileURL
            // 
            HashFileURL.BackColor = System.Drawing.SystemColors.Window;
            HashFileURL.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            HashFileURL.Location = new System.Drawing.Point(14, 91);
            HashFileURL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HashFileURL.Multiline = true;
            HashFileURL.Name = "HashFileURL";
            HashFileURL.ReadOnly = true;
            HashFileURL.Size = new System.Drawing.Size(865, 61);
            HashFileURL.TabIndex = 6;
            HashFileURL.Text = "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)";
            // 
            // HashReset
            // 
            HashReset.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            HashReset.ForeColor = System.Drawing.Color.Red;
            HashReset.Location = new System.Drawing.Point(696, 164);
            HashReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HashReset.Name = "HashReset";
            HashReset.Size = new System.Drawing.Size(183, 33);
            HashReset.TabIndex = 7;
            HashReset.Text = "Hashをリセット";
            HashReset.UseVisualStyleBackColor = true;
            HashReset.Click += HashReset_Click;
            // 
            // HashCopy
            // 
            HashCopy.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            HashCopy.Location = new System.Drawing.Point(489, 164);
            HashCopy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HashCopy.Name = "HashCopy";
            HashCopy.Size = new System.Drawing.Size(197, 33);
            HashCopy.TabIndex = 8;
            HashCopy.Text = "Hashをコピー";
            HashCopy.UseVisualStyleBackColor = true;
            HashCopy.Click += HashCopy_Click;
            // 
            // CreatedBy
            // 
            CreatedBy.AutoSize = true;
            CreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            CreatedBy.Location = new System.Drawing.Point(689, 9);
            CreatedBy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            CreatedBy.Name = "CreatedBy";
            CreatedBy.Size = new System.Drawing.Size(190, 25);
            CreatedBy.TabIndex = 9;
            CreatedBy.Text = "CreatedBy: Hibi_10000";
            // 
            // DL
            // 
            DL.AutoSize = true;
            DL.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            DL.Location = new System.Drawing.Point(776, 34);
            DL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            DL.Name = "DL";
            DL.Size = new System.Drawing.Size(42, 25);
            DL.TabIndex = 10;
            DL.Text = "DL :";
            // 
            // DLGithub
            // 
            DLGithub.AutoSize = true;
            DLGithub.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            DLGithub.Location = new System.Drawing.Point(814, 34);
            DLGithub.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            DLGithub.Name = "DLGithub";
            DLGithub.Size = new System.Drawing.Size(65, 25);
            DLGithub.TabIndex = 11;
            DLGithub.TabStop = true;
            DLGithub.Text = "GitHub";
            DLGithub.LinkClicked += DLGithub_LinkClicked;
            // 
            // StartHash
            // 
            StartHash.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            StartHash.Location = new System.Drawing.Point(489, 298);
            StartHash.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            StartHash.Name = "StartHash";
            StartHash.Size = new System.Drawing.Size(232, 47);
            StartHash.TabIndex = 12;
            StartHash.Text = "Hash計算機を起動";
            StartHash.UseVisualStyleBackColor = true;
            StartHash.Click += StartHash_Click;
            // 
            // DebugUse
            // 
            DebugUse.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            DebugUse.Location = new System.Drawing.Point(354, 297);
            DebugUse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            DebugUse.Name = "DebugUse";
            DebugUse.Size = new System.Drawing.Size(125, 48);
            DebugUse.TabIndex = 13;
            DebugUse.Text = "DebugUse";
            DebugUse.UseVisualStyleBackColor = true;
            DebugUse.Visible = false;
            DebugUse.Click += DebugUse_Click;
            // 
            // UpperCheck
            // 
            UpperCheck.AutoSize = true;
            UpperCheck.Location = new System.Drawing.Point(246, 166);
            UpperCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            UpperCheck.Name = "UpperCheck";
            UpperCheck.Size = new System.Drawing.Size(92, 29);
            UpperCheck.TabIndex = 14;
            UpperCheck.Text = "大文字";
            UpperCheck.UseVisualStyleBackColor = true;
            UpperCheck.CheckedChanged += HashSelecter_Set;
            // 
            // HihunCheck
            // 
            HihunCheck.AutoSize = true;
            HihunCheck.Location = new System.Drawing.Point(348, 166);
            HihunCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            HihunCheck.Name = "HihunCheck";
            HihunCheck.Size = new System.Drawing.Size(90, 29);
            HihunCheck.TabIndex = 15;
            HihunCheck.Text = "ハイフン";
            HihunCheck.UseVisualStyleBackColor = true;
            HihunCheck.CheckedChanged += HashSelecter_Set;
            // 
            // HashForContext
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(893, 354);
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
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "HashForContext";
            Text = "Hash for ContextMenu";
            Load += HashForContext_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox HashSelecter;
        private System.Windows.Forms.TextBox HashOutputBox;
        private System.Windows.Forms.TextBox HashFileURL;
        private System.Windows.Forms.Button HashReset;
        private System.Windows.Forms.Button HashCopy;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Label DL;
        private System.Windows.Forms.LinkLabel DLGithub;
        private System.Windows.Forms.Button StartHash;
        private System.Windows.Forms.Button DebugUse;
        private System.Windows.Forms.OpenFileDialog DebugUseDialog;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox HihunCheck;
    }
}
