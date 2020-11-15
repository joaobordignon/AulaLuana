using Projeto03.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Input
{
    public class EndrecoInput
    {
        public static int LerIdEndereco()
        {
            Console.Write("Informe o código do endereco............: ");
            return int.Parse(Console.ReadLine());
        }

        public static string LerLogadouro()
        {
            Console.Write("Logradouro completo.....................: ");
            return Console.ReadLine();
        }

        public static string LerBairro()
        {
            Console.Write("Bairro..................................: ");
            return Console.ReadLine();
        }

        public static string LerCidade()
        {
            Console.Write("Cidade..................................: ");
            return Console.ReadLine();
        }

        public static string LerEstado()
        {
            Console.Write("Estado..................................: ");
            return Console.ReadLine();
        }

        public static string LerCep()
        {
            Console.Write("CEP.....................................: ");
            return Console.ReadLine();
        }

        public static Endereco CadastroEndereco()
        {
            Endereco end = new Endereco();
            end.Logradouro = LerLogadouro();
            end.Bairro = LerBairro();
            end.Cidade = LerCidade();
            end.Estado = LerEstado();
            end.Cep = LerCep();

            return end;
        }

        public static void PrintEndereco(Endereco obj)
        {
            Console.Write("código do endereco......................: " + obj.IdEndereco +
                          "***************************************** " +
                          "Logradouro..............................: " + obj.Logradouro +
                          "Bairro..................................: " + obj.Bairro +
                          "Cidade..................................: " + obj.Cidade +
                          "Estado..................................: " + obj.Estado +
                          "Cep.....................................: " + obj.Cep);
        }
    }
}
