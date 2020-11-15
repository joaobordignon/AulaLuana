using Projeto03.Entity;
using Projeto03.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Service
{
    public class ClienteService
    {
        public void Insert(Cliente cliente)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.Insert(cliente);
            if(cliente.Endereco != null) 
            {
                cliente.Endereco.IdCliente = cliente.IdCliente;
                EnderecoService service = new EnderecoService();
                service.Insert(cliente.Endereco);
                Console.WriteLine("Cadastro completo efetuado com sucesso!\n" +
                    "Cliente ID: "+ cliente.IdCliente);
            }
            else 
            {
                Console.WriteLine("Cliente Cadastrado com sucesso!");
            }
            
        }
    }
}
