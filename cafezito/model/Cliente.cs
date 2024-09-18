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
           public int CodCafezito { get; set; }
           public string Objective {  get; set; }
          public float Preco { get; set; }
          public string Descricao { get; set; }
          public string Produto { get; set; }
        public float Quantidade { get; set; }

        public Cliente(string objective, float preco, string descricao, string produto, float quantidade) {

            Objective = objective;
            Preco = preco;
            Descricao = descricao;
            Produto = produto;
            Quantidade = quantidade;
        
        }
    }
}
