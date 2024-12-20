// MIT License
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/LICENSE
//
// See NOTICE.md for the full license text.

// MenuHelper.cs
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/Theme.WPF/Themes/Attached/MenuHelper.cs
//

using System.Windows;

namespace Theme.WPF.Themes.Attached
{
    public static class MenuHelper
    {
        public static readonly DependencyProperty UseStretchedContentProperty = DependencyProperty.RegisterAttached("UseStretchedContent", typeof(bool), typeof(MenuHelper), new PropertyMetadata(false));

        public static void SetUseStretchedContent(DependencyObject element, bool value)
        {
            element.SetValue(UseStretchedContentProperty, value);
        }

        public static bool GetUseStretchedContent(DependencyObject element)
        {
            return (bool) element.GetValue(UseStretchedContentProperty);
        }
    }
}
