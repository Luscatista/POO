using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
    class Produto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public double CalcularTotal()
        {
            return QuantidadeEmEstoque * Preco;
        }

        public string MostrarInformacoes() 
        { 
            return $"O produto {Nome} que custa R${Preco} possui {QuantidadeEmEstoque} unidades em estoque.";
        }
    }
}
