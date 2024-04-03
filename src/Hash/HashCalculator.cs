using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Hash
{
    public partial class HashCalculator : Form
    {

        public const string Major = "0";
        public const string Minor = "5";
        public const string Build = "4";
        public const string Ch = "";

        //[DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        //public static extern bool ShouldSystemUseDarkMode();

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

            //(ShouldSystemUseDarkMode() ? (Action)setDarkMode : setLightMode)();

            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
            string regPath = @"*\shell\HashForContext";
            try {
                using RegistryKey? regKey = root.OpenSubKey(regPath);
                HashForContextEnable.Checked = regKey != null;
            } catch (Exception) {
                HashForContextEnable.Checked = false;
            }

            Text = "HashCalculator v" + Major + "." + Minor + "." + Build + Ch;
            hashandver.Text = "HashCalculator v" + Major + "." + Minor + "." + Build;
            HashVer.Text = "HashCalculator v" + Major + "." + Minor + "." + Build + Ch;
            CopyRight.Text = "Copyright © 2021-" + DateTime.Now.Year.ToString() + " Hibi_10000";
        }

        private void DLLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/HashCalculator/releases/")
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void DropPanel_DragDrop(object sender, DragEventArgs e)
        {
            HashFileURL.Text = null;
            string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop, false);
            foreach (string file in files ?? []) {
                HashFileURL.Text += file;
            }
        }

        private void DropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)
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
            if (dr == DialogResult.OK)
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
            using var cofd = new CommonOpenFileDialog()
            {
                Title = "フォルダを選択してください",
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                IsFolderPicker = true,
            };
            if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            FileFolderURLBox.Text = $"{cofd.FileName}";
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
                string hashType = HashSelecter.Text;
                string filePath = HashFileURL.Text;
                bool upper = UpperCheck.Checked;
                bool hihun = HihunCheck.Checked;
                string hash = HashCalculate.GetHash(hashType, filePath, upper, hihun) ?? "ここにHash値が表示されます";
                HashOutputBox.Text = hash;
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
                if (File.Exists(Application.ExecutablePath))
                {
                    //var startInfo = new System.Diagnostics.ProcessStartInfo(@"C:\Program Files\HashCalculator\Hash.exe");
                    var startInfo = new System.Diagnostics.ProcessStartInfo(Application.ExecutablePath)
                    {
                        UseShellExecute = true,
                        Verb = "runas",
                        Arguments = HashForContextEnable.Checked ? "/rc" : "/rd"
                    };
                    var process = System.Diagnostics.Process.Start(startInfo);
                    process?.WaitForExit();
                    if (process?.ExitCode is not 0) {
                        HashForContextEnable.Checked = HashForContextEnable.Checked is false;
                    }
                }
                else
                {
                    HashForContextEnable.Checked = HashForContextEnable.Checked is false;
                }
            }
        }

        /*
        private void setLightMode()
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;
            this.richTextBox1.BackColor = SystemColors.Control;
            this.hashandver.ForeColor = Color.Lime;
            this.hashandver.BackColor = SystemColors.Window;
            this.TabHash.BackColor = SystemColors.Window;
            this.TabHash.ForeColor = SystemColors.ControlText;
            this.HashFileURL.BackColor = SystemColors.Control;
            this.HashFileURL.ForeColor = SystemColors.WindowText;
            this.DropPanel.BackColor = SystemColors.Window;
            this.DropPanel.ForeColor = SystemColors.ControlText;
        }

        private void setDarkMode()
        {
            this.BackColor = SystemColors.ControlDark;
            this.ForeColor = SystemColors.ControlLightLight;
            this.richTextBox1.BackColor = SystemColors.ControlDark;
            this.hashandver.ForeColor = Color.Lime;
            this.hashandver.BackColor = SystemColors.ControlDarkDark;
            this.TabHash.BackColor = SystemColors.ControlDarkDark;
            this.TabHash.ForeColor = SystemColors.ControlLightLight;
            this.HashFileURL.BackColor = SystemColors.ControlDark;
            this.HashFileURL.ForeColor = SystemColors.Window;
            this.DropPanel.BackColor = SystemColors.ControlDark;
            this.DropPanel.ForeColor = SystemColors.Window;
        }*/
    }
}
