using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes;

class Retangulo
{
    private double _largura;
    private double _altura;

    public void SetLargura(double valor)
    {
        _largura = valor;
    }
    public double GetLargura()
    {
        return _largura;
    }
    public void SetAltura(double valor)
    {
        _altura = valor;
    }
    public double GetAltura()
    {
        return _altura;
    }
    public double CalcularArea()
    {
        return _largura * _altura;
    }
}
