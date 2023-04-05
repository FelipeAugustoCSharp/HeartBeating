using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartBeating
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            tbcPrincipal.SelectedIndex = 1;
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDoar_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 2;
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 3;
        }

        private void voltar0_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 1;
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedIndex = 1;
        }

        private void txbDATE_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
            Match m = reg.Match(txbDATE.Text);
            if (m.Success)
            {
                int dd = int.Parse(m.Groups[1].Value);
                int mm = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = dd < 1 || dd > 31 || mm < 1 || mm > 12 || yyyy > 2025;
            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if (MessageBox.Show("Wrong date format. The correct format is dd/mm/yyyy\n+ dd should be between 1 and 31.\n+ mm should be between 1 and 12.\n+ yyyy should be before 2013", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }
        }
    }
}
