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
            HashForContextEnable.IsChecked = regKey != null;
        } catch (Exception) {
            HashForContextEnable.IsChecked = false;
        }

        Title = $"HashCalculator v{App.SemVer}{App.Ch}";
        hashAndVer.Content = $"HashCalculator v{App.SemVer}";
        HashVer.Content = $"HashCalculator v{App.SemVer}{App.Ch}";
        CopyRight.Content = $"Copyright © 2021-{DateTime.Now.Year} Hibi__10000";
    }

    private void DLLink1_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        App.OpenLink("https://github.com/Hibi-10000/HashCalculator/releases/");
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
        if (ofd.ShowDialog() ?? false)
        {
            HashFileURL.Text = "";
            HashFileURL.Text = ofd.FileName;
        }
        HashSelector_OnTextChanged(null, null);
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

    private void HashSelector_OnTextChanged(object? sender, TextChangedEventArgs? e)
    {
        if (HashFileURL.Text == "ファイルのパス" || HashFileURL.Text == "") {
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
}
