using cafezito.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafezito.model
{
    internal class ComprarDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public ComprarDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public bool Insert(Comprar comprar)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Comprar VALUES 
            (@tipodecafe, @acompanhamento)";

            
            Command.Parameters.AddWithValue("@tipodecafe", comprar.Tiposdecafe);
            Command.Parameters.AddWithValue("@acompanhamento", comprar.Acompanhamento);
           
            
            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "café no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
            return true;
        }


        public void Update(Comprar comprar)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Comprar SET 
            Tipodecafe = tiposdecafe,
            Acompanhamento = @acompanhamento";

            Command.Parameters.AddWithValue("@tipodecafe", comprar.Tiposdecafe);
            Command.Parameters.AddWithValue("@acompanhamento", comprar.Acompanhamento);
           
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização dos dados do " +
                    "Café no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int codcomprar)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Comprar
            WHERE Codcomprar = @codcomprar";
            Command.Parameters.AddWithValue("@codcomprar", codcomprar);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "cadastro do café do banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Comprar> ListAllBrokers()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Comprar";

            List<Comprar> brokers = new List<Comprar>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Comprar comprar = new Comprar(
    
                        (string)rd["Tipodecafe"],
                        (string)rd["Acompanhamentos"]
                        );
                    comprar.Add(comprar);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de Compra no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return brokers;
        }
       
        }
    }

