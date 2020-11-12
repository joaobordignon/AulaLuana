using Projeto03.Controller;
using System;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController clienteController = new ClienteController();
            clienteController.InsertCliente();


            Console.ReadKey();
        }
    }
}
