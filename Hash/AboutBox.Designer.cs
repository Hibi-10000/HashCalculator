
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.okButton = new System.Windows.Forms.Button();
            this.hashandver = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Created = new System.Windows.Forms.Label();
            this.dl = new System.Windows.Forms.Label();
            this.dlgithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(306, 161);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 22);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            // 
            // hashandver
            // 
            this.hashandver.AutoSize = true;
            this.hashandver.BackColor = System.Drawing.SystemColors.Window;
            this.hashandver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hashandver.Font = new System.Drawing.Font("Yu Gothic UI", 25F);
            this.hashandver.ForeColor = System.Drawing.Color.Lime;
            this.hashandver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hashandver.Location = new System.Drawing.Point(11, 8);
            this.hashandver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hashandver.Name = "hashandver";
            this.hashandver.Size = new System.Drawing.Size(314, 48);
            this.hashandver.TabIndex = 25;
            this.hashandver.Text = "HashCalculator v0.4";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.Version.Location = new System.Drawing.Point(8, 71);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(115, 15);
            this.Version.TabIndex = 27;
            this.Version.Text = "Version: v0.4.0-alpha";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.Copyright.Location = new System.Drawing.Point(8, 161);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(260, 15);
            this.Copyright.TabIndex = 28;
            this.Copyright.Text = "Copyright © 2022 Hibi_10000 All rights reserved.";
            // 
            // Created
            // 
            this.Created.AutoSize = true;
            this.Created.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.Created.Location = new System.Drawing.Point(8, 96);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(123, 15);
            this.Created.TabIndex = 29;
            this.Created.Text = "CreatedBy: Hibi_10000";
            // 
            // dl
            // 
            this.dl.AutoSize = true;
            this.dl.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.dl.Location = new System.Drawing.Point(8, 125);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(58, 15);
            this.dl.TabIndex = 30;
            this.dl.Text = "配布場所:";
            // 
            // dlgithub
            // 
            this.dlgithub.AutoSize = true;
            this.dlgithub.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.dlgithub.Location = new System.Drawing.Point(66, 125);
            this.dlgithub.Name = "dlgithub";
            this.dlgithub.Size = new System.Drawing.Size(43, 15);
            this.dlgithub.TabIndex = 31;
            this.dlgithub.TabStop = true;
            this.dlgithub.Text = "Github";
            this.dlgithub.Click += new System.EventHandler(this.dlgithub_Click);
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 193);
            this.Controls.Add(this.dlgithub);
            this.Controls.Add(this.dl);
            this.Controls.Add(this.Created);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.hashandver);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HashCalculatorについて";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
