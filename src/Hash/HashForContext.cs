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
    public partial class HashForContext : Form
    {
        public HashForContext()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Environment.ExitCode = 0;
            Application.Exit();
        }

        private void HashForContext_Load(object sender, EventArgs e)
        {
            string[] Commands = Environment.GetCommandLineArgs();

            for (int i = 0; i < Commands.Length; i++)
            {
                if (Commands[i] == "/f")
                {
                    //File (/f "{FileURL}")
                    int urlno = i + 1;
                    HashFileURL.Text = Commands[urlno];
                }
                else if (Commands[i] == "/h")
                {
                    //HashType (/h MD5)
                    int hashtypeno = i + 1;
                    HashSelecter.Text = Commands[hashtypeno];
                }
                else if (Commands[i] == "/d")
                {
                    //Debug (/d)
                    DebugUse.Visible = true;
                    HashFileURL.ReadOnly = false;
                }
            }

            Text = $"Hash for ContextMenu v{HashCalculator.Major}.{HashCalculator.Minor}.{HashCalculator.Build}{HashCalculator.Ch}";
            Title.Text = $"Hash for ContextMenu v{HashCalculator.Major}.{HashCalculator.Minor}.{HashCalculator.Build}";
            Copyright.Text = $"Copyright © 2021-{DateTime.Now.Year} Hibi_10000";
        }

        private void HashReset_Click(object sender, EventArgs e)
        {
            HashOutputBox.Text = "ここにHash値が表示されます";
            HashSelecter.Text = "Hashを選択してください";
        }

        private void HashCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashSelecter.Text);
            Clipboard.SetText(HashOutputBox.Text);
            HashOutputBox.Focus();
            HashOutputBox.SelectAll();
        }

        private void DLGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.com/Hibi-10000/HashCalculator/releases/")
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void HashSelecter_Set(object sender, EventArgs e)
        {
            if (HashFileURL.Text != "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)" && HashFileURL.Text != "")
            {
                string hashType = HashSelecter.Text;
                string filePath = HashFileURL.Text;
                bool upper = UpperCheck.Checked;
                bool hihun = HihunCheck.Checked;
                string hash = HashCalculate.GetHash(hashType, filePath, upper, hihun) ?? "ここにHash値が表示されます";
                HashOutputBox.Text = hash;
            } else {
                HashOutputBox.Text = "ここにHash値が表示されます";
            }
        }

        private void StartHash_Click(object sender, EventArgs e)
        {
            string option = "";
            if (HashFileURL.Text != "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)") option += "/f \"" + HashFileURL.Text + "\" ";
            if (HashSelecter.Text != "Hashを選択してください") option += "/h " + HashSelecter.Text + " ";
            if (DebugUse.Visible == true) option += "/d";
            var startInfo = new System.Diagnostics.ProcessStartInfo(Application.ExecutablePath)
            {
                UseShellExecute = true,
                Arguments = option
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        private void DebugUse_Click(object sender, EventArgs e)
        {
            DialogResult dr = DebugUseDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                HashFileURL.Text = null;
                HashFileURL.Text = DebugUseDialog.FileName;
            }
        }
    }
}
