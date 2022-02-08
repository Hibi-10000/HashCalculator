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
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/Hash-Calculator/releases/");
            startInfo.UseShellExecute = true;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            hashandver.Text = "HashCalculator Ver." + Hash.Major + "." + Hash.Minor;
            Version.Text = "Version: Ver." + Hash.Major + "." + Hash.Minor + "." + Hash.Build;
            Copyright.Text = "Copyright © " + DateTime.Now.Year.ToString() + " Hibi_10000 All rights reserved.";
        }
    }
}
