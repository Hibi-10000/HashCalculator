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

using Hash.Core;
using Microsoft.Win32;

namespace Hash
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!Environment.Is64BitOperatingSystem)
            {
                Environment.ExitCode = 1;
                Application.Exit();
            }

            string[] args = Environment.GetCommandLineArgs();

            foreach (string arg in args)
            {
                if (arg == "/rc")
                {
                    if (IsAdministrator())
                    {
                        RegistryKey regkey;
                        using (regkey = Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext"))
                        {
                            regkey.SetValue("MUIVerb", "Hash for ContextMenu(&F)", RegistryValueKind.String);
                            regkey.SetValue("SubCommands", "", RegistryValueKind.String);
                        }
                        Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell").Close();

                        Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*").Close();
                        using (regkey = Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*\command")) {
                            regkey.SetValue("", @$"""{Application.ExecutablePath}"" /ctm /f ""%1""", RegistryValueKind.String);
                        }

                        foreach (string hashType in Enum.GetNames<HashCalculate.HashType>())
                        {
                            string hash = hashType.Replace("_", "-");
                            Registry.ClassesRoot.CreateSubKey(@$"*\shell\HashForContext\shell\{hash}").Close();
                            using (regkey = Registry.ClassesRoot.CreateSubKey(@$"*\shell\HashForContext\shell\{hash}\command")) {
                                regkey.SetValue("", @$"""{Application.ExecutablePath}"" /ctm /f ""%1"" /h {hash}", RegistryValueKind.String);
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
                }
                else if (arg == "/rd")
                {
                    if (IsAdministrator())
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(@"*\shell\HashForContext");

                        Environment.ExitCode = 0;
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("UACをキャンセルしたか、起動方法が間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.ExitCode = 1;
                        Application.Exit();
                    }
                }
                else if (arg == "/ctm")
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new HashForContext());
                }
            }

            const string mutexName = "HashCalculator-Mutex";
            Mutex mutex = new Mutex(true, mutexName, out bool createdNew);

            //Mutexの初期所有権が付与されたか調べる
            if (createdNew == false)
            {
                //System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("多重起動はできません。", "HashCalculator  -  ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
