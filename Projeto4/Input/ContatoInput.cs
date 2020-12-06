using Projeto4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Input
{
    public class ContatoInput
    {
        public static string LerNomeContato()
        {
            Console.Write("Informe o Nome do contato...................: ");
            return Console.ReadLine();
        }

        public static string LerTelefoneContato()
        {
            Console.Write("Informe o Telefone do contato...............: ");
            return Console.ReadLine();
        }

        public static string LerCelularContato()
        {
            Console.Write("Informe o Celular do contato................: ");
            return Console.ReadLine();
        }

        public static string LerEmailContato()
        {
            Console.Write("Informe o Email do contato..................: ");
            return Console.ReadLine();
        }

        public static Contato LerContato()
        {
            Contato contato = new Contato();
            contato.NomeContato = LerNomeContato();
            contato.Telefone = LerTelefoneContato();
            contato.Celular = LerCelularContato();
            contato.Email = LerEmailContato();
            return contato;
        }
    }
}
