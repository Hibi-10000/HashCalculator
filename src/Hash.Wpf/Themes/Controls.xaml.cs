// MIT License
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/LICENSE
//
// See NOTICE.md for the full license text.

// Controls.xaml.cs
// https://github.com/AngryCarrot789/WPFDarkTheme/blob/5993251fed1780ead1a01630d2f0d792e71c8eab/Theme.WPF/Themes/Controls.xaml.cs
//

using System.Windows;

namespace Theme.WPF.Themes
{
    public partial class Controls
    {
        private void CloseWindow_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                this.CloseWind(Window.GetWindow((FrameworkElement) e.Source));
        }

        private void AutoMinimize_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                this.MaximizeRestore(Window.GetWindow((FrameworkElement) e.Source));
        }

        private void Minimize_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                this.MinimizeWind(Window.GetWindow((FrameworkElement) e.Source));
        }

        public void CloseWind(Window window) => window?.Close();

        public void MaximizeRestore(Window window)
        {
            if (window == null)
                return;
            switch (window.WindowState)
            {
                case WindowState.Normal:
                    window.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Minimized:
                case WindowState.Maximized:
                    window.WindowState = WindowState.Normal;
                    break;
            }
        }

        public void MinimizeWind(Window window)
        {
            if (window != null)
                window.WindowState = WindowState.Minimized;
        }
    }
}
