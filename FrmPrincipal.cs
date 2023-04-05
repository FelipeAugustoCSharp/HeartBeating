using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartBeating
{
    public partial class FrmPrincipal : Form
    {
        private void MudasPagina(int n)
        {
            tbcPrincipal.SelectedIndex = n;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MudasPagina(3);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MudasPagina(2);
        }

        private void btnDoacoes_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MudasPagina(0);
        }
        private void btnDoar_Click(object sender, EventArgs e)
        {
            MudasPagina(2);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            MudasPagina(3);
        }

        private void voltar0_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MudasPagina(0);
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            MudasPagina(5);
        }

        private void labelCadastro_Click(object sender, EventArgs e)
        {
            MudasPagina(6);
        }

        private void BtnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            MudasPagina(7);
        }

        private void voltar3_Click(object sender, EventArgs e)
        {
            MudasPagina(6);
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            MudasPagina(5);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MudasPagina(5);
        }

        /* private void txbDATE_Validating(object sender, CancelEventArgs e)
         {
             txbDATE.Clear();
             Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
             Match m = reg.Match(txbDATE.Text);
             if (m.Success)
             {
                 int dd = int.Parse(m.Groups[1].Value);
                 int mm = int.Parse(m.Groups[2].Value);
                 int yyyy = int.Parse(m.Groups[3].Value);
                 e.Cancel = dd > 1 || dd < 31 || mm > 1 || mm < 12 || yyyy > 2000;
             }
             else e.Cancel = true;
             if (e.Cancel)
             {
                 if (MessageBox.Show("Wrong date format. The correct format is dd/mm/yyyy\n+ dd should be between 1 and 31.\n+ mm should be between 1 and 12.\n+ yyyy should be before 2025", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                     e.Cancel = false;
             }
             MessageBox.Show(txbDATE.Text);
         }*/
        public FrmPrincipal()
        {
            InitializeComponent();
            MudasPagina(5);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PictureCircle.Visible = true;
            PictureCircle.Visible = false;            
        }
    }
}
