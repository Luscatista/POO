﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes;

class ContaCorrente : ContaBancaria
{
    public void CobrarTaxa()
    {
        _saldo -= 10;
    }

}
