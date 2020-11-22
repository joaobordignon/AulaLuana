using Projeto03.Entity;
using Projeto03.Input;
using Projeto03.Output;
using Projeto03.Repository;
using Projeto03.Service;
using System;

namespace Projeto03.Controller
{
    public class ClienteController
    {
        public void InsertCliente()
        {
            Console.WriteLine("\n****CADASTRO DE CLIENTE****");
            try
            {
                Cliente cliente = ClienteInput.LerCliente();
                ClienteService clienteService = new ClienteService();
                clienteService.Insert(cliente);
                Console.WriteLine($"\nCliente {cliente.IdCliente} Cadastrado com sucesso!\n");
                Console.WriteLine("Pressione ENTER para voltar ao menu inicial\n");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
                Console.ReadKey();
            }
        }
        public void SelectById()
        {
            Console.WriteLine("\n****DADOS DO CLIENTE****");
            try
            {
                int id = ClienteInput.LerIdCliente();
                ClienteService clienteService = new ClienteService();
                Cliente cliente = clienteService.SelectById(id);
                ClienteOutput.ShowCliente(cliente);
                Console.WriteLine("Pressione ENTER para voltar ao menu inicial\n");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
                Console.ReadKey();
            }
        }

        public void UpdateById()
        {
            Console.WriteLine("\n****ATUALIZAR DADOS****");
            try
            {
                int id = ClienteInput.LerIdCliente();
                ClienteService clienteService = new ClienteService();
                Cliente cliente = ClienteInput.LerCliente();
                clienteService.UpdateById(id, cliente);
                Console.WriteLine($"\nCliente {id} Atualizado com sucesso!\n");
                Console.WriteLine("Pressione ENTER para voltar ao menu inicial\n");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
                Console.ReadKey();
            }
        }

        public void DeleteById()
        {
            Console.WriteLine("\n****DELETANDO CLIENTE****");
            try
            {
                int id = ClienteInput.LerIdCliente();
                ClienteService clienteService = new ClienteService();
                clienteService.DeleteById(id);
                Console.WriteLine($"\nCliente {id} Apagado com sucesso!\n");
                Console.WriteLine("Pressione ENTER para voltar ao menu inicial\n");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
                Console.ReadKey();
            }

        }
    }

}
