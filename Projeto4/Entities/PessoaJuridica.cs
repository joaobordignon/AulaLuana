using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

        public PessoaJuridica(string razaoSocial, Contato comercial, string cnpj, string inscricaoEstadual, Endereco endereco)
            :base (comercial, endereco)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }
        public PessoaJuridica()
            :base()
        {

        }
    }
}
