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

public partial class HashForContextWindow : Window
{
    public HashForContextWindow()
    {
        InitializeComponent();
    }

    private void OK_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void HashForContextWindow_OnLoaded(object sender, RoutedEventArgs e)
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
                    Debug.Visibility = Visibility.Visible;
                    HashFileURL.IsReadOnly = false;
                    break;
            }
        }

        Title = $"Hash for ContextMenu {App.SemVer}";
        hashAndVer.Content = $"Hash for ContextMenu {App.SemVer}";
        CopyRight.Content = $"Copyright © 2021-{DateTime.Now.Year} Hibi__10000";
        foreach (string hashTypeName in HashCalculate.GetHashTypeNames())
        {
            HashSelector.Items.Add(new ComboBoxItem { Content = hashTypeName });
        }
    }

    private void HashReset_OnClick(object sender, RoutedEventArgs e)
    {
        HashOutputBox.Text = "ここにHash値が表示されます";
        HashSelector.Text = "Hashを選択";
    }

    private void HashCopy_OnClick(object sender, RoutedEventArgs e)
    {
        Clipboard.SetText(HashSelector.Text);
        Clipboard.SetText(HashOutputBox.Text);
        HashOutputBox.Focus();
        HashOutputBox.SelectAll();
    }

    private void HyperLink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        App.OpenLink(e.Uri.AbsoluteUri);
    }

    private void HashSelector_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        UpdateHash();
    }

    private void UpdateHash()
    {
        if (HashFileURL.Text != "ファイルのパス (※これが表示されている場合は起動方法が間違っています)" && HashFileURL.Text != "")
        {
            string hashType = HashSelector.Text;
            string filePath = HashFileURL.Text;
            bool upper = checkUpper.IsChecked ?? false;
            bool hyphen = checkHyphen.IsChecked ?? false;
            string hash = HashCalculate.GetHash(hashType, filePath, upper, hyphen) ?? "ここにHash値が表示されます";
            HashOutputBox.Text = hash;
        } else {
            HashOutputBox.Text = "ここにHash値が表示されます";
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

    private void StartHash_OnClick(object sender, RoutedEventArgs e)
    {
        string option = "";
        if (HashFileURL.Text != "ファイルのパス (※これが表示されている場合は起動方法が間違っています)") option += $"-f \"{HashFileURL.Text}\" ";
        if (HashSelector.Text != "Hashを選択") option += $"-h {HashSelector.Text} ";
        if (Debug.Visibility == Visibility.Visible) option += "-d";
        if (!File.Exists(Environment.ProcessPath)) return;
        ProcessStartInfo startInfo = new ProcessStartInfo(Environment.ProcessPath)
        {
            UseShellExecute = true,
            Arguments = option
        };
        Process.Start(startInfo);
    }

    private void Debug_OnClick(object sender, RoutedEventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        if (!(ofd.ShowDialog() ?? false)) return;
        HashFileURL.Text = "";
        HashFileURL.Text = ofd.FileName;
        UpdateHash();
    }
}

