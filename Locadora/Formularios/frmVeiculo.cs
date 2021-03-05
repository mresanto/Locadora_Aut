using Locadora.Action;
using Locadora.Classes;
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
    public partial class frmVeiculo : Form
    {

        public int _idVeiculo;

        public frmVeiculo()
        {
            InitializeComponent();
        }
        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            ConfiguraGridVeiculo();
            btnPesquisar_Click(null, null);
        }

        private void tabCadastroVei_Click(object sender, EventArgs e)
        {

        }

        private void ConfiguraGridVeiculo()
        {
            try
            {
                grdPesquisarVei.DataSource = null;
                grdPesquisarVei.ColumnCount = 0;

                grdPesquisarVei.Columns.Add(new DataGridViewButtonColumn());
                grdPesquisarVei.Columns.Add(new DataGridViewTextBoxColumn());
                grdPesquisarVei.Columns.Add(new DataGridViewTextBoxColumn());

                grdPesquisarVei.Columns[0].Name = "selecionar";
                grdPesquisarVei.Columns[1].Name = "idVeiculo";
                grdPesquisarVei.Columns[2].Name = "nome";

                grdPesquisarVei.Columns["selecionar"].Width = 80;
                grdPesquisarVei.Columns["idVeiculo"].Width = 60;
                grdPesquisarVei.Columns["nome"].Width = 350;

                grdPesquisarVei.Columns["selecionar"].HeaderText = "";
                grdPesquisarVei.Columns["idVeiculo"].HeaderText = "ID";
                grdPesquisarVei.Columns["nome"].HeaderText = "Nome";

                grdPesquisarVei.Columns["idVeiculo"].Visible = false;

                grdPesquisarVei.Columns["idVeiculo"].ReadOnly = true;
                grdPesquisarVei.Columns["nome"].ReadOnly = true;

                grdPesquisarVei.AllowUserToAddRows = false;
                grdPesquisarVei.AllowUserToDeleteRows = false;
                grdPesquisarVei.RowHeadersVisible = false;

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
                grdPesquisarVei.Rows.Clear();

                VeiculoAction veiculoAction = new VeiculoAction();

                var lista = veiculoAction.Lista(txtPesquisarNomeVei.Text);

                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        grdPesquisarVei.Rows.Add();

                        grdPesquisarVei.Rows[i].Cells["selecionar"].Value = "Exibir";
                        grdPesquisarVei.Rows[i].Cells["idVeiculo"].Value = lista[i].IdVeiculo.ToString();
                        grdPesquisarVei.Rows[i].Cells["nome"].Value = lista[i].Nome.ToString();

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
                if (grdPesquisarVei.RowCount > 0)
                {
                    if (e.RowIndex > -1 && grdPesquisarVei.Rows[e.RowIndex].Cells["selecionar"].Selected)
                    {
                        var idVeiculo = grdPesquisarVei.Rows[e.RowIndex].Cells["idVeiculo"].Value.ToString();
                        ExibirVeiculo(Convert.ToInt32(idVeiculo));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }
        
        private void ExibirVeiculo(int idVeiculo)
        {
            try
            {
                VeiculoAction veiculoAction = new VeiculoAction();

                var veiculo = veiculoAction.Detalhe(Convert.ToInt32(idVeiculo));

                _idVeiculo = veiculo.IdVeiculo;
                txtNomeVei.Text = veiculo.Nome;
                txtCorVei.Text = veiculo.Cor;
                txtInfoVei.Text = veiculo.Info;
                cbDis.Checked = veiculo.Dis;

                tabControl2.SelectedTab = tabCadastroVei;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        public void btnNovoVei_Click(object sender, EventArgs e)
        {
            _idVeiculo = 0;
            txtNomeVei.Text = "";
            txtInfoVei.Text = "";
            txtCorVei.Text = "";
            cbDis.Checked = false;
        }

        private void btnSalvarVei_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos() == false)
                {
                    return;
                }

                VeiculoAction veiculoAction = new VeiculoAction();
                Veiculo veiculo = new Veiculo();

                veiculo.IdVeiculo = Convert.ToInt32(_idVeiculo);
                veiculo.Nome = txtNomeVei.Text;
                veiculo.Cor = txtCorVei.Text;
                veiculo.Info= txtInfoVei.Text;
                veiculo.Dis = Convert.ToBoolean(cbDis.Checked);

                var retorno = veiculoAction.Salvar(veiculo);

                if (retorno)
                {
                    MessageBox.Show("Veiculo Cadastrado com Sucesso!", "Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovoVei_Click(null, null);
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Houve um erro ao Salvar!", "Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);

            }
        }

        private void btnExcluirVei_Click(object sender, EventArgs e)
        {
            try
            {

                VeiculoAction veiculoAction = new VeiculoAction();

                var retorno = veiculoAction.Excluir(_idVeiculo);

                if (retorno)
                {
                    MessageBox.Show("Veiculo Excluído com Sucesso!", "Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovoVei_Click(null, null);
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Houve um erro ao excluir Veiculo!", "Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);

            }
        }
        private bool ValidaCampos()
        {
            if (txtNomeVei.Text == "")
            {
                MessageBox.Show("O nome do Veiculo precisa ser preenchido", "Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtCorVei.Text == "")
            {
                MessageBox.Show("A Cor do veiculo precisa ser preenchido", "Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        
    }
}
