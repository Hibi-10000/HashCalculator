﻿// Copyright © 2021-2024 Hibi_10000
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Markup;

namespace Hash.Wpf.Strings;

[ContentProperty("Strings")]
[MarkupExtensionReturnType(typeof(string))]
public class StringsExtension : MarkupExtension
{
    private List<string> _strings = [];
    private string? _formatString;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public List<string> Strings
    {
        get => _strings;
        set => _strings = value;
    }
    
    [DefaultValue(null)]
    [StringSyntax("CompositeFormat")]
    public string? StringFormat
    {
        get => _formatString;
        set => _formatString = value;
    }

    public override string ProvideValue(IServiceProvider serviceProvider)
    {
        if (_formatString is not null)
        {
            return string.Format(_formatString, _strings.ToArray<object>());
        }
        return string.Concat(_strings);
    }
}