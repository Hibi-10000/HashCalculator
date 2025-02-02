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
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Dark.Net;
using Hash.Core;
using Microsoft.Win32;

namespace Hash.Wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(bool multiInstance)
    {
        InitializeComponent();
        DarkNet.Instance.SetWindowThemeWpf(this, Theme.Auto);
        new Dark.Net.Wpf.SkinManager().RegisterSkins(
            lightThemeResources: new Uri("Themes/ColourDictionaries/LightTheme.xaml", UriKind.Relative),
            darkThemeResources:  new Uri("Themes/ColourDictionaries/SoftDark.xaml", UriKind.Relative)
        );
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

        const string regPath = @"*\shell\HashForContext";
        try {
            using RegistryKey? regKey = Registry.ClassesRoot.OpenSubKey(regPath);
            HashForContextEnable.IsChecked = regKey != null;
        } catch (Exception) {
            HashForContextEnable.IsChecked = false;
        }

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
        if (!e.Data.GetFormats().Contains(DataFormats.FileDrop)) return;
        string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop, false);
        if (files == null) return;
        HashFileURL.Text = files[0];
        UpdateHash();
    }

    private void DropPanel_OnDragEnter(object sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.FileDrop, false) ?? false)
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
        HashOutputBox.Text = App.GetString("Lang.Calculator.OutputHash");
        HashFileURL.Text = App.GetString("Lang.Calculator.FilePath");
        HashSelector.Text = App.GetString("Lang.Calculator.SelectHash");
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
        if (HashFileURL.Text == App.GetString("Lang.Calculator.FilePath") || HashSelector.Text == "") {
            HashOutputBox.Text = App.GetString("Lang.Calculator.OutputHash");
        } else {
            string hashType = HashSelector.Text;
            string filePath = HashFileURL.Text;
            bool upper = checkUpperCase.IsChecked ?? false;
            bool hyphen = checkHyphen.IsChecked ?? false;
            string hash = HashCalculate.GetHash(hashType, filePath, upper, hyphen) ?? App.GetString("Lang.Calculator.OutputHash");
            HashOutputBox.Text = hash;
        }
    }

    private void CheckUpperCase_OnClick(object sender, RoutedEventArgs e)
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
        string result = compare1hash.Text == compare2hash.Text ? "True" : "False";
        compareResult.Content = App.GetString($"Lang.Compare.Result.{result}");
    }

    private void compareReset_OnClick(object sender, RoutedEventArgs e)
    {
        compareResult.Content = App.GetString("Lang.Compare.Result");
        compare1hashType.Text = App.GetString("Lang.Compare.One");
        compare1hash.Text = "";
        compare2hashType.Text = App.GetString("Lang.Compare.Two");
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

    private void menuHelpAbout_OnClick(object sender, RoutedEventArgs e)
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
}
