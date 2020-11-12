using Newtonsoft.Json;
using Projeto02.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projeto02.Service
{
    public class FuncionarioService
    {
        private static string path = "C:\\Users\\Luana\\source\\repos\\JohnClasses\\Projeto02\\Persistence\\";
        private static string txtFile = path + "funcionario.txt";
        private static string jsonFile = path + "funcionario.json";
        private static string xmlFile = path + "funcionario.xml";
        
        public void ExportarTxt(Funcionario funcionario)
        {
            using (StreamWriter streamWriter = new StreamWriter(txtFile, true))
            {
                streamWriter.WriteLine("Cód:" + funcionario.IdFuncionario);
                streamWriter.WriteLine($"Nome: {funcionario.Nome}");
                streamWriter.WriteLine($"Salario: {funcionario.Salario}");
                streamWriter.WriteLine($"Data de Admissao: {funcionario.DataAdmissao}");
                streamWriter.WriteLine("********************************************\n");
            }
        }

        public void ExportarJson(Funcionario funcionario)
        {
            List<Funcionario> jsonData = new List<Funcionario>();

            if(LerArquivoJson() != null)
            {
                jsonData = LerArquivoJson();
            }

            jsonData.Add(funcionario);

            using (StreamWriter writer = new StreamWriter(jsonFile))
            {
                string dados = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                writer.WriteLine(dados);
            }
        }

        public void ExportarXml(Funcionario funcionario)
        {
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            XElement root = new XElement("funcionarios");
            XElement child = new XElement("funcionario");
            child.Add(new XElement("idFuncionario", funcionario.IdFuncionario));
            child.Add(new XElement("nome", funcionario.Nome));
            child.Add(new XElement("salario", funcionario.Salario));
            child.Add(new XElement("dataAdmissao", funcionario.DataAdmissao));
            root.Add(child);

            if (File.Exists(xmlFile))
            {
                doc = XDocument.Load(xmlFile);
                var result = doc.Descendants("funcionarios");
                result.Last().Add(child);
            }
            else
            {
                doc.Add(root);
            }

            doc.Save(xmlFile);
        }

        public string LerArquivoTxt()
        {
            using (StreamReader sr = new StreamReader(txtFile))
            {
                string content = sr.ReadToEnd();
                return content;
            }
        }

        public List<Funcionario> LerArquivoJson()
        {
            if(!File.Exists(jsonFile)) return null;
            
            using (StreamReader sw = new StreamReader(jsonFile))
            {
                string json = sw.ReadToEnd();
                List<Funcionario> funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json);
                return funcionarios;
            }
        }

        public List<Funcionario> LerArquivoXml()
        {
            XDocument xdoc = XDocument.Load(xmlFile);
            List<Funcionario> result = (from q in xdoc.Descendants("funcionario")
                         select new Funcionario
                         {
                             IdFuncionario = int.Parse(q.Element("idFuncionario").Value),
                             Nome = q.Element("nome").Value,
                             Salario = decimal.Parse(q.Element("salario").Value),
                             DataAdmissao = DateTime.Parse(q.Element("dataAdmissao").Value)
                         }).ToList();

            return result;
        }
    }
}
