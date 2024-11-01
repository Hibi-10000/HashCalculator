// Copyright © 2021-2024 Hibi_10000
// 
// This file is part of HashCalculator program.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using Hash.Core;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Hash.App;

internal partial class HashCalculator : Form
{
    //[DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
    //public static extern bool ShouldSystemUseDarkMode();

    public HashCalculator(bool multiInstance)
    {
        InitializeComponent();
        if (multiInstance)
        {
            HashForContextEnable.Enabled = false;
            HashForContextEnable.Text += " (最初のインスタンスでのみ変更できます)";
        }
    }

    private void Hash_Load(object sender, EventArgs e)
    {
        string[] args = Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "/f":
                    //File (/f "{FileURL}")
                    int urlNum = i + 1;
                    HashFileURL.Text = args[urlNum];
                    break;
                case "/h":
                    //HashType (/h MD5)
                    int hashTypeNum = i + 1;
                    HashSelector.Text = args[hashTypeNum];
                    break;
                case "/d":
                    //Debug (/d)
                    //HashFileURL.ReadOnly = false;
                    break;
            }
        }

        //(ShouldSystemUseDarkMode() ? (Action)setDarkMode : setLightMode)();

        const string regPath = @"*\shell\HashForContext";
        try {
            using RegistryKey? regKey = Registry.ClassesRoot.OpenSubKey(regPath);
            HashForContextEnable.Checked = regKey != null;
        } catch (Exception) {
            HashForContextEnable.Checked = false;
        }

        Text = $"HashCalculator v{Program.SemVer}{Program.Ch}";
        hashAndVer.Text = $"HashCalculator v{Program.SemVer}";
        HashVer.Text = $"HashCalculator v{Program.SemVer}{Program.Ch}";
        CopyRight.Text = $"Copyright © 2021-{DateTime.Now.Year} Hibi_10000";
    }

    private void DLLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Program.OpenLink("https://github.com/Hibi-10000/HashCalculator/releases/");
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
        HashSelector_Set(sender, e);
    }

    /*
    private void SelectFolderButton_Click(object sender, EventArgs e)
    {
        FileFolderURLBox.Text = null;
        using CommonOpenFileDialog cofd = new CommonOpenFileDialog()
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
        HashSelector.Text = "②Hashを選択";
    }

    private void HashCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(HashOutputBox.Text);
        HashOutputBox.Focus();
        HashOutputBox.SelectAll();
    }

    private void HashSelector_Set(object sender, EventArgs e)
    {
        if (HashFileURL.Text == "ファイルのパス" || HashFileURL.Text == "") {
            HashOutputBox.Text = "ここにHash値が表示されます";
        } else {
            string hashType = HashSelector.Text;
            string filePath = HashFileURL.Text;
            bool upper = checkUpper.Checked;
            bool hyphen = checkHyphen.Checked;
            string hash = HashCalculate.GetHash(hashType, filePath, upper, hyphen) ?? "ここにHash値が表示されます";
            HashOutputBox.Text = hash;
        }
    }

    private void compare1copy_Click(object sender, EventArgs e)
    {
        compare1hash.Text = HashOutputBox.Text;
        compare1hashType.Text = HashSelector.Text;
    }

    private void compare2copy_Click(object sender, EventArgs e)
    {
        compare2hash.Text = HashOutputBox.Text;
        compare2hashType.Text = HashSelector.Text;
    }

    private void compareExecButton_Click(object sender, EventArgs e)
    {
        if (compare1hash.Text == compare2hash.Text)
        {
            compareResult.Text = "比較 : 真";
        }
        else
        {
            compareResult.Text = "比較 : 偽";
        }
    }

    private void compareReset_Click(object sender, EventArgs e)
    {
        compareResult.Text = "比較 : 結果";
        compare1hashType.Text = "比較①";
        compare1hash.Text = "";
        compare2hashType.Text = "比較②";
        compare2hash.Text = "";
    }

    private void paste1cb_Click(object sender, EventArgs e)
    {
        compare1hash.Text = Clipboard.GetText();
    }

    private void paste2cb_Click(object sender, EventArgs e)
    {
        compare2hash.Text = Clipboard.GetText();
    }

    private void menuFIleExit_Click(object sender, EventArgs e)
    {
        Environment.ExitCode = 0;
        Application.Exit();
    }

    private void menuHelpVer_Click(object sender, EventArgs e)
    {
        AboutBox aboutBox = new AboutBox();
        aboutBox.ShowDialog();
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
                ProcessStartInfo startInfo = new ProcessStartInfo(Application.ExecutablePath)
                {
                    UseShellExecute = true,
                    Verb = "runas",
                    Arguments = HashForContextEnable.Checked ? "/rc" : "/rd"
                };
                Process? process = Process.Start(startInfo);
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
        this.hashAndVer.ForeColor = Color.Lime;
        this.hashAndVer.BackColor = SystemColors.Window;
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
        this.hashAndVer.ForeColor = Color.Lime;
        this.hashAndVer.BackColor = SystemColors.ControlDarkDark;
        this.TabHash.BackColor = SystemColors.ControlDarkDark;
        this.TabHash.ForeColor = SystemColors.ControlLightLight;
        this.HashFileURL.BackColor = SystemColors.ControlDark;
        this.HashFileURL.ForeColor = SystemColors.Window;
        this.DropPanel.BackColor = SystemColors.ControlDark;
        this.DropPanel.ForeColor = SystemColors.Window;
    }*/
}
