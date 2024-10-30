using cafezito.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafezito.model
{
    internal class ClienteDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        public ClienteDAO() //sempre o nome da classe
        {
            Connect = new Connection();
            Command = new SqlCommand();

        }
        public void insert(Cliente cli)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Usuario VALUES 
             (
              @Usuario,@Senha)";
            ;
            Command.Parameters.AddWithValue("@Usuario", cli.Usuario);
            Command.Parameters.AddWithValue("@Senha", cli.Senha);



            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " + "imóvel no Banco.\n" + err.Message);
            }

            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Inserir(Cliente cli)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO cliente VALUES (@usuario, 
    @senha)";

            Command.Parameters.AddWithValue("@usuario", cli.Usuario);
            Command.Parameters.AddWithValue("@senha", cli.Senha);
           

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Atualizar(Cliente cliatualizado)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Clientes SET usuario = @usuario, Senha = @senha,
    WHERE Codcliente = @codcliente";
            Command.Parameters.AddWithValue("@usuario", cliatualizado.Usuario);
            Command.Parameters.AddWithValue("@senha", cliatualizado.Senha);
            Command.Parameters.AddWithValue("@codcliente", cliatualizado.CodCliente);
            
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int codcliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM cliente WHERE Id = @id";
            Command.Parameters.AddWithValue("@id", codcliente);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Cliente> ListarTodosClientes()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuarios";

            List<Cliente> listaDeClientes = new List<Cliente>(); //Instancio a lista com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Cliente cli = new Cliente((string)rd["usuario"],(string)rd["senha"]); 

                    listaDeClientes.Add(cli);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
            return listaDeClientes;
        }
    }
}