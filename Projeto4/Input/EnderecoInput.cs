using Projeto4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Input
{
    public class EnderecoInput
    {
        public static string LerLogradouroEndereco()
        {
            Console.Write("Informe o Logradouro do Endereco................: ");
            return Console.ReadLine();
        }

        public static string LerNumeroEndereco()
        {
            Console.Write("Informe o Numero do Endereco....................: ");
            return Console.ReadLine();
        }

        public static string LerComplementoEndereco()
        {
            Console.Write("Informe o Complemento do Endereco...............: ");
            return Console.ReadLine();
        }

        public static string LerBairroEndereco()
        {
            Console.Write("Informe o Bairro do Endereco....................: ");
            return Console.ReadLine();
        }

        public static string LerCidadeEndereco()
        {
            Console.Write("Informe a Cidade do Endereco....................: ");
            return Console.ReadLine();
        }

        public static string LerEstadoEndereco()
        {
            Console.Write("Informe o Estado do Endereco....................: ");
            return Console.ReadLine();
        }

        public static string LerCepEndereco()
        {
            Console.Write("Informe o CEP do Endereco.......................: ");
            return Console.ReadLine();
        }

        public static Endereco LerEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = LerLogradouroEndereco();
            endereco.Numero = LerNumeroEndereco();
            endereco.Complemento = LerComplementoEndereco();
            endereco.Bairro = LerBairroEndereco();
            endereco.Cidade = LerCidadeEndereco();
            endereco.Estado = LerEstadoEndereco();
            endereco.Cep = LerCepEndereco();
            return endereco;
        }
    }
}
