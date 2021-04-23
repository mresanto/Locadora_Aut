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
    class MultaAction
    {
        private Conexao _con = new Conexao();
        public Multa Detalhe(int idMulta)
        {
            try
            {
                var multa = new Multa();

                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = " SELECT" +
                                          " id_multa, date_format(data_multa, '%Y-%m-%d') as data_multa, preco_multa, info_multa, fk_id_aluguel" +
                                          " FROM multa" +
                                          " WHERE id_multa = @id_multa";
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idMulta, "@id_multa", DbType.Int32));

                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        multa.idMulta = Convert.ToInt32(dt.Rows[0]["id_multa"].ToString());
                        multa.data_multa = dt.Rows[0]["data_multa"].ToString();
                        multa.preco_multa = Convert.ToInt32(dt.Rows[0]["preco_multa"].ToString());
                        multa.info_multa = dt.Rows[0]["info_multa"].ToString();
                        multa.id_aluguel = Convert.ToInt32(dt.Rows[0]["fk_id_aluguel"].ToString());

                    }
                }

                return multa;

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
        public List<Multa> Lista(int id, int id_aluguel)
        {
            try
            {
                _con.OpenConnection();

                var listaMulta = new List<Multa>();

                _con.Comando.Parameters.Clear();
                _con.Comando.CommandText = "SELECT id_multa, data_multa, preco_multa, info_multa, fk_id_aluguel"
                                                + " FROM multa WHERE fk_id_aluguel = " + id_aluguel + " ";
                if (id != -1)
                {
                    _con.Comando.CommandText += " id_multa LIKE '%" + id + "%'";

                    //_con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(nome, "@nome_cliente", DbType.String));
                }

                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var multa = new Multa();

                        multa.idMulta = Convert.ToInt32(dt.Rows[i]["id_multa"].ToString());
                        multa.data_multa = dt.Rows[i]["data_multa"].ToString();
                        multa.preco_multa = Convert.ToInt32(dt.Rows[i]["preco_multa"].ToString());
                        multa.info_multa = dt.Rows[i]["info_multa"].ToString();
                        multa.id_aluguel = Convert.ToInt32(dt.Rows[i]["fk_id_aluguel"].ToString());

                        listaMulta.Add(multa);
                    }
                }

                return listaMulta;

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
        public bool Salvar(Multa multa)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                if (multa.idMulta == 0)
                {
                    _con.Comando.CommandText = "INSERT INTO multa (data_multa, preco_multa, info_multa, fk_id_aluguel)" +
                                               " VALUES (@data_multa, @preco_multa, @info_multa, @fk_id_aluguel)";
                }
                else
                {
                    _con.Comando.CommandText = "UPDATE multa SET data_multa=@data_multa, info_multa=@info_multa, preco_multa = @preco_multa" +
                                                " WHERE id_multa=@id_multa";

                    _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(multa.idMulta, "@id_multa", DbType.Int32));
                }

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(multa.data_multa, "@data_multa", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(multa.preco_multa, "@preco_multa", DbType.Int32));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(multa.info_multa, "@info_multa", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(multa.id_aluguel, "@fk_id_aluguel", DbType.Int32));

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
        public bool Excluir(int idMulta)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = "DELETE FROM multa WHERE id_multa = @id_multa";

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idMulta, "@id_multa", DbType.Int32));

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

