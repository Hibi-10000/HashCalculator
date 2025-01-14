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
using System.Windows;
using System.Windows.Markup;

namespace Hash.Wpf.Strings;

[MarkupExtensionReturnType(typeof(object))]
[Localizability(LocalizationCategory.NeverLocalize)]
public class StringResourceExtension : StaticResourceExtension
{
    public StringResourceExtension() {}
    public StringResourceExtension(object resourceKey) : base(resourceKey) {}
    
    public override object? ProvideValue(IServiceProvider serviceProvider)
    {
        return base.ProvideValue(serviceProvider) switch
        {
            string baseValue => baseValue,
            Uri baseValue => baseValue,
            _ => null
        };
    }
}
