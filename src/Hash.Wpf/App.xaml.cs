// Copyright © 2021-2024 Hibi_10000
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
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using Hash.Core;
using Microsoft.Win32;

namespace Hash.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    internal const string Major = "0";
    internal const string Minor = "6";
    internal const string Build = "2";
    internal const string Ch = "";

    internal const string SemVer = $"{Major}.{Minor}.{Build}";

    /// <summary>
    /// Application Entry Point.
    /// </summary>
    [STAThread]
    public static void Main() {
        string[] args = Environment.GetCommandLineArgs();

        foreach (string arg in args)
        {
            switch (arg)
            {
                case "-rc" when Environment.IsPrivilegedProcess:
                    if (!File.Exists(Environment.ProcessPath))
                    {
                        MessageBox.Show("予期せぬ原因によりファイルパスを取得できませんでした。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                        Environment.ExitCode = 1;
                        return;
                    }
                    using (RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext"))
                    {
                        regKey.SetValue("MUIVerb", "Hash for ContextMenu(&F)", RegistryValueKind.String);
                        regKey.SetValue("SubCommands", "", RegistryValueKind.String);
                    }
                    using (RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*\command")) {
                        regKey.SetValue("", @$"""{Environment.ProcessPath}"" -ctm -f ""%1""", RegistryValueKind.String);
                    }

                    foreach (string hash in HashCalculate.GetHashTypeNames())
                    {
                        using RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(@$"*\shell\HashForContext\shell\{hash}\command");
                        regKey.SetValue("", @$"""{Environment.ProcessPath}"" -ctm -f ""%1"" -h {hash}", RegistryValueKind.String);
                    }
                    return;
                case "-rd" when Environment.IsPrivilegedProcess:
                    Registry.ClassesRoot.DeleteSubKeyTree(@"*\shell\HashForContext");
                    return;
                case "-rd" or "-rc":
                    MessageBox.Show("UACをキャンセルしたか、起動方法が間違っています。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                    Environment.ExitCode = 1;
                    return;
                case "-ctm":
                    App appContext = new App();
                    appContext.InitializeComponent();
                    appContext.Run(new HashForContextWindow());
                    return;
            }
        }

        const string mutexName = "HashCalculator-Mutex";
        using Mutex mutex = new Mutex(true, mutexName, out bool createdNew);

        App app = new App();
        app.InitializeComponent();
        app.Run(new MainWindow(!createdNew));
        mutex.ReleaseMutex();
    }

    internal static void OpenLink(string link)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo(link)
        {
            UseShellExecute = true
        };
        Process.Start(startInfo);
    }
}
