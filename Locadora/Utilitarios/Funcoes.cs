using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Utilitarios
{
    public class Funcoes
    {
        public static MySqlParameter ParametrosInsercao(object valor, string nome, DbType tipoDb)
        {
            try
            {
                var myParam = new MySqlParameter();

                myParam.Value = valor;
                myParam.ParameterName = nome;
                myParam.DbType = tipoDb;

                return myParam;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ComboBox PreencheCombo(ComboBox comboBox, string colunaId, string colunaNome, string tabela)
        {
             Conexao con = new Conexao();

            try
            {
                con.OpenConnection();

                comboBox.Items.Clear();
            
                con.Comando.Parameters.Clear();
                con.Comando.CommandText = " SELECT " + colunaId + " AS 'colunaId', " + colunaNome + " AS 'colunaNome' FROM " + tabela;

                var dt = con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Item item = new Item();

                        comboBox.DisplayMember = "Text";
                        comboBox.ValueMember = "Value";

                        item.Text = dt.Rows[i]["colunaNome"].ToString();
                        item.Value = Convert.ToInt32(dt.Rows[i]["colunaId"].ToString());

                        comboBox.Items.Add(new { Text = item.Text, Value = item.Value });
                    }
                }

                return comboBox;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
        }

        public int PegarIdCombo(ComboBox combo)
        {
            int id = 0;

            try
            {
                var valorCombo = combo.SelectedItem.ToString();
                string[] teste = valorCombo.Split('=');

                id = Convert.ToInt32(teste[2].Replace("}", "").Trim());

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
                return 0;
            }
        }
    }
}
