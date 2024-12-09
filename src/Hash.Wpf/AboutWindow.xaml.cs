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
using System.Windows.Navigation;

namespace Hash.Wpf;

public partial class AboutWindow : Window
{
    public AboutWindow()
    {
        InitializeComponent();
    }

    private void OK_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void HyperLink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        App.OpenLink(e.Uri.AbsoluteUri.Replace("/blob/main/", $"/blob/v{App.SemVer}/"));
    }

    private void AboutWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        hashAndVer.Content = $"HashCalculator v{App.SemVer}";
        version.Content = $"Version : v{App.SemVer}{App.Ch}";
        copyright.Content = $"Copyright © 2021-{DateTime.Now.Year} Hibi__10000";
    }
}

