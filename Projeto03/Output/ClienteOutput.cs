using Projeto03.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Output
{
    public class ClienteOutput
    {
        public static void ShowCliente(Cliente cliente)
        {
            Console.WriteLine("\tNome.......................: " + cliente.Nome);
            Console.WriteLine("\tEmail......................: " + cliente.Email);
            Console.WriteLine("\tNascimento.................: " + cliente.DataNascimento);
            Console.WriteLine("\tTel........................: " + cliente.Telefone);
            Console.WriteLine("\tID.........................: " + cliente.IdCliente);
            Console.WriteLine("\n");


        }
        
    }
}
