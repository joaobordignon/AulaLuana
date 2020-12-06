using Projeto4.Entities;
using Projeto4.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Controller
{
    public class PessoaFisicaController
    {
        public void InserirPessoaFisica()
        {
            Console.WriteLine("Cadastro Cliente - Pessoa Fisica:");
            PessoaFisica pf = PessoaFisicaInput.LerPessoaFisica();            
        }
    }
}
