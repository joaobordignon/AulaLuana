﻿using System;
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
        private Endereco endereco;
        #endregion

        #region Construtores
        public Cliente(string email)
        {
            this.email = email;
        }

        public Cliente(string nome, DateTime dataNascimento, string email, string telefone, Endereco endereco)
            : base(nome, dataNascimento)
        {
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }
        #endregion

        #region Encapsulamentos
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
        #endregion
    }
}
