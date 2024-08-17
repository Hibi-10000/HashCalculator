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
using System.Windows.Forms;

namespace Hash
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Environment.Is64BitOperatingSystem)
            {
                Environment.ExitCode = 1;
                Application.Exit();
            }

            string[] Commands = Environment.GetCommandLineArgs();

            for (int i = 0; i < Commands.Length; i++)
            {
                if (Commands[i] == "/rc")
                {
                    if (IsAdministrator())
                    {
                        Microsoft.Win32.RegistryKey regkey;
                        using (regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext"))
                        {
                            regkey.SetValue("MUIVerb", "Hash for ContextMenu(&F)", Microsoft.Win32.RegistryValueKind.String);
                            regkey.SetValue("SubCommands", "", Microsoft.Win32.RegistryValueKind.String);
                        }
                        Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell").Close();

                        Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*").Close();
                        using (regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*\command")) {
                            regkey.SetValue("", @$"""{Application.ExecutablePath}"" /ctm /f ""%1""", Microsoft.Win32.RegistryValueKind.String);
                        }

                        foreach (string hashType in Enum.GetNames<HashCalculate.HashType>())
                        {
                            var hash = hashType.Replace("_", "-");
                            Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@$"*\shell\HashForContext\shell\{hash}").Close();
                            using (regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@$"*\shell\HashForContext\shell\{hash}\command")) {
                                regkey.SetValue("", @$"""{Application.ExecutablePath}"" /ctm /f ""%1"" /h {hash}", Microsoft.Win32.RegistryValueKind.String);
                            }
                        }

                        Environment.ExitCode = 0;
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("UACをキャンセルしたか、起動方法が間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.ExitCode = 1;
                        Application.Exit();
                    }
                    return;
                }
                else if (Commands[i] == "/rd")
                {
                    if (IsAdministrator())
                    {
                        Microsoft.Win32.Registry.ClassesRoot.DeleteSubKeyTree(@"*\shell\HashForContext");

                        Environment.ExitCode = 0;
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("UACをキャンセルしたか、起動方法が間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.ExitCode = 1;
                        Application.Exit();
                    }
                    return;
                }
                else if (Commands[i] == "/ctm")
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new HashForContext());
                    return;
                }
            }

            string mutexName = "HashCalculator-Mutex";
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, mutexName, out bool createdNew);

            //Mutexの初期所有権が付与されたか調べる
            if (createdNew == false)
            {
                //System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("多重起動はできません。","HashCalculator  -  ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                mutex.Close();
                Environment.ExitCode = 1;
                Application.Exit();
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HashCalculator());
            mutex.ReleaseMutex();
            mutex.Close();
        }

        private static bool IsAdministrator()
        {
            var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var principal = new System.Security.Principal.WindowsPrincipal(identity);
            return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
    }
}
