using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafezito.model
{
    internal class Comprar
    {
     
            public int CodCompra { get; set; }
            public string Tiposdecafe { get; set; }
            public string Acompanhamento { get; set; }


            public Comprar (string tiposdecafe, string acompanhamento)
            {



                Tiposdecafe = tiposdecafe;
                Acompanhamento = acompanhamento;




            }

        internal void Add(Comprar comprar)
        {
            throw new NotImplementedException();
        }
    }
    }

