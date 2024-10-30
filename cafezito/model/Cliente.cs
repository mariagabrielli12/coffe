using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace cafezito.model
{
    internal class Cliente
    {
        public int CodCliente { get; set; }

          public string Usuario { get; set; }
          public string Senha { get; set; }
        

        public Cliente(string usuario, string senha) {

            
          
            Usuario = usuario;
            Senha = senha;
            
           

        
        }

     
    }
}
