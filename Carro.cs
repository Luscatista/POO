using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public string Andar()
        {
            return "O carro esta andando!!";
        }
        public string Parar()
        {
            return "O carro esta parado!!";
        }
        public string MostrarInformacoes()
        {
            return $" O carro é um {Modelo} de cor {Cor} da marca {Marca} e seu ano de fabricação é {AnoFabricacao}.";
        }
    }
}
