using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartBeating
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            tbcPrincipal.SelectedIndex = 3;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 3;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 2;
        }

        private void btnDoacoes_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 0;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
