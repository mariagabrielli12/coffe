using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cafezito.Controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022439bdcafezito";
        private string Server = "sqlexpress";
        private string username = "aluno";
        private string Password = "aluno";

        public Connection()
        {

            string stringConnection = @"Data Source = " + Server
            + "; Intial Catalog = " + DataBase
            + "; User Id = " + username
            + "; Password = " + Password
            + "; encrypt = false";
            //string stringConnection Source =" + Environment.Machine + @ "\sqlexpres; Initial Catalog =" + DataBase + ";

            con = new SqlConnection(stringConnection);
            con.Open(); // abrir a conexão com o banco de dados

            //tenta fechar a conexão com o banco
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //Retorna a conexão que foi berta

        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}

    