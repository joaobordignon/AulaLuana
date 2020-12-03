using Projeto4.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public EnumContato TipoContato { get; set; }

        public Contato(string nome, string telefone, string email, EnumContato tipoContato)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            TipoContato = tipoContato;
        }

        public Contato()
        {

        }

    }
}
