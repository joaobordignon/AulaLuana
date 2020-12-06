using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public PessoaFisica(string nome, string cpf, Contato contato, Endereco endereco)
            : base (contato, endereco)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public PessoaFisica()
            :base()
        {

        }
    }
}
