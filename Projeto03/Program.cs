using Projeto03.Controller;
using System;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadMain = 0; 

            while(loadMain == 0) 
            {
                
                Console.WriteLine("**************TELA DE CLIENTES**************");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Selecione a opçao desejada: ");
                Console.WriteLine("\t 1 - Criar novo Cliente.\n" +
                                  "\t 2 - Alterar endereco.\n" +
                                  "\t 3 - Exibir Cadastro na tela.\n" +
                                  "\t 0 - Sair.\n");

                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        ClienteController clienteController = new ClienteController();
                        clienteController.InsertCliente();
                        loadMain = 0;
                        break;

                    case 2:
                        EnderecoClontroller endControl = new EnderecoClontroller();
                        endControl.AtualizarEndereco();
                        loadMain = 0;
                        break;

                    case 3:
                        EnderecoClontroller exibir = new EnderecoClontroller();
                        exibir.ExibirEndereco();
                        loadMain = 0;
                        break;

                    case 0:
                        Console.WriteLine("O programa será fechado!");
                        loadMain = 1;
                        break;

                    default:
                        Console.WriteLine("Opcao invalida...");
                        loadMain = 0;
                        break;

                }
                Console.ReadLine();
                
            }
            


           


            
        }
    }
}
