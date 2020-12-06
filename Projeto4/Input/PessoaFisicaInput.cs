using Projeto4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Input
{
    public class PessoaFisicaInput
    {
        public static string LerNomePessoaFisica()
        {
            // Inserir IF (Deseja usar o Nome de Contato como nome de Cliente?)
            Console.Write("Informe o nome do cliente...............: ");
            return Console.ReadLine();
        }

        public static string LerCpfPessoaFisica()
        {
            Console.Write("Informe o CPF do cliente................: ");
            return Console.ReadLine();
        }

        public static PessoaFisica LerPessoaFisica()
        { 
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = LerNomePessoaFisica();
            pf.Cpf = LerCpfPessoaFisica();
            return pf;
        }
        
    }
}
