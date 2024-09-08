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

namespace Hash
{
    partial class AboutBox
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
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
            okButton = new Button();
            hashAndVer = new Label();
            version = new Label();
            copyright = new Label();
            createdBy = new Label();
            dl = new Label();
            dlFromGitHub = new LinkLabel();
            licenseLink = new LinkLabel();
            noticeLink = new LinkLabel();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(510, 236);
            okButton.Margin = new Padding(5, 4, 5, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(125, 32);
            okButton.TabIndex = 24;
            okButton.Text = "OK";
            // 
            // hashAndVer
            // 
            hashAndVer.AutoSize = true;
            hashAndVer.BackColor = SystemColors.Window;
            hashAndVer.BorderStyle = BorderStyle.FixedSingle;
            hashAndVer.Font = new Font("Yu Gothic UI", 25F);
            hashAndVer.ForeColor = Color.Lime;
            hashAndVer.ImeMode = ImeMode.NoControl;
            hashAndVer.Location = new Point(18, 17);
            hashAndVer.Name = "hashAndVer";
            hashAndVer.Size = new Size(360, 69);
            hashAndVer.TabIndex = 25;
            hashAndVer.Text = "HashCalculator";
            // 
            // version
            // 
            version.AutoSize = true;
            version.Font = new Font("Yu Gothic UI", 9F);
            version.Location = new Point(20, 139);
            version.Margin = new Padding(5, 0, 5, 0);
            version.Name = "version";
            version.Size = new Size(79, 25);
            version.TabIndex = 27;
            version.Text = "Version: ";
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.Font = new Font("Yu Gothic UI", 9F);
            copyright.Location = new Point(20, 240);
            copyright.Margin = new Padding(5, 0, 5, 0);
            copyright.Name = "copyright";
            copyright.Size = new Size(352, 25);
            copyright.TabIndex = 28;
            copyright.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // createdBy
            // 
            createdBy.AutoSize = true;
            createdBy.Font = new Font("Yu Gothic UI", 9F);
            createdBy.Location = new Point(20, 104);
            createdBy.Margin = new Padding(5, 0, 5, 0);
            createdBy.Name = "createdBy";
            createdBy.Size = new Size(190, 25);
            createdBy.TabIndex = 29;
            createdBy.Text = "CreatedBy: Hibi_10000";
            // 
            // dl
            // 
            dl.AutoSize = true;
            dl.Font = new Font("Yu Gothic UI", 9F);
            dl.Location = new Point(20, 174);
            dl.Margin = new Padding(5, 0, 5, 0);
            dl.Name = "dl";
            dl.Size = new Size(93, 25);
            dl.TabIndex = 30;
            dl.Text = "DL :";
            // 
            // dlFromGitHub
            // 
            dlFromGitHub.AutoSize = true;
            dlFromGitHub.Font = new Font("Yu Gothic UI", 9F);
            dlFromGitHub.Location = new Point(58, 174);
            dlFromGitHub.Margin = new Padding(5, 0, 5, 0);
            dlFromGitHub.Name = "dlFromGitHub";
            dlFromGitHub.Size = new Size(65, 25);
            dlFromGitHub.TabIndex = 31;
            dlFromGitHub.TabStop = true;
            dlFromGitHub.Text = "GitHub";
            dlFromGitHub.Click += dlFromGitHub_Click;
            //
            // licenseLink
            //
            licenseLink.AutoSize = true;
            licenseLink.Font = new Font("Yu Gothic UI", 9F);
            licenseLink.Location = new Point(20, 205);
            licenseLink.Margin = new Padding(5, 0, 5, 0);
            licenseLink.Name = "licenseLink";
            licenseLink.TabIndex = 32;
            licenseLink.TabStop = true;
            licenseLink.Text = "ライセンス";
            licenseLink.Click += licenseLink_Click;
            //
            // noticeLink
            //
            noticeLink.AutoSize = true;
            noticeLink.Font = new Font("Yu Gothic UI", 9F);
            noticeLink.Location = new Point(120, 205);
            noticeLink.Margin = new Padding(5, 0, 5, 0);
            noticeLink.Name = "noticeLink";
            noticeLink.Size = new Size(352, 25);
            noticeLink.TabIndex = 32;
            noticeLink.TabStop = true;
            noticeLink.Text = "サードパーティーライセンス";
            noticeLink.Click += noticeLink_Click;
            // 
            // AboutBox
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 285);
            Controls.Add(noticeLink);
            Controls.Add(licenseLink);
            Controls.Add(dlFromGitHub);
            Controls.Add(dl);
            Controls.Add(createdBy);
            Controls.Add(copyright);
            Controls.Add(version);
            Controls.Add(hashAndVer);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.Icon;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            Padding = new Padding(15, 17, 15, 17);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "HashCalculatorについて";
            Load += AboutBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label hashAndVer;
        private Label version;
        private Label copyright;
        private Label createdBy;
        private Label dl;
        private LinkLabel dlFromGitHub;
        private LinkLabel licenseLink;
        private LinkLabel noticeLink;
    }
}
