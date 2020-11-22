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
        ClienteRepository repository = new ClienteRepository();
        public void Insert(Cliente cliente)
        {
            
            repository.Insert(cliente);
            

        }

        public Cliente SelectById(int id)
        {
            
            Cliente cliente = repository.SelectById(id);
            return cliente;
            
        }

        public void UpdateById(int id, Cliente cliente)
        {

            repository.UpdatebyId(id, cliente);
           
        }

        public void DeleteById(int id)
        {
            repository.DeleteById(id);
        }
    }
}
