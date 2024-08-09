using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ethernal_Return_Match_Seacher
{
    public partial class UserSearchResult : Form
    {
        public UserSearchResult()
        {
            InitializeComponent();
        }

        private void NickName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://dak.gg/er/players/" + NickName.Text) { UseShellExecute = true });
        }
    }
}
