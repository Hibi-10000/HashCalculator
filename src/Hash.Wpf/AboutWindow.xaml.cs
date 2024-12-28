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
using Dark.Net;

namespace Hash.Wpf;

public partial class AboutWindow : Window
{
    public AboutWindow()
    {
        InitializeComponent();
        DarkNet.Instance.SetWindowThemeWpf(this, Theme.Auto);
        new Dark.Net.Wpf.SkinManager().RegisterSkins(
            lightThemeResources: new Uri("Themes/ColourDictionaries/LightTheme.xaml", UriKind.Relative),
            darkThemeResources:  new Uri("Themes/ColourDictionaries/SoftDark.xaml", UriKind.Relative)
        );
    }

    private void OK_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void HyperLink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        App.OpenLink(e.Uri.AbsoluteUri);
    }

    private void AboutWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        hashAndVer.Content = $"HashCalculator {App.SemVer}";
        version.Content = $"Version : {App.SemVer}";
        copyright.Text = $"Copyright © 2021-{DateTime.Now.Year} Hibi_10000";
        LinkLicense.NavigateUri = new Uri(LinkLicense.NavigateUri.AbsoluteUri.Replace("/blob/main/", $"/blob/{App.SemVer}/"), UriKind.Absolute);
        LinkNotice .NavigateUri = new Uri(LinkNotice .NavigateUri.AbsoluteUri.Replace("/blob/main/", $"/blob/{App.SemVer}/"), UriKind.Absolute);
    }
}

