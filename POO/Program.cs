using POO.Classes;


// exemplo de classe (criacao e instanciacao)
List<Carro> carros = new List<Carro>();

for(int i = 0; i < 2; i++)
{
    Console.WriteLine("Digite a marca do carro.");
    string marca = Console.ReadLine();
    Console.WriteLine("Digite a modelo do carro.");
    string modelo = Console.ReadLine();
    Console.WriteLine("Digite a cor do carro.");
    string cor = Console.ReadLine();
    Console.WriteLine("Digite o ano de fabricação do carro.");
    int anoFabricacao = int.Parse(Console.ReadLine());
    Console.WriteLine();

     carros.Add(new Carro(marca, cor, modelo, anoFabricacao));
}

foreach(var item in carros)
{
    Console.WriteLine(item.MostrarInformacoes());
    Console.WriteLine();
}

// 4 Pilares de POO 
//Encapsulamento - esconde comportamentos e atributos
// o encapsulamento tambem ajuda o desenvolvedor a ditar as regras (exemplo: um metodo com uma condicao necessaria para alterar algum atributo) 
//heranca
//abstracao
//polimorfismo
