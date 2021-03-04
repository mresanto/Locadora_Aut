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
    public class ClienteAction
    {
        private Conexao _con = new Conexao();

        public Cliente Detalhe(int? idCliente)
        {
            try
            {
                var cliente = new Cliente();

                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = " SELECT" +
                                          " id_cliente, nome_cliente, cpf_cliente, cnh_cliente" +
                                          " FROM cliente" +
                                          " WHERE id_cliente = @id_cliente";

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idCliente, "@id_cliente", DbType.Int32));

                var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        cliente.IdCliente = Convert.ToInt32(dt.Rows[0]["id_cliente"].ToString());
                        cliente.Nome = dt.Rows[0]["nome_cliente"].ToString();
                        cliente.Cpf = dt.Rows[0]["cpf_cliente"].ToString();
                        cliente.Cnh = dt.Rows[0]["cnh_cliente"].ToString();

                    }
                }

                return cliente;

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

        public List<Cliente> Lista(string nome)
        {
            try
            {
                _con.OpenConnection();

                var listaCliente = new List<Cliente>();

                _con.Comando.Parameters.Clear();
                _con.Comando.CommandText = " SELECT" +
                                         " id_cliente, nome_cliente, cpf_cliente, cnh_cliente" +
                                         " FROM cliente";
                if (nome != "")
                {
                    _con.Comando.CommandText += " WHERE nome_cliente LIKE '%" + nome + "%'";

                    //_con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(nome, "@nome_cliente", DbType.String));
                }

               var dt = _con.ExecutaComandoDataTable();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var cliente = new Cliente();

                        cliente.IdCliente = Convert.ToInt32(dt.Rows[i]["id_cliente"].ToString());
                        cliente.Nome = dt.Rows[i]["nome_cliente"].ToString();
                        cliente.Cpf = dt.Rows[i]["cpf_cliente"].ToString();
                        cliente.Cnh = dt.Rows[i]["cnh_cliente"].ToString();

                        listaCliente.Add(cliente);
                    }
                }

                return listaCliente;

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

        public bool Salvar(Cliente cliente)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                if (cliente.IdCliente == 0)
                {
                    _con.Comando.CommandText = "INSERT INTO cliente (nome_cliente, cpf_cliente, cnh_cliente)" +
                                               " VALUES (@nome_cliente, @cpf_cliente, @cnh_cliente)";
                }
                else
                {
                    _con.Comando.CommandText = "UPDATE cliente SET nome_cliente=@nome_cliente, cpf_cliente=@cpf_cliente," +
                                                "cnh_cliente=@cnh_cliente WHERE id_cliente = @id_cliente";

                    _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(cliente.IdCliente, "@id_cliente", DbType.Int32));
                }

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(cliente.Nome, "@nome_cliente", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(cliente.Cpf, "@cpf_cliente", DbType.String));
                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(cliente.Cnh, "@cnh_cliente", DbType.String));

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

        public bool Excluir(int idCliente)
        {
            try
            {
                _con.OpenConnection();

                _con.Comando.Parameters.Clear();

                _con.Comando.CommandText = "DELETE FROM cliente WHERE id_cliente = @id_cliente";

                _con.Comando.Parameters.Add(Funcoes.ParametrosInsercao(idCliente, "@id_cliente", DbType.Int32));

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
