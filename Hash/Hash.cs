using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Hash
{
    public partial class Hash : Form
    {

        public static string Major = "β0";
        public static string Minor = "3";
        public static string Build = "0";

        public Hash()
        {
            InitializeComponent();
        }

        private void Hash_Load(object sender, EventArgs e)
        {
            string[] Commands = System.Environment.GetCommandLineArgs();
            for (int i = 0; i < Commands.Length; i++) {

            }

            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
            String regPath = @"*\shell\HashForContext";
            RegistryKey regKey = null;
            try
            {
                regKey = root.OpenSubKey(regPath);
                if (regKey != null)
                {
                    HashForContextEnable.Checked = true;
                }
                else
                {
                    HashForContextEnable.Checked = false;
                }
            }
            catch (Exception) { HashForContextEnable.Checked = false; }
            finally { if (regKey != null) { regKey.Close(); } }

            Text = "HashCalculator Ver." + Major + "." + Minor + "." + Build;
            hashandver.Text = "HashCalculator Ver." + Major + "." + Minor;
            HashVer.Text = "HashCalculator Ver." + Major + "." + Minor + "." + Build;
            CopyRight.Text = "Copyright © " + DateTime.Now.Year.ToString() + " Hibi_10000 All rights reserved.";
        }

        private void DLLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/Hash-Calculator/releases/");
            startInfo.UseShellExecute = true;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void DropPanel_DragDrop(object sender, DragEventArgs e)
        {
            FileFolderURLBox.Text = null;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i];
                FileFolderURLBox.Text += fileName;
            }
        }

        private void DropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = SelectFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                FileFolderURLBox.Text = null;
                FileFolderURLBox.Text = SelectFileDialog.FileName;
            }
        }

        /*
        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            FileFolderURLBox.Text = null;
            using (var cofd = new CommonOpenFileDialog()
            {
                Title = "フォルダを選択してください",
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                IsFolderPicker = true,
            })
            {
                if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }
                FileFolderURLBox.Text = $"{cofd.FileName}";
            }
        }
        */

        private void AllReset_Click(object sender, EventArgs e)
        {
            HashABox.Text = "ここにHash値が表示されます";
            FileFolderURLBox.Text = "ファイルのパス";
            HashSelectBox.Text = "②Hashを選択";
        }

        private void HashCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashABox.Text);
            HashABox.Focus();
            HashABox.SelectAll();
        }

        private void HashSelectBox_Set(object sender, EventArgs e)
        {
            if (FileFolderURLBox.Text == "ファイルのパス")
            {
                HashABox.Text = "ここにHash値が表示されます";
                goto switchend;
            }
            string filePath = FileFolderURLBox.Text;
            HashABox.Text = null;
            switch (HashSelectBox.SelectedIndex)
            {
                case 1:
                    HashABox.Text = GetHashMD5(filePath);
                    goto switchend;
                case 2:
                    HashABox.Text = GetHashSHA1(filePath);
                    goto switchend;
                case 3:
                    HashABox.Text = GetHashSHA256(filePath);
                    goto switchend;
                case 4:
                    HashABox.Text = GetHashSHA384(filePath);
                    goto switchend;
                case 5:
                    HashABox.Text = GetHashSHA512(filePath);
                    goto switchend;
                default:
                    HashABox.Text = "ここにHash値が表示されます";
                    goto switchend;
            }
        switchend:;

        }

        public static string GetHashSHA256(string filePath)
        {
            HashAlgorithm hashProvider = new SHA256CryptoServiceProvider();
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
        public static string GetHashMD5(string filePath)
        {
            HashAlgorithm hashProvider = new MD5CryptoServiceProvider();
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

        private void hikaku1copy_Click(object sender, EventArgs e)
        {
            hikaku1hash.Text = HashABox.Text;
            hikaku1hashtype.Text = HashSelectBox.Text;
        }

        private void hikaku2copy_Click(object sender, EventArgs e)
        {
            hikaku2hash.Text = HashABox.Text;
            hikaku2hashtype.Text = HashSelectBox.Text;
        }

        private void hikakub_Click(object sender, EventArgs e)
        {
            if (hikaku1hash.Text == hikaku2hash.Text)
            {
                hikakukekka.Text = "比較 : 真";
            }
            else
            {
                hikakukekka.Text = "比較 : 偽";
            }
        }

        private void hikakureset_Click(object sender, EventArgs e)
        {
            hikakukekka.Text = "比較 : 結果";
            hikaku1hashtype.Text = "比較①";
            hikaku1hash.Text = "";
            hikaku2hashtype.Text = "比較②";
            hikaku2hash.Text = "";
        }

        private void paste1cb_Click(object sender, EventArgs e)
        {
            hikaku1hash.Text = Clipboard.GetText();
        }

        private void paste2cb_Click(object sender, EventArgs e)
        {
            hikaku2hash.Text = Clipboard.GetText();
        }

        private void menuFIleExit_Click(object sender, EventArgs e)
        {
            Environment.ExitCode = 0;
            Application.Exit();
        }

        private void menuHelpVer_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        private void menuHelpReadme_Click(object sender, EventArgs e)
        {
            Tab.SelectedIndex = 3;
        }

        private void menuFileSettings_Click(object sender, EventArgs e)
        {
            Tab.SelectedIndex = 4;
        }

        private void HashForContextEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (HashForContextEnable.Checked == false)
            {
                var startInfo = new System.Diagnostics.ProcessStartInfo("C:\\Program Files\\HashCalculator\\Hash.exe");
                startInfo.UseShellExecute = true;
                startInfo.Verb = "runas";
                startInfo.Arguments = "/rd";
                if (File.Exists("C:\\Program Files\\HashCalculator\\Hash.exe"))
                {
                    System.Diagnostics.Process.Start(startInfo);
                }
                else
                {
                    HashForContextEnable.Checked = true;
                }
            }
            else
            {
                var startInfo = new System.Diagnostics.ProcessStartInfo("C:\\Program Files\\HashCalculator\\Hash.exe");
                startInfo.UseShellExecute = true;
                startInfo.Verb = "runas";
                startInfo.Arguments = "/rc";
                if (File.Exists("C:\\Program Files\\HashCalculator\\Hash.exe"))
                {
                    System.Diagnostics.Process.Start(startInfo);
                }
                else
                {
                    HashForContextEnable.Checked = false;
                }
            }
        }
    }
}
