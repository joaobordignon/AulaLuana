using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Entity
{
    public class Pessoa
    {
        #region Atributos
        private string nome;
        private DateTime dataNascimento;
        #endregion

        #region Construtores
        public Pessoa()
        {

        }
        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }
        #endregion

        #region Encapsulamentos
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        #endregion
    }
}
