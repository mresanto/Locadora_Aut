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
    public partial class frmAluguel : Form
    {
        public int _idAluguel;
        public int _idMulta;
        private Funcoes _funcoes = new Funcoes();  

        public frmAluguel()
        {
            InitializeComponent();
            ConfiguraGridAluguel();
            ConfiguraGridAluguel();
            btnPesquisar_Click(null, null);
        }

        private void frmAluguel_Load(object sender, EventArgs e)
        {
            try
            {
                _funcoes.PreencheCombo(cmbCliente, "ID_CLIENTE", "NOME_CLIENTE", "CLIENTE");
                _funcoes.PreencheCombo(cmbVeiculo, "ID_VEICULO", "NOME_VEICULO", "VEICULO");
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }


        private void ConfiguraGridAluguel()
        {
            try
            {
                grdPesquisarAluguel.DataSource = null;
                grdPesquisarAluguel.ColumnCount = 0;

                grdPesquisarAluguel.Columns.Add(new DataGridViewButtonColumn());
                grdPesquisarAluguel.Columns.Add(new DataGridViewTextBoxColumn());
                grdPesquisarAluguel.Columns.Add(new DataGridViewTextBoxColumn());

                grdPesquisarAluguel.Columns[0].Name = "selecionar";
                grdPesquisarAluguel.Columns[1].Name = "idAluguel";
                grdPesquisarAluguel.Columns[2].Name = "nome";

                grdPesquisarAluguel.Columns["selecionar"].Width = 80;
                grdPesquisarAluguel.Columns["idAluguel"].Width = 60;
                grdPesquisarAluguel.Columns["nome"].Width = 350;

                grdPesquisarAluguel.Columns["selecionar"].HeaderText = "";
                grdPesquisarAluguel.Columns["idAluguel"].HeaderText = "ID";
                grdPesquisarAluguel.Columns["nome"].HeaderText = "Nome";

                grdPesquisarAluguel.Columns["idAluguel"].Visible = false;

                grdPesquisarAluguel.Columns["idAluguel"].ReadOnly = true;
                grdPesquisarAluguel.Columns["nome"].ReadOnly = true;

                grdPesquisarAluguel.AllowUserToAddRows = false;
                grdPesquisarAluguel.AllowUserToDeleteRows = false;
                grdPesquisarAluguel.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }

        }

        private void ConfiguraGridMulta()
        {
            try
            {
                grdPesquisarMulta.DataSource = null;
                grdPesquisarMulta.ColumnCount = 0;

                grdPesquisarMulta.Columns.Add(new DataGridViewButtonColumn());
                grdPesquisarMulta.Columns.Add(new DataGridViewTextBoxColumn());
                grdPesquisarMulta.Columns.Add(new DataGridViewTextBoxColumn());

                grdPesquisarMulta.Columns[0].Name = "selecionar";
                grdPesquisarMulta.Columns[1].Name = "idMulta";
                grdPesquisarMulta.Columns[2].Name = "dataMulta";

                grdPesquisarMulta.Columns["selecionar"].Width = 80;
                grdPesquisarMulta.Columns["idMulta"].Width = 60;
                grdPesquisarMulta.Columns["dataMulta"].Width = 350;

                grdPesquisarMulta.Columns["selecionar"].HeaderText = "";
                grdPesquisarMulta.Columns["idMulta"].HeaderText = "ID";
                grdPesquisarMulta.Columns["dataMulta"].HeaderText = "Data";

                grdPesquisarMulta.Columns["idMulta"].ReadOnly = true;
                grdPesquisarMulta.Columns["dataMulta"].ReadOnly = true;

                grdPesquisarMulta.AllowUserToAddRows = false;
                grdPesquisarMulta.AllowUserToDeleteRows = false;
                grdPesquisarMulta.RowHeadersVisible = false;

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
                grdPesquisarAluguel.Rows.Clear();

                AluguelAction aluguelAction = new AluguelAction();


                var lista = aluguelAction.Lista(txtPesquisarDataAluguel.Text);

                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        grdPesquisarAluguel.Rows.Add();

                        grdPesquisarAluguel.Rows[i].Cells["selecionar"].Value = "Exibir";
                        grdPesquisarAluguel.Rows[i].Cells["idAluguel"].Value = lista[i].IdAluguel.ToString();
                        grdPesquisarAluguel.Rows[i].Cells["nome"].Value = lista[i].NomeCliente.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        public void btnPesquisarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                grdPesquisarMulta.Rows.Clear();

                MultaAction multaAction = new MultaAction();


                var lista = multaAction.Lista(txtPesquisarMulta.Text);

                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        grdPesquisarMulta.Rows.Add();

                        grdPesquisarMulta.Rows[i].Cells["selecionar"].Value = "Exibir";
                        grdPesquisarMulta.Rows[i].Cells["idMulta"].Value = lista[i].idMulta.ToString();
                        grdPesquisarMulta.Rows[i].Cells["dataMulta"].Value = lista[i].dataMulta.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        private void grdPesquisarMulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdPesquisarAluguel.RowCount > 0)
                {
                    if (e.RowIndex > -1 && grdPesquisarAluguel.Rows[e.RowIndex].Cells["selecionar"].Selected)
                    {
                        var idMulta = grdPesquisarAluguel.Rows[e.RowIndex].Cells["idMulta"].Value.ToString();
                        ExibirMulta(Convert.ToInt32(idMulta));
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
                if (grdPesquisarAluguel.RowCount > 0)
                {
                    if (e.RowIndex > -1 && grdPesquisarAluguel.Rows[e.RowIndex].Cells["selecionar"].Selected)
                    {
                        var idAluguel = grdPesquisarAluguel.Rows[e.RowIndex].Cells["idAluguel"].Value.ToString();
                        ExibirAluguel(Convert.ToInt32(idAluguel));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }


        private void ExibirMulta(int idMulta)
        {
            try
            {
                MultaAction multaAction = new MultaAction();

                var multa = multaAction.Detalhe(Convert.ToInt32(idMulta));

                _idAluguel = multa.idMulta;
                txtDataMulta.Text = multa.dataMulta;
                txtPrecoMulta.Text = multa.precoMulta.ToString();
                txtInfoMulta.Text = multa.infoMulta;

                cbmMulta.SelectedIndex = cbmMulta.FindStringExact(Convert.ToString(multa.idAluguel));


                tabControl1.SelectedTab = tabMulta;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        private void ExibirAluguel(int idAluguel)
        {
            try
            {
                AluguelAction aluguelAction = new AluguelAction();

                var aluguel = aluguelAction.Detalhe(Convert.ToInt32(idAluguel));

                _idAluguel = aluguel.IdCliente;
                txtDataAluguel.Text = aluguel.DataAluguel;
                txtDataDevAluguel.Text = aluguel.DataDevolucao;
                txtPrecoAluguel.Text = Convert.ToString(aluguel.Preco);


                cmbCliente.SelectedIndex = cmbCliente.FindStringExact(aluguel.NomeCliente);
                cmbVeiculo.SelectedIndex = cmbVeiculo.FindStringExact(aluguel.NomeVeiculo);

                tabControl1.SelectedTab = tabCadastroAluguel;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        public void btnNovo_Click(object sender, EventArgs e)
        {
            _idAluguel = 0;
            txtDataAluguel.Text = "";
            txtDataDevAluguel.Text = "";
            txtPrecoAluguel.Text = "";
            cmbCliente.SelectedIndex = -1;
            cmbVeiculo.SelectedIndex = -1;
        }

        public void btnNovo_ClickMulta(object sender, EventArgs e)
        {
            _idMulta = 0;
            txtDataMulta.Text = "";
            txtInfoMulta.Text = "";
            txtPrecoMulta.Text = "";
        }

        private void btnSalvarAluguel_Click(object sender, EventArgs e)
        {
            //AluguelAction aluguelAction = new AluguelAction
            try
            {
                var IdCliente = _funcoes.PegarIdCombo(cmbCliente);
                var IdVeiculo = _funcoes.PegarIdCombo(cmbVeiculo);

                if (ValidaCampos() == false)
                {
                    return;
                }

                AluguelAction aluguelAction = new AluguelAction();
                Aluguel aluguel = new Aluguel();

                aluguel.IdAluguel = Convert.ToInt32(_idAluguel);
                aluguel.Preco = Convert.ToInt32(txtPrecoAluguel.Text);
                aluguel.DataAluguel = txtDataAluguel.Text;
                aluguel.DataDevolucao = txtDataDevAluguel.Text;
                aluguel.IdCliente = IdCliente;
                aluguel.IdVeiculo = IdVeiculo;

                var retorno = aluguelAction.Salvar(aluguel);

                if (retorno)
                {
                    MessageBox.Show("Aluguel Cadastrado com Sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSalvarMulta_Click(object sender, EventArgs e)
        {
            //AluguelAction aluguelAction = new AluguelAction
            try
            {

                if (ValidaCampos() == false)
                {
                    return;
                }

                MultaAction multaAction = new MultaAction();
                Multa multa = new Multa();

                multa.idMulta = Convert.ToInt32(_idMulta);
                multa.idAluguel = Convert.ToInt32(_idAluguel);
                multa.dataMulta = txtDataMulta.Text;
                multa.precoMulta = Convert.ToInt32(txtPrecoMulta.Text);
                multa.infoMulta = txtInfoMulta.Text;

                var retorno = multaAction.Salvar(multa);

                if (retorno)
                {
                    MessageBox.Show("Multa Cadastrado com Sucesso!", "Multa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo_Click(null, null);
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Houve um erro ao Salvar!", "Multa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                AluguelAction aluguelAction = new AluguelAction();

                var retorno = aluguelAction.Excluir(_idAluguel);

                if (retorno)
                {
                    MessageBox.Show("Aluguel Excluído com Sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtDataAluguel.Text == "")
            {
                MessageBox.Show("O nome do cliente precisa ser preenchido", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtDataDevAluguel.Text == "")
            {
                MessageBox.Show("O CPF do cliente precisa ser preenchido", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
