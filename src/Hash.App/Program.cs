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
using System.Threading;
using System.Windows.Forms;
using Hash.Core;
using Microsoft.Win32;

namespace Hash.App
{
    internal static class Program
    {
        internal const string Major = "0";
        internal const string Minor = "6";
        internal const string Build = "1";
        internal const string Ch = "";

        internal const string SemVer = $"{Major}.{Minor}.{Build}";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            foreach (string arg in args)
            {
                switch (arg)
                {
                    case "/rc" when Environment.IsPrivilegedProcess:
                        using (RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext"))
                        {
                            regKey.SetValue("MUIVerb", "Hash for ContextMenu(&F)", RegistryValueKind.String);
                            regKey.SetValue("SubCommands", "", RegistryValueKind.String);
                        }
                        using (RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*\command")) {
                            regKey.SetValue("", @$"""{Application.ExecutablePath}"" /ctm /f ""%1""", RegistryValueKind.String);
                        }

                        foreach (string hash in HashCalculate.GetHashTypeNames())
                        {
                            using RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(@$"*\shell\HashForContext\shell\{hash}\command");
                            regKey.SetValue("", @$"""{Application.ExecutablePath}"" /ctm /f ""%1"" /h {hash}", RegistryValueKind.String);
                        }
                        return;
                    case "/rd" when Environment.IsPrivilegedProcess:
                        Registry.ClassesRoot.DeleteSubKeyTree(@"*\shell\HashForContext");
                        return;
                    case "/rd" or "/rc":
                        MessageBox.Show("UACをキャンセルしたか、起動方法が間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.ExitCode = 1;
                        return;
                    case "/ctm":
                        ApplicationConfiguration.Initialize();
                        Application.Run(new HashForContext());
                        return;
                }
            }

            const string mutexName = "HashCalculator-Mutex";
            using Mutex mutex = new Mutex(true, mutexName, out bool createdNew);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Mutexの初期所有権が付与されたかを渡して起動
            Application.Run(new HashCalculator(!createdNew));
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
}
