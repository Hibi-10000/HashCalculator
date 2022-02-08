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

            string[] Commands = System.Environment.GetCommandLineArgs();

            for (int i = 0; i < Commands.Length; i++)
            {
                if (Commands[i] == "/rc")
                {
                    if (IsAdministrator())
                    {
                        Microsoft.Win32.RegistryKey regkey;
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext");
                        regkey.SetValue("MUIVerb", "Hash for ContextMenu(&F)", Microsoft.Win32.RegistryValueKind.String);
                        regkey.SetValue("SubCommands", "", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell");
                        regkey.Close();

                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*");
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\*\command");
                        regkey.SetValue("@", "\"C:\\Program Files\\HashCalculator\\HashForContext.exe\" /f \"%1\"", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();

                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\MD5");
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\MD5\command");
                        regkey.SetValue("@", "\"C:\\Program Files\\HashCalculator\\HashForContext.exe\" /f \"%1\" /h MD5", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();

                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA1");
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA1\command");
                        regkey.SetValue("@", "\"C:\\Program Files\\HashCalculator\\HashForContext.exe\" /f \"%1\" /h SHA1", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();

                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA256");
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA256\command");
                        regkey.SetValue("@", "\"C:\\Program Files\\HashCalculator\\HashForContext.exe\" /f \"%1\" /h SHA256", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();

                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA384");
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA384\command");
                        regkey.SetValue("@", "\"C:\\Program Files\\HashCalculator\\HashForContext.exe\" /f \"%1\" /h SHA384", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();

                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA512");
                        regkey.Close();
                        regkey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(@"*\shell\HashForContext\shell\SHA512\command");
                        regkey.SetValue("@", "\"C:\\Program Files\\HashCalculator\\HashForContext.exe\" /f \"%1\" /h SHA512", Microsoft.Win32.RegistryValueKind.String);
                        regkey.Close();

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

                    return;
                }
            }

            string mutexName = "HashCalculator-Mutex";
            bool createdNew;
            System.Threading.Mutex mutex =
                new System.Threading.Mutex(true, mutexName, out createdNew);

            //Mutexの初期所有権が付与されたか調べる
            if (createdNew == false)
            {
                //System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("多重起動はできません。","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                mutex.Close();
                Environment.ExitCode = 1;
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hash());
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
