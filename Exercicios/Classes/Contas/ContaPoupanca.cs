using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes.Contas
{
    class ContaPoupanca : ContaBancaria
    {
        public void RenderJuros()
        {
            _saldo *= 1.05;
        }
    }
}
