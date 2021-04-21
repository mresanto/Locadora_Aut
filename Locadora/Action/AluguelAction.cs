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
    public class AluguelAction
    {
        private Conexao _con = new Conexao();

        public Aluguel Detalhe(int idAluguel)
        {
            try
            {
                var aluguel = new Aluguel();

                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = " select id_cliente, nome_cliente, id_veiculo, nome_veiculo, id_aluguel, preco_aluguel, data_aluguel, data_devolucao" +
                                           " FROM vw_aluguel" +
                                           " WHERE id_aluguel = @id_aluguel";


                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idAluguel, "@id_aluguel", DbType.Int32));

                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {

                        aluguel.IdAluguel = Convert.ToInt32(dt.Rows[0]["id_aluguel"].ToString());
                        aluguel.IdCliente = Convert.ToInt32(dt.Rows[0]["id_cliente"].ToString());
                        aluguel.IdVeiculo = Convert.ToInt32(dt.Rows[0]["id_veiculo"].ToString());
                        aluguel.NomeCliente = dt.Rows[0]["nome_cliente"].ToString();
                        aluguel.NomeVeiculo = dt.Rows[0]["nome_veiculo"].ToString();
                        aluguel.Preco = Convert.ToInt32(dt.Rows[0]["preco_aluguel"].ToString());
                        aluguel.DataAluguel = dt.Rows[0]["data_aluguel"].ToString();
                        aluguel.DataDevolucao = dt.Rows[0]["data_devolucao"].ToString();
                    }
                }

                return aluguel;
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

        public List<Aluguel> Lista(string nome)
        {
            try
            {
                _con.OpenConnection();

                var listaAluguel= new List<Aluguel>();

                _con.Comando.Parameters.Clear();
                _con.Comando.CommandText =  " select id_cliente, nome_cliente, id_veiculo, nome_veiculo, id_aluguel, preco_aluguel, data_aluguel, data_devolucao" +
                                            " FROM vw_aluguel";
                if(nome != "")
                {
                    _con.Comando.CommandText += " WHERE nome_cliente LIKE '%" + nome + "%'";

                }
                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        var aluguel = new Aluguel();
                        aluguel.IdAluguel = Convert.ToInt32(dt.Rows[i]["id_aluguel"].ToString());
                        aluguel.IdCliente = Convert.ToInt32(dt.Rows[i]["id_cliente"].ToString());
                        aluguel.IdVeiculo = Convert.ToInt32(dt.Rows[i]["id_veiculo"].ToString());
                        aluguel.NomeCliente = dt.Rows[i]["nome_cliente"].ToString();
                        aluguel.NomeVeiculo = dt.Rows[i]["nome_veiculo"].ToString();
                        aluguel.Preco = Convert.ToInt32(dt.Rows[i]["preco_aluguel"].ToString());
                        aluguel.DataAluguel = dt.Rows[i]["data_aluguel"].ToString();
                        aluguel.DataDevolucao = dt.Rows[i]["data_devolucao"].ToString();

                        listaAluguel.Add(aluguel);
                    }
                }

                return listaAluguel;

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
        
        public bool Salvar (Aluguel aluguel)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();
                
                if (aluguel.IdAluguel == 0)
                {
                    _con.Comando.CommandText = "INSERT INTO aluguel (preco_aluguel, data_aluguel, data_devolucao, fk_id_cliente, fk_id_veiculo)" +
                                               " VALUES ( @preco_aluguel, @data_aluguel, @data_devolucao, @fk_id_cliente, @fk_id_veiculo)";
                }
                else
                {
                    _con.Comando.CommandText = "UPDATE aluguel SET id_aluguel=@id_aluguel, preco_aluguel=@preco_aluguel, data_aluguel=@data_aluguel, data_devolucao=@data_devolucao, estado_aluguel = @estado_aluguel, fk_id_cliente = @id_cliente, fk_id_veiculo = @id_veiculo" +
                                               "WHERE id_aluguel = @id_aluguel";

                    _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(aluguel.IdAluguel, "@id_aluguel", DbType.Int32));
                }
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(aluguel.Preco, "@preco_aluguel", DbType.Int32));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(aluguel.DataAluguel, "@data_aluguel", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(aluguel.DataDevolucao, "@data_devolucao", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(aluguel.IdCliente, "@fk_id_cliente", DbType.Int32));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(aluguel.IdVeiculo, "@fk_id_veiculo", DbType.Int32));

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
        public bool Excluir (int IdAluguel)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = "DELETE FROM aluguel WHERE id_aluguel = @id_aluguel";

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(IdAluguel, "@id_aluguel", DbType.Int32));

                _con.Comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao tentar realizar uma operação [" + this.GetType().Name + " - " + MethodBase.GetCurrentMethod().ToString() + "]" + ex.Message);
            }
            finally
            {
                _con.CloseConnection();
            }
        }
    }
}
