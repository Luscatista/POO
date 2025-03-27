using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    public Livro(string titulo, string autor, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        Paginas = paginas;
    }

    public string MostrarInformacoes()
    {
        return $"O livro {Titulo} do autor {Autor} possui {Paginas} páginas.";
    }
}
