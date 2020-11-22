using Projeto03.Controller;
using Projeto03.Entity;
using Projeto03.Input;
using System;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController controller = new ClienteController();
            
            int loadMain = 0;

            while (loadMain == 0)
            {
                Console.Clear();
                Console.WriteLine("**************TELA DE CLIENTES**************");
                Console.WriteLine("--------------------------------------------\n" +
                                  "********************MENU********************\n");
                
                Console.WriteLine("\t 1 - Criar novo Cliente.\n" +
                                  "\t 2 - Alterar Cadastro Cliente \n" +
                                  "\t 3 - Consultar Cliente por ID.\n" +
                                  "\t 4 - Apagar Cliente por ID.\n" +
                                  "\t 9 - Sair.\n");
                Console.Write(    "Selecione a opçao desejada.................: ");
                int menu = int.Parse(Console.ReadLine());
              
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Cadastrar Cliente:");
                        controller.InsertCliente();
                        loadMain = 0;
                        break;

                    case 2:
                        Console.WriteLine("Atualizar Cliente:");
                        controller.UpdateById();
                        loadMain = 0;
                        break;

                    case 3:
                        Console.WriteLine("Consultar Cliente:");
                        controller.SelectById();
                        loadMain = 0;
                        break;

                    case 4:
                        Console.WriteLine("Consultar Cliente:");
                        controller.DeleteById();
                        loadMain = 0;
                        break;

                    case 9:
                        Console.WriteLine("O programa será fechado!");
                        loadMain = 1;
                        break;

                    default:
                        Console.WriteLine("Opcao invalida...");
                        Console.WriteLine("Pressione ENTER para voltar ao menu inicial\n");
                        Console.ReadKey();
                        loadMain = 0;
                        break;

                }
                

            }

            Console.ReadKey();







             
                   


           


            
        }
    }
}
