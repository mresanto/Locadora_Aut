﻿using Locadora.Formularios;
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
    }
}