using Exercicios.Classes;

Console.WriteLine("1 - Criando uma Classe \"Livro\" e Instanciando um Objeto");
Console.WriteLine();
Console.WriteLine("Crie uma classe chamada `Livro` com os seguintes atributos:\r\n");
Console.WriteLine("- `titulo` (tipo `string`)");
Console.WriteLine("- `autor` (tipo `string`)\r\n");
Console.WriteLine("- `paginas` (tipo `int`)\r\n");
Console.WriteLine();
Console.WriteLine("Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.\r\n");
Console.WriteLine();


Livro livro = new Livro("Água molhada", "Sabichão", 20);
Console.WriteLine(livro.MostrarInformacoes()); 
Console.WriteLine();


Console.WriteLine("2 - Criando e Utilizando um Objeto \"Aluno\"");
Console.WriteLine("Crie uma classe chamada `Aluno` com os seguintes atributos:\r\n");
Console.WriteLine("- `nome` (tipo `string`)\r\n");
Console.WriteLine("- `idade` (tipo `int`)\r\n");
Console.WriteLine("- `notaFinal` (tipo `double`)\r\n");
Console.WriteLine("Depois, crie dois objetos da classe `Aluno`, atribua valores a eles e exiba os detalhes de ambos.");
Console.WriteLine();

List<Aluno> alunos = new List<Aluno>();

for(int i = 0; i < 2; i++)
{
    Console.WriteLine("Digite o nome do aluno.");
    string nome = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Digite a idade do aluno.");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Digite a nota final do aluno.");
    double notaFinal = double.Parse(Console.ReadLine());
    Console.WriteLine();

    alunos.Add(new Aluno(nome, idade, notaFinal));

}

foreach(var aluno in alunos)
{
    Console.WriteLine(aluno.MostrarInformacoes());
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("3 - Criando uma Classe \"Produto\" e Trabalhando com Objetos");
Console.WriteLine("Crie uma classe chamada `Produto` com os seguintes atributos:\r\n");
Console.WriteLine("- `nome` (tipo `string`)\r\n");
Console.WriteLine("- `preco` (tipo `double`)\r\n");
Console.WriteLine("- `quantidadeEmEstoque` (tipo `int`)\r\n");
Console.WriteLine("Também crie o seguinte método:\r\n");
Console.WriteLine("- `CalcularTotal` que retorna o total da `quantidadeEmEstoque` *  `preco`\r\n");
Console.WriteLine("Depois, crie um objeto da classe `Produto`, altere os valores dos atributos e imprima as informações antes e depois da alteração, também imprima o resultado do método CalcularTotal.");
Console.WriteLine();

Produto produto = new Produto("Broca para furar vidros", 99.99, 1000);

Console.WriteLine(produto.MostrarInformacoes());
Console.WriteLine();

produto.Nome = "Desentupidor de fio elétrico";
produto.Preco = 512.99;
produto.QuantidadeEmEstoque = 2;

Console.WriteLine(produto.MostrarInformacoes());






