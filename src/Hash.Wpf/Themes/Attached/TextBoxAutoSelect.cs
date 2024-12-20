// MIT License
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/LICENSE
//
// See NOTICE.md for the full license text.

// TextBoxAutoSelect.cs
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/Theme.WPF/Themes/Attached/TextBoxAutoSelect.cs
//

using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Theme.WPF.Themes.Attached
{
    public static class TextBoxAutoSelect
    {
        private static readonly RoutedEventHandler Handler = ControlOnLoaded;

        public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(TextBoxAutoSelect), new PropertyMetadata(false, PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control control)
            {
                control.Loaded += Handler;
            }
        }

        private static void ControlOnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is Control control)
            {
                control.Focus();
                if (control is TextBoxBase textbox)
                {
                    textbox.SelectAll();
                }

                control.Loaded -= Handler;
            }
        }

        public static void SetIsEnabled(DependencyObject element, bool value)
        {
            element.SetValue(IsEnabledProperty, value);
        }

        public static bool GetIsEnabled(DependencyObject element)
        {
            return (bool) element.GetValue(IsEnabledProperty);
        }
    }
}
