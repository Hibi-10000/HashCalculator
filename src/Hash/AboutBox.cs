using System;
using System.Windows.Forms;

namespace Hash
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void dlgithub_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/HashCalculator/releases/")
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void noticelink_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/HashCalculator/blob/v0.6.0/NOTICE.md")
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            hashandver.Text = $"HashCalculator v{HashCalculator.Major}.{HashCalculator.Minor}.{HashCalculator.Build}";
            Version.Text = $"Version: v{HashCalculator.Major}.{HashCalculator.Minor}.{HashCalculator.Build}{HashCalculator.Ch}";
            Copyright.Text = $"Copyright © 2021-{DateTime.Now.Year} Hibi_10000";
        }
    }
}
