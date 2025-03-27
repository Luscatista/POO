﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
    class ContaBancaria
    {
        private double _saldo { get; set; } = 0;

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if(valor <= _saldo)
            {
            _saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public string VerSaldo()
        {
            return $"Seu saldo é: {_saldo}";
        }
    }
}
