using System;
using Exercicios.Classes;
using System.Globalization;

//Console.WriteLine("1 - Criando uma Classe \"Livro\" e Instanciando um Objeto");
//Console.WriteLine();
//Console.WriteLine("Crie uma classe chamada `Livro` com os seguintes atributos:\r\n");
//Console.WriteLine("- `titulo` (tipo `string`)");
//Console.WriteLine("- `autor` (tipo `string`)\r\n");
//Console.WriteLine("- `paginas` (tipo `int`)\r\n");
//Console.WriteLine();
//Console.WriteLine("Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.\r\n");
//Console.WriteLine();


//Livro livro = new Livro("Água molhada", "Sabichão", 20);
//Console.WriteLine(livro.MostrarInformacoes()); 
//Console.WriteLine();


//Console.WriteLine("2 - Criando e Utilizando um Objeto \"Aluno\"");
//Console.WriteLine("Crie uma classe chamada `Aluno` com os seguintes atributos:\r\n");
//Console.WriteLine("- `nome` (tipo `string`)\r\n");
//Console.WriteLine("- `idade` (tipo `int`)\r\n");
//Console.WriteLine("- `notaFinal` (tipo `double`)\r\n");
//Console.WriteLine("Depois, crie dois objetos da classe `Aluno`, atribua valores a eles e exiba os detalhes de ambos.");
//Console.WriteLine();

//List<Aluno> alunos = new List<Aluno>();

//for(int i = 0; i < 2; i++)
//{
//    Console.WriteLine("Digite o nome do aluno.");
//    string nome = Console.ReadLine();
//    Console.WriteLine();
//    Console.WriteLine("Digite a idade do aluno.");
//    int idade = int.Parse(Console.ReadLine());
//    Console.WriteLine();
//    Console.WriteLine("Digite a nota final do aluno.");
//    double notaFinal = double.Parse(Console.ReadLine());
//    Console.WriteLine();

//    alunos.Add(new Aluno(nome, idade, notaFinal));

//}

//foreach(var aluno in alunos)
//{
//    Console.WriteLine(aluno.MostrarInformacoes());
//    Console.WriteLine();
//}

//Console.WriteLine();

//Console.WriteLine("3 - Criando uma Classe \"Produto\" e Trabalhando com Objetos");
//Console.WriteLine("Crie uma classe chamada `Produto` com os seguintes atributos:\r\n");
//Console.WriteLine("- `nome` (tipo `string`)\r\n");
//Console.WriteLine("- `preco` (tipo `double`)\r\n");
//Console.WriteLine("- `quantidadeEmEstoque` (tipo `int`)\r\n");
//Console.WriteLine("Também crie o seguinte método:\r\n");
//Console.WriteLine("- `CalcularTotal` que retorna o total da `quantidadeEmEstoque` *  `preco`\r\n");
//Console.WriteLine("Depois, crie um objeto da classe `Produto`, altere os valores dos atributos e imprima as informações antes e depois da alteração, também imprima o resultado do método CalcularTotal.");
//Console.WriteLine();

//Produto produto = new Produto("Broca para furar vidros", 99.99, 1000);

//Console.WriteLine(produto.MostrarInformacoes());
//Console.WriteLine();

//produto.Nome = "Desentupidor de fio elétrico";
//produto.Preco = 512.99;
//produto.QuantidadeEmEstoque = 2;

//Console.WriteLine(produto.MostrarInformacoes());


Console.WriteLine("Fundamentais");
Console.WriteLine();
Console.WriteLine("1. Classe ContaBancaria");
Console.WriteLine("Crie uma classe chamada `ContaBancaria` que tenha:\r\n");
Console.WriteLine("-Um atributo privado `_saldo` (com valor padrão de 0).\r\n");
Console.WriteLine("- Um método público `Depositar(double valor)`, que adiciona um valor ao saldo.\r\n");
Console.WriteLine("- Um método público `Sacar(double valor)`, que subtrai um valor do saldo (se houver saldo suficiente).\r\n");
Console.WriteLine("- Um método público `VerSaldo()`, que retorna o saldo atual.\r\n");
Console.WriteLine();
Console.WriteLine("Crie um objeto dessa classe e faça algumas operações de depósito e saque.");
Console.WriteLine();

ContaBancaria conta = new ContaBancaria();
Console.WriteLine("Voce fez uma entrega, qual foi o valor recebido?");
double valor = double.Parse(Console.ReadLine());
conta.Depositar(valor);
Console.WriteLine();

Console.WriteLine("Voce fez uma compra, qual o valor a ser debitado de sua conta?");
valor = double.Parse(Console.ReadLine());
conta.Sacar(valor);
Console.WriteLine();

Console.WriteLine("Voce recebeu um e-mail com seu saldo bancario..");
Console.WriteLine(conta.VerSaldo());
Console.WriteLine();

Console.WriteLine("2. Classe Funcionario");
Console.WriteLine("Crie uma classe `Funcionario` com:\r\n");
Console.WriteLine("-Um atributo privado `_salario`.\r\n");
Console.WriteLine("- Métodos `SetSalario(valor)` e `GetSalario()`\r\n");
Console.WriteLine("- SetSalario** → Modifica o salario com o valor fornecido pelo usuario\r\n");
Console.WriteLine("- GetSalario** → Retorna o Salario\r\n");
Console.WriteLine("Crie um objeto, defina um salário e exiba o valor usando `GetSalario()`.\r\n");
Console.WriteLine();

Funcionario funcionario = new Funcionario();

Console.WriteLine("Qual o novo valor do salario?");
double salario = double.Parse(Console.ReadLine());
funcionario.SetSalario(salario);
Console.WriteLine();

Console.WriteLine($"O funcionario tem um salario no valor de R${funcionario.GetSalario()}");







