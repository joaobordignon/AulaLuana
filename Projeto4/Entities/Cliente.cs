using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class Cliente
    {
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente(Contato contato, Endereco endereco)
        {
            Contato = contato;
            Endereco = endereco;
        }

        public Cliente()
        {

        }



    }
}
