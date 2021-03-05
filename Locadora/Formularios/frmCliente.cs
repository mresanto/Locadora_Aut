using Locadora.Action;
using Locadora.Classes;
using Locadora.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Formularios
{
    public partial class frmCliente : Form
    {
        public int _idCliente;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ConfiguraGridCliente();
            btnPesquisar_Click(null, null);
        }


        private void ConfiguraGridCliente()
        {
            try
            {
                grdPesquisar.DataSource = null;
                grdPesquisar.ColumnCount = 0;

                grdPesquisar.Columns.Add(new DataGridViewButtonColumn());
                grdPesquisar.Columns.Add(new DataGridViewTextBoxColumn());
                grdPesquisar.Columns.Add(new DataGridViewTextBoxColumn());

                grdPesquisar.Columns[0].Name = "selecionar";
                grdPesquisar.Columns[1].Name = "idCliente";
                grdPesquisar.Columns[2].Name = "nome";

                grdPesquisar.Columns["selecionar"].Width = 80;
                grdPesquisar.Columns["idCliente"].Width = 60;
                grdPesquisar.Columns["nome"].Width = 350;

                grdPesquisar.Columns["selecionar"].HeaderText = "";
                grdPesquisar.Columns["idCliente"].HeaderText = "ID";
                grdPesquisar.Columns["nome"].HeaderText = "Nome";

                grdPesquisar.Columns["idCliente"].Visible = false;

                grdPesquisar.Columns["idCliente"].ReadOnly = true;
                grdPesquisar.Columns["nome"].ReadOnly = true;
                 
                grdPesquisar.AllowUserToAddRows = false;
                grdPesquisar.AllowUserToDeleteRows = false;
                grdPesquisar.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }

        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                grdPesquisar.Rows.Clear();

                ClienteAction clienteAction = new ClienteAction();

                var lista = clienteAction.Lista(txtPesquisarNome.Text);

                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        grdPesquisar.Rows.Add();

                        grdPesquisar.Rows[i].Cells["selecionar"].Value = "Exibir";
                        grdPesquisar.Rows[i].Cells["idCliente"].Value = lista[i].IdCliente.ToString();
                        grdPesquisar.Rows[i].Cells["nome"].Value = lista[i].Nome.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        private void grdPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdPesquisar.RowCount > 0)
                {
                    if (e.RowIndex > -1 && grdPesquisar.Rows[e.RowIndex].Cells["selecionar"].Selected)
                    {
                        var idCliente = grdPesquisar.Rows[e.RowIndex].Cells["idCliente"].Value.ToString();
                        ExibirCliente(Convert.ToInt32(idCliente));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        private void ExibirCliente(int idCliente)
        {
            try
            {
                ClienteAction clienteAciton = new ClienteAction();

                var cliente = clienteAciton.Detalhe(Convert.ToInt32(idCliente));

                _idCliente = cliente.IdCliente;
                txtNome.Text = cliente.Nome;
                txtCPF.Text = cliente.Cpf;
                txtCnh.Text = cliente.Cnh;

                tabControl1.SelectedTab = tabCadastro;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        public void btnNovo_Click(object sender, EventArgs e)
        {
            _idCliente = 0;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtCnh.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos() == false)
                {
                    return;
                }

                ClienteAction clienteAction = new ClienteAction();
                Cliente cliente = new Cliente();

                cliente.IdCliente = Convert.ToInt32(_idCliente);
                cliente.Nome = txtNome.Text;
                cliente.Cnh = txtCnh.Text;
                cliente.Cpf = txtCPF.Text.Replace(".","").Replace("-","");

                var retorno = clienteAction.Salvar(cliente);

                if (retorno)
                {
                    MessageBox.Show("Cliente Cadastrado com Sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo_Click(null, null);
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Houve um erro ao Salvar!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteAction clienteAction = new ClienteAction();

                var retorno = clienteAction.Excluir(_idCliente);

                if (retorno)
                {
                    MessageBox.Show("Cliente Excluído com Sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo_Click(null, null);
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Houve um erro ao excluir Cliente!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);

            }
        }
        private bool ValidaCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O nome do cliente precisa ser preenchido", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtCPF.Text == "")
            {
                MessageBox.Show("O CPF do cliente precisa ser preenchido", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void tabPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
