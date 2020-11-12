using Projeto02.Entity;
using Projeto02.Input;
using Projeto02.Output;
using Projeto02.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = FuncionarioInput.LerFuncionario();
            Funcionario f2 = FuncionarioInput.LerFuncionario();
            Funcionario f3 = FuncionarioInput.LerFuncionario();

            FuncionarioService fs = new FuncionarioService();

            fs.ExportarTxt(f1);
            fs.ExportarTxt(f2);
            fs.ExportarTxt(f3);

            fs.ExportarJson(f1);
            fs.ExportarJson(f2);
            fs.ExportarJson(f3);
            
            fs.ExportarXml(f1);
            fs.ExportarXml(f2);
            fs.ExportarXml(f2);

            string conteudoTxt = fs.LerArquivoTxt();
            List<Funcionario> conteudoJson = fs.LerArquivoJson();
            List<Funcionario> conteudoXml = fs.LerArquivoXml();

            FuncionarioOutput.ExibirTxt(conteudoTxt);
            FuncionarioOutput.ExibirJson(conteudoJson);
            FuncionarioOutput.ExibirXml(conteudoXml);

            Console.ReadKey();
        }
    }
}
