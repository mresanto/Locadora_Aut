using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Utilitarios
{
    class Funcoes
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
    }
}
