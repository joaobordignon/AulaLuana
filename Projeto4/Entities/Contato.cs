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
        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        

        public Contato(string telefone, string email, string celular, string nomeContato)
        {
            Telefone = telefone;
            Celular = celular;
            Email = email;
            NomeContato = nomeContato;
        }

        public Contato()
        {

        }

    }
}
