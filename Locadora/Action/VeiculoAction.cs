using Locadora.Classes;
using Locadora.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Action
{
    class VeiculoAction
    {
        private Conexao _con = new Conexao();

        public Veiculo Detalhe(int idVeiculo)
        {
            try
            {
                var veiculo = new Veiculo();

                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText =      "SELECT id_veiculo, nome_veiculo, cor_veiculo, info_veiculo, disponibilidade"
                                                +" FROM veiculo"
                                                + " where id_veiculo = @id_veiculo;";

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idVeiculo, "@id_veiculo", DbType.Int32));

                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        veiculo.IdVeiculo = Convert.ToInt32(dt.Rows[0]["id_veiculo"].ToString());
                        veiculo.Nome = dt.Rows[0]["nome_veiculo"].ToString();
                        veiculo.Cor = dt.Rows[0]["cor_veiculo"].ToString();
                        veiculo.Info = dt.Rows[0]["info_veiculo"].ToString();
                        veiculo.Dis = Convert.ToBoolean(dt.Rows[0]["disponibilidade"].ToString());

                    }
                }

                return veiculo;

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
            finally
            {
                _con.CloseConnection();
            }
        }

        public List<Veiculo> Lista(string nome)
        {
            try
            {
                _con.OpenConnection();

                var listaVeiculo = new List<Veiculo>();

                _con.Comando.Parameters.Clear();
                _con.Comando.CommandText = "SELECT id_veiculo, nome_veiculo, cor_veiculo, info_veiculo, disponibilidade"
                                                + " FROM veiculo";
                if (nome != "")
                {
                    _con.Comando.CommandText += " WHERE nome_veiculo LIKE '%" + nome + "%'";

                    //_con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(nome, "@nome_cliente", DbType.String));
                }

                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var veiculo = new Veiculo();

                        veiculo.IdVeiculo = Convert.ToInt32(dt.Rows[i]["id_veiculo"].ToString());
                        veiculo.Nome = dt.Rows[i]["nome_veiculo"].ToString();
                        veiculo.Cor = dt.Rows[i]["cor_veiculo"].ToString();
                        veiculo.Info = dt.Rows[i]["info_veiculo"].ToString();
                        veiculo.Dis = Convert.ToBoolean(dt.Rows[i]["disponibilidade"].ToString());

                        listaVeiculo.Add(veiculo);
                    }
                }

                return listaVeiculo;

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
            finally
            {
                _con.CloseConnection();
            }

        }

        public bool Salvar(Veiculo veiculo)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                if (veiculo.IdVeiculo == 0)
                {
                    _con.Comando.CommandText = "INSERT INTO veiculo (nome_veiculo, cor_veiculo, info_veiculo, disponibilidade)"
                                                + "Values (@nome_veiculo, @cor_veiculo, @info_veiculo, @disponibilidade);";
                }
                else
                {
                    _con.Comando.CommandText = "UPDATE veiculo SET nome_veiculo=@nome_veiculo, cor_veiculo=@cor_veiculo," +
                                                "info_veiculo=@info_veiculo, disponibilidade=@disponibilidade WHERE id_veiculo = @id_veiculo";

                    _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(veiculo.IdVeiculo, "@id_veiculo", DbType.Int32));
                }

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(veiculo.Nome, "@nome_veiculo", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(veiculo.Cor, "@cor_veiculo", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(veiculo.Info, "@info_veiculo", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(veiculo.Dis, "@disponibilidade", DbType.Boolean));


                _con.Comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + this.GetType().Name + " - " + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
            finally
            {
                _con.CloseConnection();
            }
        }

        public bool Excluir(int idVeiculo)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = "DELETE FROM veiculo WHERE id_veiculo = @id_veiculo";

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idVeiculo, "@id_veiculo", DbType.Int32));

                _con.Comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + this.GetType().Name + " - " + MethodBase.GetCurrentMethod().ToString() + "]: " + ex.Message);
            }
            finally
            {
                _con.CloseConnection();
            }
        }

    }
}
