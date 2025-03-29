using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Classes.Funcionarios;

namespace Exercicios.Classes;

class Gerente : Funcionario
{
    public void Bonificar()
    {
        _salario *= 1.1;
    }
}
