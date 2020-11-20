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
                            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
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
                
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
    }

}
