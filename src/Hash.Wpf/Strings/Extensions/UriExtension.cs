// Copyright © 2021-present Hibi_10000
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
using System.ComponentModel;
using System.Windows.Markup;

namespace Hash.Wpf.Strings.Extensions;

[ContentProperty("UriString")]
[MarkupExtensionReturnType(typeof(Uri))]
public class UriExtension : MarkupExtension
{
    private string? _uriString;

    public UriExtension() {}
    public UriExtension(string uriString) => _uriString = uriString;

    [ConstructorArgument("uriString")]
    [DefaultValue(null)]
    public string? UriString
    {
        get => _uriString;
        set => _uriString = value;
    }

    public override object? ProvideValue(IServiceProvider serviceProvider)
    {
        if (_uriString is not null)
        {
            return new Uri(_uriString);
        }
        return null;
    }
}
