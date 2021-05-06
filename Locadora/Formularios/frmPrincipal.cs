using Locadora.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void mnuCadCliente_Click(object sender, EventArgs e)
        {
            var form = new frmCliente();
            form.Show();
        }

        private void mnuCadVeiculo_Click(object sender, EventArgs e)
        {
            var form = new frmVeiculo();
            form.Show();
        }


        private void mnuCadAlugle_Click(object sender, EventArgs e)
        {
            var form = new frmAluguel();
            form.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void picGatinho_Click(object sender, EventArgs e)
        {

        }
    }
}
