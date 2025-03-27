using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double NotaFinal { get; set; }

    public Aluno(string nome, int idade, double notaFinal)
    {
        Nome = nome;
        Idade = idade;
        NotaFinal = notaFinal;
    }

    public string MostrarInformacoes()
    {
        return $"O aluno que se chama {Nome} com idade de {Idade} anos ficou com a nota final de {NotaFinal}.";
    }
}
