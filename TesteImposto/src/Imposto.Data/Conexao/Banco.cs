using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Data.Conexao
{
    public class Banco
    {

        string conexao = @"Data Source=DESKTOP-S6C9UFP;Initial Catalog=TESTE;User ID=sa;password=elirweb";

        public SqlConnection conn;


        #region Classe de  Abrir conexao
        public void Conectar()
        {
            conn = new SqlConnection(conexao);
            try
            {

                conn.Open();

            }
            catch (SqlException e)
            {
                throw new Exception("Erro ao acessar o banco de dados" + e.Message);

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao se Conectar" + e.Message);
            }
        }
        #endregion

        public void Desconectar()
        {
            conn = new SqlConnection(conexao);
            try
            {
                conn.Close();
            }
            catch (SqlException e)
            {
                throw new Exception("Erro ao acessar o banco de dados" + e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao se Conectar" + e.Message);

            }
        }
    }
}


