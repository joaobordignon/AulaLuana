using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class Cliente
    {
        public string RazaoSocial { get; set; }
        public Contato Comercial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        
        public Cliente(string razaoSocial, Contato comercial, string cnpj, string inscricaoEstadual)
        {
            RazaoSocial = razaoSocial;
            Comercial = comercial;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }
        public Cliente()
        {

        }

    }
}
