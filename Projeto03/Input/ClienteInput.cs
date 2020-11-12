using Projeto03.Entity;
using System;

namespace Projeto03.Input
{
    public class ClienteInput
    {
        public static int LerIdCliente()
        {
            Console.Write("Informe o código do cliente............: ");
            return int.Parse(Console.ReadLine());
        }

        public static string LerNome()
        {
            Console.Write("Informe o nome do cliente..............: ");
            return Console.ReadLine();
        }

        public static DateTime LerDataNascimento()
        {
            Console.Write("Informe a data de nascimento...........: ");
            return DateTime.Parse(Console.ReadLine());
        }

        public static string LerEmail()
        {
            Console.Write("Informe o email........................: ");
            return Console.ReadLine();
        }

        public static string LerTelefone()
        {
            Console.Write("Informe o telefone.....................: ");
            return Console.ReadLine();
        }
        public static Cliente LerCliente()
        {
            string email = LerEmail();
            Cliente c = new Cliente(email);
            c.Nome = LerNome();
            c.DataNascimento = LerDataNascimento();
            c.Telefone = LerTelefone();
            return c;
        }

        public static Cliente LerClienteEndereco()
        {
            Cliente c = LerCliente();
            c.Endereco = EndrecoInput.CadastroEndereco();
            return c;
        }

    }
}
