using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes.Carros
{
    class Carro
    {
        public string Marca;
        public string Cor;
        public string Modelo;
        public int AnoFabricacao;

        public string Andar()
        {
            return "O carro esta andando!!";
        }
        public string Parar()
        {
            return "O carro esta parado!!";
        }
        public virtual string MostrarInformacoes()
        {
            return $" O carro é um {Modelo}, sua cor é {Cor}, marca {Marca} e seu ano de fabricação é {AnoFabricacao}.";
        }
    }
}
