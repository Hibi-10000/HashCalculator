// MIT License
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/LICENSE
//
// See NOTICE.md for the full license text.

// ThemeType.cs
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/Theme.WPF/Themes/ThemeType.cs
//

using System;

namespace Theme.WPF.Themes
{
    public enum ThemeType
    {
        SoftDark,
        RedBlackTheme,
        DeepDark,
        GreyTheme,
        DarkGreyTheme,
        LightTheme,
    }

    public static class ThemeTypeExtension
    {
        public static string GetName(this ThemeType type)
        {
            switch (type)
            {
                case ThemeType.SoftDark: return "SoftDark";
                case ThemeType.RedBlackTheme: return "RedBlackTheme";
                case ThemeType.DeepDark: return "DeepDark";
                case ThemeType.GreyTheme: return "GreyTheme";
                case ThemeType.DarkGreyTheme: return "DarkGreyTheme";
                case ThemeType.LightTheme: return "LightTheme";
                default: throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
