using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System;
using System.Configuration;

namespace SistemaFaltas.Recursos
{
    class Conexao
    {
        private OleDbConnection con = new();
        private OleDbTransaction transaction = null;
        private OleDbCommand cmd = new();

        public Conexao()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=D:\Projetos\SistemaFaltas\SistemaFaltas.accdb";            
        }

        private OleDbConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                cmd.Connection = con;
                transaction = con.BeginTransaction();
                cmd.Transaction = transaction;
            }
            return con;
        }

        private void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public bool ExecutaSql(string comandoSql)
        {
            try
            {
                Conectar();
                cmd.CommandText = comandoSql;
                cmd.ExecuteNonQuery();

                transaction.Commit();

                return true;
            }
            catch (OleDbException e)
            {
                MessageBox.Show("Erro ao Executar ação:/n " + e);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable ExecutaQuery(string comandoSql)
        {
            try
            {
                Conectar();
                cmd.CommandText = comandoSql;                

                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Load(reader);

                transaction.Commit();

                return dt;                
            }
            catch (OleDbException e)
            {
                MessageBox.Show("Erro ao Executar ação:/n " + e);

                try
                {                    
                    transaction.Rollback();
                }
                catch
                {
                    
                }

                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public int QueryRetornaId(string comandoSql) 
        {
            int ret = -1;

            try
            {
                Conectar();
                cmd.CommandText = comandoSql;
                
                if (cmd.ExecuteNonQuery() == 1)
                {
                    cmd.CommandText = "Select @@Identity";

                    ret = Convert.ToInt32(cmd.ExecuteScalar());
                }
                transaction.Commit();
            }
            catch (OleDbException )
            {                
                try
                {                    
                    transaction.Rollback();
                }
                catch
                {
                    
                }
                throw;                
            }
            finally
            {
                Desconectar();
            }

            return ret;
        }
    }
}

