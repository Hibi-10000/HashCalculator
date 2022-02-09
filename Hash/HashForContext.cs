using System;
using System.Windows.Forms;

namespace Hash
{
    public partial class HashForContext : Form
    {
        public HashForContext()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Environment.ExitCode = 0;
            Application.Exit();
        }

        private void HashForContext_Load(object sender, EventArgs e)
        {
            string[] Commands = System.Environment.GetCommandLineArgs();

            for (int i = 0; i < Commands.Length; i++)
            {
                if (Commands[i] == "/f")
                {
                    //File (/f "{FileURL}")
                    int urlno = i + 1;
                    HashFileURL.Text = Commands[urlno];
                }
                else if (Commands[i] == "/h")
                {
                    //HashType (/h MD5)
                    int hashtypeno = i + 1;
                    HashSelect.Text = Commands[hashtypeno];
                }
                else if (Commands[i] == "/d")
                {
                    //Debug (/d)
                    DebugUse.Visible = true;
                    HashFileURL.ReadOnly = false;
                }
            }

            Text = "Hash for ContextMenu v" + HashCalculator.Major + "." + HashCalculator.Minor + "." + HashCalculator.Build;
            Title.Text = "Hash for ContextMenu v" + HashCalculator.Major + "." + HashCalculator.Minor;
            Copyright.Text = "Copyright © " + DateTime.Now.Year.ToString() + " Hibi_10000 All rights reserved.";
        }

        private void HashReset_Click(object sender, EventArgs e)
        {
            HashTextBox.Text = "ここにHash値が表示されます";
            HashSelect.Text = "Hashを選択してください";
        }

        private void HashCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashSelect.Text);
            Clipboard.SetText(HashTextBox.Text);
            HashTextBox.Focus();
            HashTextBox.SelectAll();
        }

        private void DLGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/Hash-Calculator/releases/");
            startInfo.UseShellExecute = true;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void HashSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HashFileURL.Text != "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)" && HashFileURL.Text != "")
            {
                string filePath = HashFileURL.Text;
                switch (HashSelect.SelectedIndex)
                {
                    case 1:
                        HashTextBox.Text = HashCalculate.GetHashMD5(filePath);
                        break;
                    case 2:
                        HashTextBox.Text = HashCalculate.GetHashSHA1(filePath);
                        break;
                    case 3:
                        HashTextBox.Text = HashCalculate.GetHashSHA256(filePath);
                        break;
                    case 4:
                        HashTextBox.Text = HashCalculate.GetHashSHA384(filePath);
                        break;
                    case 5:
                        HashTextBox.Text = HashCalculate.GetHashSHA512(filePath);
                        break;
                    default:
                        HashTextBox.Text = "ここにHash値が表示されます";
                        break;
                }
            } else {
                HashTextBox.Text = "ここにHash値が表示されます";
            }
        }

        private void StartHash_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            startInfo.UseShellExecute = true;
            string option = "";
            if (HashFileURL.Text != "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)") option = option + "/f " + HashFileURL.Text + " ";
            if (HashSelect.Text != "Hashを選択してください") option = option + "/h " + HashSelect.Text + " ";
            if (DebugUse.Visible == true) option = option + "/d";
            startInfo.Arguments = option;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void DebugUse_Click(object sender, EventArgs e)
        {
            DialogResult dr = DebugUseDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                HashFileURL.Text = null;
                HashFileURL.Text = DebugUseDialog.FileName;
            }
        }
    }
}
