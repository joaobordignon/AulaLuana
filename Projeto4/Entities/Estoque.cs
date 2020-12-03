using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class Estoque : Produto
    {

        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public DateTime Validade { get; set; }
        public DateTime ProximaEntrega { get; set; }

        public Estoque(int quantidade, string lote, DateTime validade, DateTime proximaEntrega)
        {
            Quantidade = quantidade;
            Lote = lote;
            Validade = validade;
            ProximaEntrega = proximaEntrega;
        }

        public Estoque()
        {

        }


    }
}
