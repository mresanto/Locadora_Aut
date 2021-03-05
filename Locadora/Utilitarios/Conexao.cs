﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Utilitarios
{
    class Conexao
    {
        private MySqlCommand _command;
        private MySqlConnection _connection;
        private MySqlTransaction _myTransaction;

        public Conexao()
        {
            string ConnectionString = "Server=localhost;Port=3306;Database=db_locadora;Uid=sa;Pwd=1234567;";

            _connection = new MySqlConnection(ConnectionString);
            _command = new MySqlCommand();
            _command.Connection = _connection;
        }
        public MySqlCommand Comando
        {
            get { return _command; }
            set { _command = value; }
        }

        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool OpenTransaction()
        {
            try
            {
                _myTransaction = _connection.BeginTransaction();
                Comando.Transaction = _myTransaction;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool RollBackTransaction()
        {
            try
            {
                _myTransaction.Rollback();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CommitTransaction()
        {
            try
            {
                _myTransaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ExecutaComandoDataTable()
        {
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();

                myDataAdapter.Fill(dt);
                myDataAdapter.Dispose();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
