using Projeto03.Entity;
using Projeto03.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Service
{
    public class EnderecoService
    {
        public void Insert(Endereco end)
        {
            EnderecoRepository repository = new EnderecoRepository();
            repository.InsertEnd(end);
        }
    }
}
