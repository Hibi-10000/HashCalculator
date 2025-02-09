// Copyright © 2021-2025 Hibi_10000
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
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace Hash.Wpf.Strings;

public class LangManager
{
    private static LangManager? _instance;
    //public static LangManager Instance { get { return _instance ??= new LangManager(); } }
    public static void Init() => _instance ??= new LangManager();

    private static readonly ImmutableList<string> ResourceExistLangs = ImmutableList.Create("ja", "en");

    //private readonly ResourceDictionary _langResource;
    //private string _currentCultureCode;

    private LangManager()
    {
        //SystemEvents.UserPreferenceChanged += OnCulturePreferenceChanged;
        var _currentCultureCode = GetCurrentCulture();
        var appResources = Application.Current.Resources.MergedDictionaries;
        var _langResource = appResources.First(rd => rd.Source.Equals(GetLangResourceUri("ja")));
        if (_currentCultureCode is not "ja") _langResource.Source = GetLangResourceUri(_currentCultureCode);
    }

    //private void OnCulturePreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
    //{
    //    if (e.Category != UserPreferenceCategory.Locale) return;
    //    var newCultureCode = GetCurrentCulture();
    //    if (newCultureCode == _currentCultureCode) return;
    //    UpdateCulture(newCultureCode);
    //}

    //private void UpdateCulture(string newCultureCode)
    //{
    //    _langResource.Source = GetLangResourceUri(newCultureCode);
    //    _currentCultureCode = newCultureCode;
    //}

    private static string GetCurrentCulture()
    {
        CultureInfo.CurrentUICulture.ClearCachedData();
        return CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
    }

    private static Uri GetLangResourceUri(string langCode)
    {
        if (!ResourceExistLangs.Contains(langCode)) langCode = "en";
        return new Uri($"/Strings/Lang/Resource.{langCode}.xaml", UriKind.Relative);
    }
}
