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
    internal partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void dlFromGitHub_Click(object sender, EventArgs e)
        {
            Program.OpenLink("https://github.com/Hibi-10000/HashCalculator/releases/");
        }

        private void licenseLink_Click(object sender, EventArgs e)
        {
            Program.OpenLink($"https://github.com/Hibi-10000/HashCalculator/blob/v{Program.SemVer}/LICENSE.md");
        }

        private void noticeLink_Click(object sender, EventArgs e)
        {
            Program.OpenLink($"https://github.com/Hibi-10000/HashCalculator/blob/v{Program.SemVer}/NOTICE.md");
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            hashAndVer.Text = $"HashCalculator v{Program.SemVer}";
            version.Text = $"Version: v{Program.SemVer}{Program.Ch}";
            copyright.Text = $"Copyright © 2021-{DateTime.Now.Year} Hibi_10000";
        }
    }
}
