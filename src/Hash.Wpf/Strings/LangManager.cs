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
using System.Globalization;
using System.Windows;

namespace Hash.Wpf.Strings;

public class LangManager
{
    private static LangManager? _instance;
    //public static LangManager Instance { get { return _instance ??= new LangManager(); } }
    public static void Init() => _instance ??= new LangManager();

    private readonly ResourceDictionary _langResource;
    private readonly ResourceDictionary _langEnglishResource = GetLangResourceDictionary("en");
    private string _currentCultureCode = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

    private LangManager()
    {
        //SystemEvents.UserPreferenceChanged += OnCulturePreferenceChanged;
        UpdateCurrentCulture();
        _langResource = GetLangResourceDictionary(_currentCultureCode);
        if (_currentCultureCode is not "ja") SwitchNonJapanese();
    }

    //private void OnCulturePreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
    //{
    //    if (e.Category != UserPreferenceCategory.Locale) return;
    //    var newCultureCode = UpdateCurrentCulture(false);
    //    if (newCultureCode == _currentCultureCode) return;
    //    UpdateCulture(newCultureCode);
    //}

    //private void UpdateCulture(string newCultureCode)
    //{
    //    if (newCultureCode is "ja" && _currentCultureCode is not "ja") SwitchJapanese();
    //    else if (newCultureCode is not "ja" && _currentCultureCode is "ja") SwitchNonJapanese();
    //    _langResource.Source = GetLangResourceUri(newCultureCode);
    //    _currentCultureCode = newCultureCode;
    //}
    //
    //private void SwitchJapanese()
    //{
    //    var appResources = Application.Current.Resources.MergedDictionaries;
    //    appResources.Remove(_langEnglishResource);
    //    appResources.Remove(_langResource);
    //}

    private void SwitchNonJapanese()
    {
        var appResources = Application.Current.Resources.MergedDictionaries;
        appResources.Insert(0, _langEnglishResource);
        appResources.Insert(0, _langResource);
    }

    private string UpdateCurrentCulture(bool updateCurrent = true)
    {
        CultureInfo.CurrentUICulture.ClearCachedData();
        var newCultureCode = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        if (updateCurrent) _currentCultureCode = newCultureCode;
        return newCultureCode;
    }

    private static ResourceDictionary GetLangResourceDictionary(string langCode)
    {
        return new ResourceDictionary { Source = GetLangResourceUri(langCode) };
    }
    
    private static Uri GetLangResourceUri(string langCode)
    {
        return new Uri($"/Strings/Lang/Resource.{langCode}.xaml", UriKind.Relative);
    }
}
