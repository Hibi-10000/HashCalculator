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
using Hash.Core;

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
                    Debug.Visibility = Visibility.Visible;
                    HashFileURL.IsReadOnly = false;
                    break;
            }
        }

        Title = $"Hash for ContextMenu v{App.SemVer}{App.Ch}";
        hashAndVer.Content = $"Hash for ContextMenu v{App.SemVer}";
        CopyRight.Content = $"Copyright © 2021-{DateTime.Now.Year} Hibi__10000";
        foreach (string hashTypeName in HashCalculate.GetHashTypeNames())
        {
            HashSelector.Items.Add(new ComboBoxItem { Content = hashTypeName });
        }
    }
}

