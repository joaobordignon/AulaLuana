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
               
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void AtualizarEndereco()
        {
            Console.WriteLine("\n****ALTERAR ENDERECO DE CLIENTE****");
            Console.WriteLine("-------------------------------------");
            try
            {
                int lerIdEndereco = EndrecoInput.LerIdEndereco();
                Endereco altEnd = EndrecoInput.CadastroEndereco();
                altEnd.IdEndereco = lerIdEndereco;
                EnderecoRepository altRepository = new EnderecoRepository();
                altRepository.Update(altEnd);

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void ExibirEndereco()
        {
            Endereco obj = new Endereco();
            obj.IdEndereco = EndrecoInput.LerIdEndereco();
            EnderecoRepository repository = new EnderecoRepository();
            repository.Load(obj);
            EndrecoInput.PrintEndereco(obj);
        }
    }
}
