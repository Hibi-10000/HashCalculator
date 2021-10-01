using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashForContext
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
                    int urlno = i + 1;
                    HashFileURL.Text = Commands[urlno];
                }
                else if (Commands[i] == "/d")
                {
                    DebugUse.Visible = true;
                    HashFileURL.ReadOnly = false;
                }
                else if (Commands[i] == "/n")
                {
                    StartHash.Visible = false;
                }
                else if (Commands[i] == "/h")
                {
                    int hashtypeno = i + 1;
                    HashSelect.Text = Commands[hashtypeno];
                }
            }
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
            if (HashFileURL.Text == "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)")
            {
                goto switchend;
            }
            string filePath = HashFileURL.Text;
            HashTextBox.Text = null;
            switch (HashSelect.SelectedIndex)
            {
                case 1:
                    HashTextBox.Text = GetHashMD5(filePath);
                    goto switchend;
                case 2:
                    HashTextBox.Text = GetHashSHA1(filePath);
                    goto switchend;
                case 3:
                    HashTextBox.Text = GetHashSHA256(filePath);
                    goto switchend;
                case 4:
                    HashTextBox.Text = GetHashSHA384(filePath);
                    goto switchend;
                case 5:
                    HashTextBox.Text = GetHashSHA512(filePath);
                    goto switchend;
                default:
                    HashTextBox.Text = "ここにHash値が表示されます";
                    goto switchend;
            }
        switchend:;
        }
        public static string GetHashMD5(string filePath)
        {
            HashAlgorithm hashProvider = new MD5CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashSHA1(string filePath)
        {
            HashAlgorithm hashProvider = new SHA1CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashSHA256(string filePath)
        {
            HashAlgorithm hashProvider = new SHA256CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashSHA384(string filePath)
        {
            HashAlgorithm hashProvider = new SHA384CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashSHA512(string filePath)
        {
            HashAlgorithm hashProvider = new SHA512CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }

        private void StartHash_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("C:\\Program Files\\HashCalculator\\Hash.exe");
            startInfo.UseShellExecute = true;
            if (File.Exists("C:\\Program Files\\HashCalculator\\Hash.exe"))
            {
                System.Diagnostics.Process.Start(startInfo);
            }
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
