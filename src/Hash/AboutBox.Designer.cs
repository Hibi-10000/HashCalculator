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
            hashandver = new Label();
            Version = new Label();
            Copyright = new Label();
            Created = new Label();
            dl = new Label();
            dlgithub = new LinkLabel();
            licenselink = new LinkLabel();
            noticelink = new LinkLabel();
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
            // hashandver
            // 
            hashandver.AutoSize = true;
            hashandver.BackColor = SystemColors.Window;
            hashandver.BorderStyle = BorderStyle.FixedSingle;
            hashandver.Font = new Font("Yu Gothic UI", 25F);
            hashandver.ForeColor = Color.Lime;
            hashandver.ImeMode = ImeMode.NoControl;
            hashandver.Location = new Point(18, 17);
            hashandver.Name = "hashandver";
            hashandver.Size = new Size(360, 69);
            hashandver.TabIndex = 25;
            hashandver.Text = "HashCalculator";
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Font = new Font("Yu Gothic UI", 9F);
            Version.Location = new Point(20, 139);
            Version.Margin = new Padding(5, 0, 5, 0);
            Version.Name = "Version";
            Version.Size = new Size(79, 25);
            Version.TabIndex = 27;
            Version.Text = "Version: ";
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Font = new Font("Yu Gothic UI", 9F);
            Copyright.Location = new Point(20, 240);
            Copyright.Margin = new Padding(5, 0, 5, 0);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(352, 25);
            Copyright.TabIndex = 28;
            Copyright.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // Created
            // 
            Created.AutoSize = true;
            Created.Font = new Font("Yu Gothic UI", 9F);
            Created.Location = new Point(20, 104);
            Created.Margin = new Padding(5, 0, 5, 0);
            Created.Name = "Created";
            Created.Size = new Size(190, 25);
            Created.TabIndex = 29;
            Created.Text = "CreatedBy: Hibi_10000";
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
            // dlgithub
            // 
            dlgithub.AutoSize = true;
            dlgithub.Font = new Font("Yu Gothic UI", 9F);
            dlgithub.Location = new Point(58, 174);
            dlgithub.Margin = new Padding(5, 0, 5, 0);
            dlgithub.Name = "dlgithub";
            dlgithub.Size = new Size(65, 25);
            dlgithub.TabIndex = 31;
            dlgithub.TabStop = true;
            dlgithub.Text = "GitHub";
            dlgithub.Click += dlgithub_Click;
            //
            // licenselink
            //
            licenselink.AutoSize = true;
            licenselink.Font = new Font("Yu Gothic UI", 9F);
            licenselink.Location = new Point(20, 205);
            licenselink.Margin = new Padding(5, 0, 5, 0);
            licenselink.Name = "licenselink";
            licenselink.TabIndex = 32;
            licenselink.TabStop = true;
            licenselink.Text = "ライセンス";
            licenselink.Click += licenselink_Click;
            //
            // noticelink
            //
            noticelink.AutoSize = true;
            noticelink.Font = new Font("Yu Gothic UI", 9F);
            noticelink.Location = new Point(120, 205);
            noticelink.Margin = new Padding(5, 0, 5, 0);
            noticelink.Name = "noticelink";
            noticelink.Size = new Size(352, 25);
            noticelink.TabIndex = 32;
            noticelink.TabStop = true;
            noticelink.Text = "サードパーティーライセンス";
            noticelink.Click += noticelink_Click;
            // 
            // AboutBox
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 285);
            Controls.Add(noticelink);
            Controls.Add(licenselink);
            Controls.Add(dlgithub);
            Controls.Add(dl);
            Controls.Add(Created);
            Controls.Add(Copyright);
            Controls.Add(Version);
            Controls.Add(hashandver);
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
        private Label hashandver;
        private Label Version;
        private Label Copyright;
        private new Label Created;
        private Label dl;
        private LinkLabel dlgithub;
        private LinkLabel licenselink;
        private LinkLabel noticelink;
    }
}
