using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes.Carros;

class CarroEletrico : Carro
{
    public string BateriaMotor;
    public double TempoDeCarga { get; set; }

    public override string MostrarInformacoes()
    {
        return $" O carro é um {Modelo}," +
            $" sua cor é {Cor}," +
            $" marca {Marca}" +
            $" e seu ano de fabricação é {AnoFabricacao}." +
            $"E alem disso seu {BateriaMotor} precisa de {TempoDeCarga}horas para a recarga completa";
    }
}
