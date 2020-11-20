using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Entity
{
    public class Cliente : Pessoa
    {
        #region Atributos
        private int idCliente;
        private string email;
        private string telefone;
        
        #endregion

        #region Construtores
        public Cliente(string email)
        {
            this.email = email;
        }

        public Cliente(string nome, DateTime dataNascimento, string email, string telefone)
            : base(nome, dataNascimento)
        {
            this.email = email;
            this.telefone = telefone;
        }
        #endregion

        #region Encapsulamentos
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        
        #endregion
    }
}
