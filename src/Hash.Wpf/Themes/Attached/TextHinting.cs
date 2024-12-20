// MIT License
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/LICENSE
//
// See NOTICE.md for the full license text.

// TextHinting.cs
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/Theme.WPF/Themes/Attached/TextHinting.cs
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Theme.WPF.Themes.Attached
{
    /// <summary>
    /// An attached property class for showing a hint when a text box is empty. Set the text box's Tag property to the text
    /// </summary>
    public static class TextHinting
    {
        public static readonly DependencyProperty ShowWhenFocusedProperty =
            DependencyProperty.RegisterAttached(
                "ShowWhenFocused",
                typeof(bool),
                typeof(TextHinting),
                new FrameworkPropertyMetadata(false));

        public static void SetShowWhenFocused(Control control, bool value)
        {
            if (control is TextBoxBase || control is PasswordBox)
            {
                control.SetValue(ShowWhenFocusedProperty, value);
            }

            throw new ArgumentException("Control was not a textbox", nameof(control));
        }

        public static bool GetShowWhenFocused(Control control)
        {
            if (control is TextBoxBase || control is PasswordBox)
            {
                return (bool) control.GetValue(ShowWhenFocusedProperty);
            }

            throw new ArgumentException("Control was not a textbox", nameof(control));
        }
    }
}
