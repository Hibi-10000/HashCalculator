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
                    HashSelecter.Text = Commands[hashtypeno];
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
            HashOutputBox.Text = "ここにHash値が表示されます";
            HashSelecter.Text = "Hashを選択してください";
        }

        private void HashCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashSelecter.Text);
            Clipboard.SetText(HashOutputBox.Text);
            HashOutputBox.Focus();
            HashOutputBox.SelectAll();
        }

        private void DLGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/Hash-Calculator/releases/");
            startInfo.UseShellExecute = true;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void HashSelecter_Set(object sender, EventArgs e)
        {
            if (HashFileURL.Text != "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)" && HashFileURL.Text != "")
            {
                string filePath = HashFileURL.Text;
                switch (HashSelecter.Text)
                {
                    case "MD5":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.MD5, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "SHA1":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.SHA1, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "SHA256":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.SHA256, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "SHA384":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.SHA384, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "SHA512":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.SHA512, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "CRC16-IBM":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.CRC16_IBM, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "CRC16-CCITT":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.CRC16_CCITT, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "CRC32":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.CRC32, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "CRC64-ECMA-182":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.CRC64_ECMA_182, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "CRC64-ISO":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.CRC64_ISO, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "MACTripleDES":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.MACTripleDES, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    case "RIPEMD160":
                        HashOutputBox.Text = HashCalculate.GetHash(HashCalculate.HashType.RIPEMD160, filePath, UpperCheck.Checked, HihunCheck.Checked);
                        break;
                    default:
                        HashOutputBox.Text = "ここにHash値が表示されます";
                        break;
                }
            } else {
                HashOutputBox.Text = "ここにHash値が表示されます";
            }
        }

        private void StartHash_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            startInfo.UseShellExecute = true;
            string option = "";
            if (HashFileURL.Text != "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)") option = option + "/f \"" + HashFileURL.Text + "\" ";
            if (HashSelecter.Text != "Hashを選択してください") option = option + "/h " + HashSelecter.Text + " ";
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
