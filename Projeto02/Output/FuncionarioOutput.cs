using Projeto02.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Output
{
    public class FuncionarioOutput
    {
        public static void ExibirTxt(string conteudoTxt)
        {
            Console.WriteLine(" -- Leitura do Txt -- ");
            Console.WriteLine(conteudoTxt);
        }
        
        public static void ExibirJson(List<Funcionario> conteudoJson)
        {
            Console.WriteLine(" -- Leitura do Json -- ");
            foreach (Funcionario f in conteudoJson)
            {
                Console.WriteLine("Código..............: " + f.IdFuncionario);
                Console.WriteLine("Nome................: " + f.Nome);
                Console.WriteLine("Salário.............: " + f.Salario);
                Console.WriteLine("Data de Admissão....: " + f.IdFuncionario);
                Console.WriteLine("\n");
            }
            Console.WriteLine("***********************");
        }
  
        public static void ExibirXml(List<Funcionario> conteudoXml)
        {
            Console.WriteLine(" -- Leitura do Xml -- ");
            foreach (Funcionario f in conteudoXml)
            {
                Console.WriteLine("Código..............: " + f.IdFuncionario);
                Console.WriteLine("Nome................: " + f.Nome);
                Console.WriteLine("Salário.............: " + f.Salario);
                Console.WriteLine("Data de Admissão....: " + f.IdFuncionario);
                Console.WriteLine("\n");
            }
            Console.WriteLine("***********************");
        } 
    }
}
