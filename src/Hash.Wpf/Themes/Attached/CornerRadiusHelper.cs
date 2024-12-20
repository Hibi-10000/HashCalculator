// MIT License
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/LICENSE
//
// See NOTICE.md for the full license text.

// CornerRadiusHelper.cs
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/Theme.WPF/Themes/Attached/CornerRadiusHelper.cs
//

using System.Windows;

namespace Theme.WPF.Themes.Attached
{
    public static class CornerRadiusHelper
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(CornerRadius), typeof(CornerRadiusHelper), new PropertyMetadata(new CornerRadius(0)));

        public static void SetValue(DependencyObject element, CornerRadius value) => element.SetValue(ValueProperty, value);

        public static CornerRadius GetValue(DependencyObject element) => (CornerRadius) element.GetValue(ValueProperty);
    }
}
