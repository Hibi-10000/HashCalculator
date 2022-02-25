using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Hash
{
    public partial class HashCalculator : Form
    {

        public static string Major = "0";
        public static string Minor = "5";
        public static string Build = "1-alpha";

        public HashCalculator()
        {
            InitializeComponent();
        }

        private void Hash_Load(object sender, EventArgs e)
        {
            string[] Commands = Environment.GetCommandLineArgs();
            for (int i = 0; i < Commands.Length; i++) {
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
                    //HashFileURL.ReadOnly = false;
                }
            }

            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
            String regPath = @"*\shell\HashForContext";
            RegistryKey regKey = null;
            try {
                regKey = root.OpenSubKey(regPath);
                if (regKey != null) {
                    HashForContextEnable.Checked = true;
                } else {
                    HashForContextEnable.Checked = false;
                }
            }
            catch (Exception) { HashForContextEnable.Checked = false; }
            finally { if (regKey != null) { regKey.Close(); } }

            Text = "HashCalculator v" + Major + "." + Minor + "." + Build;
            hashandver.Text = "HashCalculator v" + Major + "." + Minor;
            HashVer.Text = "HashCalculator v" + Major + "." + Minor + "." + Build;
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
            HashFileURL.Text = null;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i];
                HashFileURL.Text += fileName;
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
                HashFileURL.Text = null;
                HashFileURL.Text = SelectFileDialog.FileName;
            }
            HashSelecter_Set(sender, e);
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
            HashOutputBox.Text = "ここにHash値が表示されます";
            HashFileURL.Text = "ファイルのパス";
            HashSelecter.Text = "②Hashを選択";
        }

        private void HashCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashOutputBox.Text);
            HashOutputBox.Focus();
            HashOutputBox.SelectAll();
        }

        private void HashSelecter_Set(object sender, EventArgs e)
        {
            if (HashFileURL.Text == "ファイルのパス" || HashFileURL.Text == "") {
                HashOutputBox.Text = "ここにHash値が表示されます";
            } else {
                string filePath = HashFileURL.Text;
                switch (HashSelecter.Text) {
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
            }
        }

        private void hikaku1copy_Click(object sender, EventArgs e)
        {
            hikaku1hash.Text = HashOutputBox.Text;
            hikaku1hashtype.Text = HashSelecter.Text;
        }

        private void hikaku2copy_Click(object sender, EventArgs e)
        {
            hikaku2hash.Text = HashOutputBox.Text;
            hikaku2hashtype.Text = HashSelecter.Text;
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
            Tab.SelectedIndex = 2;
        }

        private void menuFileSettings_Click(object sender, EventArgs e)
        {
            Tab.SelectedIndex = 3;
        }

        private void HashForContextEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (Tab.SelectedIndex == 3)
            {
                if (HashForContextEnable.Checked == false)
                {
                    var startInfo = new System.Diagnostics.ProcessStartInfo(Application.ExecutablePath);
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

                    //var startInfo = new System.Diagnostics.ProcessStartInfo("C:\\Program Files\\HashCalculator\\Hash.exe");
                    var startInfo = new System.Diagnostics.ProcessStartInfo(Application.ExecutablePath);
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
}
