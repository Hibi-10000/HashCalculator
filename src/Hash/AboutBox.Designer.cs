
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
            okButton = new System.Windows.Forms.Button();
            hashandver = new System.Windows.Forms.Label();
            Version = new System.Windows.Forms.Label();
            Copyright = new System.Windows.Forms.Label();
            Created = new System.Windows.Forms.Label();
            dl = new System.Windows.Forms.Label();
            dlgithub = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            okButton.Location = new System.Drawing.Point(510, 206);
            okButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(125, 32);
            okButton.TabIndex = 24;
            okButton.Text = "OK";
            // 
            // hashandver
            // 
            hashandver.AutoSize = true;
            hashandver.BackColor = System.Drawing.SystemColors.Window;
            hashandver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            hashandver.Font = new System.Drawing.Font("Yu Gothic UI", 25F);
            hashandver.ForeColor = System.Drawing.Color.Lime;
            hashandver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            hashandver.Location = new System.Drawing.Point(18, 17);
            hashandver.Name = "hashandver";
            hashandver.Size = new System.Drawing.Size(360, 69);
            hashandver.TabIndex = 25;
            hashandver.Text = "HashCalculator";
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            Version.Location = new System.Drawing.Point(20, 139);
            Version.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Version.Name = "Version";
            Version.Size = new System.Drawing.Size(79, 25);
            Version.TabIndex = 27;
            Version.Text = "Version: ";
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            Copyright.Location = new System.Drawing.Point(20, 210);
            Copyright.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Copyright.Name = "Copyright";
            Copyright.Size = new System.Drawing.Size(352, 25);
            Copyright.TabIndex = 28;
            Copyright.Text = "Copyright © 2021-2024 Hibi_10000";
            // 
            // Created
            // 
            Created.AutoSize = true;
            Created.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            Created.Location = new System.Drawing.Point(20, 104);
            Created.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Created.Name = "Created";
            Created.Size = new System.Drawing.Size(190, 25);
            Created.TabIndex = 29;
            Created.Text = "CreatedBy: Hibi_10000";
            // 
            // dl
            // 
            dl.AutoSize = true;
            dl.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            dl.Location = new System.Drawing.Point(20, 174);
            dl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dl.Name = "dl";
            dl.Size = new System.Drawing.Size(93, 25);
            dl.TabIndex = 30;
            dl.Text = "配布場所 :";
            // 
            // dlgithub
            // 
            dlgithub.AutoSize = true;
            dlgithub.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            dlgithub.Location = new System.Drawing.Point(108, 174);
            dlgithub.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dlgithub.Name = "dlgithub";
            dlgithub.Size = new System.Drawing.Size(65, 25);
            dlgithub.TabIndex = 31;
            dlgithub.TabStop = true;
            dlgithub.Text = "GitHub";
            dlgithub.Click += dlgithub_Click;
            // 
            // AboutBox
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(655, 255);
            Controls.Add(dlgithub);
            Controls.Add(dl);
            Controls.Add(Created);
            Controls.Add(Copyright);
            Controls.Add(Version);
            Controls.Add(hashandver);
            Controls.Add(okButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.Icon;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            Padding = new System.Windows.Forms.Padding(15, 17, 15, 17);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "HashCalculatorについて";
            Load += AboutBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label hashandver;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Copyright;
        private new System.Windows.Forms.Label Created;
        private System.Windows.Forms.Label dl;
        private System.Windows.Forms.LinkLabel dlgithub;
    }
}
