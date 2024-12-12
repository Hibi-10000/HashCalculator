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

using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Hash.Core;
using Microsoft.Win32;

namespace Hash.Wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //[DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
    //public static extern bool ShouldSystemUseDarkMode();

    public MainWindow(bool multiInstance)
    {
        InitializeComponent();
        if (multiInstance)
        {
            HashForContextEnable.IsEnabled = false;
            HashForContextEnableText.Text += " (最初のインスタンスでのみ変更できます)";
        }
    }

    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        string[] args = Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "-f":
                    //File (-f "{FileURL}")
                    int urlNum = i + 1;
                    HashFileURL.Text = args[urlNum];
                    break;
                case "-h":
                    //HashType (-h MD5)
                    int hashTypeNum = i + 1;
                    HashSelector.Text = args[hashTypeNum];
                    break;
                case "-d":
                    //Debug (-d)
                    //HashFileURL.ReadOnly = false;
                    break;
            }
        }

        //(ShouldSystemUseDarkMode() ? (Action)setDarkMode : setLightMode)();

        const string regPath = @"*\shell\HashForContext";
        try {
            using RegistryKey? regKey = Registry.ClassesRoot.OpenSubKey(regPath);
            HashForContextEnable.IsChecked = regKey != null;
        } catch (Exception) {
            HashForContextEnable.IsChecked = false;
        }

        Title = $"HashCalculator {App.SemVer}";
        hashAndVer.Content = $"HashCalculator {App.SemVer}";
        HashVer.Content = $"HashCalculator {App.SemVer}";
        CopyRight.Content = $"Copyright © 2021-{DateTime.Now.Year} Hibi__10000";
        foreach (string hashTypeName in HashCalculate.GetHashTypeNames())
        {
            HashSelector.Items.Add(new ComboBoxItem { Content = hashTypeName });
            compare1hashType.Items.Add(new ComboBoxItem { Content = hashTypeName });
            compare2hashType.Items.Add(new ComboBoxItem { Content = hashTypeName });
        }
    }

    private void HyperLink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        App.OpenLink(e.Uri.AbsoluteUri);
    }

    private void DropPanel_OnDrop(object sender, DragEventArgs e)
    {
        HashFileURL.Text = "";
        string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop, false);
        foreach (string file in files ?? []) {
            HashFileURL.Text += file;
        }
    }

    private void DropPanel_OnDragEnter(object sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)
        {
            e.Effects = DragDropEffects.All;
        }
        else
        {
            e.Effects = DragDropEffects.None;
        }
    }

    private void SelectFileButton_OnClick(object sender, RoutedEventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        if (!(ofd.ShowDialog() ?? false)) return;
        HashFileURL.Text = "";
        HashFileURL.Text = ofd.FileName;
        UpdateHash();
    }

    /*
    private void SelectFolderButton_OnClick(object sender, EventArgs e)
    {
        FileFolderURLBox.Text = "";
        OpenFolderDialog ofd = new OpenFolderDialog()
        {
            Title = "フォルダを選択してください",
            InitialDirectory = @"C:\",
            RestoreDirectory = true,
        };
        if (ofd.ShowDialog() ?? false)
        {
            FileFolderURLBox.Text = $"{ofd.FolderName}";
        }
    }
    */

    private void AllReset_OnClick(object sender, RoutedEventArgs e)
    {
        HashOutputBox.Text = "ここにHash値が表示されます";
        HashFileURL.Text = "ファイルのパス";
        HashSelector.Text = "Hashを選択";
    }

    private void HashCopy_OnClick(object sender, RoutedEventArgs e)
    {
        Clipboard.SetText(HashOutputBox.Text);
        HashOutputBox.Focus();
        HashOutputBox.SelectAll();
    }

    private void HashSelector_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        UpdateHash();
    }

    private void UpdateHash()
    {
        if (HashFileURL.Text is "ファイルのパス" or "") {
            HashOutputBox.Text = "ここにHash値が表示されます";
        } else {
            string hashType = HashSelector.Text;
            string filePath = HashFileURL.Text;
            bool upper = checkUpper.IsChecked ?? false;
            bool hyphen = checkHyphen.IsChecked ?? false;
            string hash = HashCalculate.GetHash(hashType, filePath, upper, hyphen) ?? "ここにHash値が表示されます";
            HashOutputBox.Text = hash;
        }
    }

    private void CheckUpper_OnClick(object sender, RoutedEventArgs e)
    {
        UpdateHash();
    }

    private void CheckHyphen_OnClick(object sender, RoutedEventArgs e)
    {
        UpdateHash();
    }

    private void compare1copy_OnClick(object sender, RoutedEventArgs e)
    {
        compare1hash.Text = HashOutputBox.Text;
        compare1hashType.Text = HashSelector.Text;
    }

    private void compare2copy_OnClick(object sender, RoutedEventArgs e)
    {
        compare2hash.Text = HashOutputBox.Text;
        compare2hashType.Text = HashSelector.Text;
    }

    private void compareExecButton_OnClick(object sender, RoutedEventArgs e)
    {
        compareResult.Content = compare1hash.Text == compare2hash.Text ? "真" : "偽";
    }

    private void compareReset_OnClick(object sender, RoutedEventArgs e)
    {
        compareResult.Content = "結果";
        compare1hashType.Text = "比較①";
        compare1hash.Text = "";
        compare2hashType.Text = "比較②";
        compare2hash.Text = "";
    }

    private void paste1cb_OnClick(object sender, RoutedEventArgs e)
    {
        compare1hash.Text = Clipboard.GetText();
    }

    private void paste2cb_OnClick(object sender, RoutedEventArgs e)
    {
        compare2hash.Text = Clipboard.GetText();
    }

    private void menuFileExit_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void menuHelpVer_OnClick(object sender, RoutedEventArgs e)
    {
        AboutWindow aboutBox = new AboutWindow
        {
            Owner = this,
            ShowInTaskbar = false
        };
        aboutBox.ShowDialog();
    }

    private void menuHelpReadme_OnClick(object sender, RoutedEventArgs e)
    {
        Tab.SelectedIndex = 2;
    }

    private void menuFileSettings_OnClick(object sender, RoutedEventArgs e)
    {
        Tab.SelectedIndex = 3;
    }

    private void HashForContextEnable_OnClick(object sender, RoutedEventArgs e)
    {
        if (Tab.SelectedIndex != 3) return;
        if (File.Exists(Environment.ProcessPath))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Environment.ProcessPath)
            {
                UseShellExecute = true,
                Verb = "runas",
                Arguments = HashForContextEnable.IsChecked ?? false ? "-rc" : "-rd"
            };
            Process? process = Process.Start(startInfo);
            process?.WaitForExit();
            if (process?.ExitCode is not 0) {
                HashForContextEnable.IsChecked = HashForContextEnable.IsChecked is not true;
            }
        }
        else
        {
            HashForContextEnable.IsChecked = HashForContextEnable.IsChecked is not true;
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
