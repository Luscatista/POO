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


//Console.WriteLine("Fundamentais");
//Console.WriteLine();
//Console.WriteLine("1. Classe ContaBancaria");
//Console.WriteLine("Crie uma classe chamada `ContaBancaria` que tenha:\r\n");
//Console.WriteLine("-Um atributo privado `_saldo` (com valor padrão de 0).\r\n");
//Console.WriteLine("- Um método público `Depositar(double valor)`, que adiciona um valor ao saldo.\r\n");
//Console.WriteLine("- Um método público `Sacar(double valor)`, que subtrai um valor do saldo (se houver saldo suficiente).\r\n");
//Console.WriteLine("- Um método público `VerSaldo()`, que retorna o saldo atual.\r\n");
//Console.WriteLine();
//Console.WriteLine("Crie um objeto dessa classe e faça algumas operações de depósito e saque.");
//Console.WriteLine();

//ContaBancaria conta = new ContaBancaria();
//Console.WriteLine("Voce fez uma entrega, qual foi o valor recebido?");
//double valor = double.Parse(Console.ReadLine());
//conta.Depositar(valor);
//Console.WriteLine();

//Console.WriteLine("Voce fez uma compra, qual o valor a ser debitado de sua conta?");
//valor = double.Parse(Console.ReadLine());
//conta.Sacar(valor);
//Console.WriteLine();

//Console.WriteLine("Voce recebeu um e-mail com seu saldo bancario..");
//Console.WriteLine(conta.VerSaldo());
//Console.WriteLine();

//Console.WriteLine("2. Classe Funcionario");
//Console.WriteLine("Crie uma classe `Funcionario` com:\r\n");
//Console.WriteLine("-Um atributo privado `_salario`.\r\n");
//Console.WriteLine("- Métodos `SetSalario(valor)` e `GetSalario()`\r\n");
//Console.WriteLine("- SetSalario** → Modifica o salario com o valor fornecido pelo usuario\r\n");
//Console.WriteLine("- GetSalario** → Retorna o Salario\r\n");
//Console.WriteLine("Crie um objeto, defina um salário e exiba o valor usando `GetSalario()`.\r\n");
//Console.WriteLine();

//Funcionario funcionario = new Funcionario();

//Console.WriteLine("Qual o novo valor do salario?");
//double salario = double.Parse(Console.ReadLine());
//funcionario.SetSalario(salario);
//Console.WriteLine();

//Console.WriteLine($"O funcionario tem um salario no valor de R${funcionario.GetSalario()}");
//Console.WriteLine();

//Console.WriteLine("3. Classe Retangulo");
//Console.WriteLine("Crie uma classe `Retangulo` com:\r\n");
//Console.WriteLine("-Dois atributos privados `_largura` e `_altura`.\r\n");
//Console.WriteLine("- Métodos `SetLargura(valor)`, `SetAltura(valor)`, `GetLargura()` e `GetAltura()`.\r\n");
//Console.WriteLine("- SetLargura** → Modifica a _largura com o valor fornecido pelo usuario\r\n");
//Console.WriteLine("- SetAltura** → Modifica a _altura com o valor fornecido pelo usuario\r\n");
//Console.WriteLine("- GetLargura** → Retorna a Largura\r\n");
//Console.WriteLine("- GetAltura** → Retorna a Altura\r\n");
//Console.WriteLine("- Um método público `CalcularArea()`, que retorna a área do retângulo.\r\n");
//Console.WriteLine("Crie um objeto, defina largura e altura, e exiba a área calculada.\r\n");
//Console.WriteLine();

//Retangulo retangulo = new Retangulo();

//Console.WriteLine("Digite a largura do retangulo:");
//double largura = double.Parse(Console.ReadLine());
//retangulo.SetLargura(largura);
//Console.WriteLine();
//Console.WriteLine("Digite a altura do retangulo:");
//double altura = double.Parse(Console.ReadLine());
//retangulo.SetAltura(altura);
//Console.WriteLine();
//Console.WriteLine(retangulo.GetAltura());
//Console.WriteLine(retangulo.GetLargura());
//Console.WriteLine($"O valor da área do retangulo é: {retangulo.CalcularArea()}");
//Console.WriteLine();

//Console.WriteLine("4. Conta Corrente e Conta Poupança\r\n");
//Console.WriteLine("Utilizando a classe `ContaBancaria` criada no exercício 1, crie duas subclasses:\r\n");
//Console.WriteLine("- `ContaCorrente`: possui um método `CobrarTaxa()` que reduz o saldo em um valor fixo (ex: 10).\r\n");
//Console.WriteLine("- `ContaPoupanca`: possui um método `RenderJuros()`, que aumenta o saldo em 5%.\r\n");
//Console.WriteLine("Crie instâncias de ambas as classes, faça depósitos e utilize seus métodos específicos.\r\n");
//Console.WriteLine();

//ContaCorrente contaCorrente = new ContaCorrente();
//ContaPoupanca contaPoupanca = new ContaPoupanca();

//Console.WriteLine("Digite o valor do deposito na sua conta corrente:");
//double valor = double.Parse(Console.ReadLine());
//contaCorrente.Depositar(valor);
//Console.WriteLine();
//contaCorrente.CobrarTaxa();
//Console.WriteLine($"Apos aplicar as taxas seu saldo passou a ser {contaCorrente.VerSaldo()}");
//Console.WriteLine();

//Console.WriteLine("Digite o valor do deposito na sua conta poupança:");
//valor = double.Parse(Console.ReadLine());
//contaPoupanca.Depositar(valor);
//Console.WriteLine();
//contaPoupanca.RenderJuros();
//Console.WriteLine($"Apos render juros seu saldo passou a ser {contaPoupanca.VerSaldo()}");
//Console.WriteLine();

Console.WriteLine("5. Funcionário e Gerente");
Console.WriteLine("Baseando - se na classe `Funcionario` do exercício 2, crie uma classe `Gerente`, que:\r\n");
Console.WriteLine("-Herda `Funcionario`.\r\n");
Console.WriteLine("- Possui um método `Bonificar()`, que aumenta o salário em 10%.\r\n");
Console.WriteLine("Crie um objeto da classe `Gerente`, defina um salário, aplique a bonificação e exiba o salário atualizado.");
Console.WriteLine();

Gerente gerente = new Gerente();
Console.WriteLine("Qual o salario ?");
double salario = double.Parse(Console.ReadLine());
gerente.SetSalario(salario);
Console.WriteLine();
gerente.Bonificar();
Console.WriteLine($"O valor do salario apos a bonificaçao é: {gerente.GetSalario()}");
