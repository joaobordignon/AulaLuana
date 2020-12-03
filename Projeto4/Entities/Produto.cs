using Projeto4.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4.Entities
{
    public class Produto
    {

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string UnidadeDeVenda { get; set; }
        public string Fabricante { get; set; }
        public EnumProduto TipoProduto { get; set; }
        public double PrecoDeVenda { get; set; }
        public Produto(int codigo, string descricao, string unidadeDeVenda, string fabricante, EnumProduto tipoProduto, double precoDeVenda)
        {
            Codigo = codigo;
            Descricao = descricao;
            UnidadeDeVenda = unidadeDeVenda;
            Fabricante = fabricante;
            TipoProduto = tipoProduto;
            PrecoDeVenda = precoDeVenda;
        }
        public Produto()
        {

        }

    }
}
