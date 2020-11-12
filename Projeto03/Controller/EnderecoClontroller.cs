using Projeto03.Entity;
using Projeto03.Input;
using Projeto03.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Controller
{
    class EnderecoClontroller
    {
        public void InsertEnereco()
        {
            Console.WriteLine("\n****CADASTRO ENDERECO DE CLIENTE****");
            try
            {
                Endereco endereco = EndrecoInput.CadastroEndereco();                
                EnderecoRepository repository = new EnderecoRepository();
                repository.InsertEnd(endereco);
                Console.WriteLine("ENDERECO CLIENTE CADASTRADO COM SUCESSO.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
    }
}
