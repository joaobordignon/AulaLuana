using Projeto4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Input
{
    public class PessoaJuridicaInput
    {
        public static string LerNomePessoaJuridica()
        {
            Console.Write("Informe a Razao Social do cliente...............: ");
            return Console.ReadLine();
        }

        public static string LerCnpjPessoaJuridica()
        {
            Console.Write("Informe o CNPJ do cliente......................: ");
            return Console.ReadLine();
        }

        public static string LerIePessoaJuridica()
        {
            Console.Write("Informe a Inscricao Estadual do cliente........: ");
            return Console.ReadLine();
        }

        public static PessoaJuridica LerPessoaJuridica()
        {
            PessoaJuridica pj = new PessoaJuridica();
            pj.RazaoSocial = LerNomePessoaJuridica();
            pj.Cnpj = LerCnpjPessoaJuridica();
            pj.InscricaoEstadual = LerIePessoaJuridica();
            return pj;
        }
    }
}
