// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
//Peça para o usuário inserir dois números inteiros e mostre-os no Console.
//Peça para o usuário inserir dois números inteiros, mostre a soma dos números informados no Console.
//Peça para o usuário inserir dois números inteiros, mostre a subtração dos números informados no Console.
//Peça para o usuário inserir dois números inteiros, mostre a multiplicação dos números informados no Console.
//Peça para o usuário inserir dois números inteiros, mostre a divisão dos números informados no Console.

//Console.WriteLine("Insira um numero inteiro: ");
//int n1 = int.Parse(Console.ReadLine()); // converte o texto para número e guarda
//Console.WriteLine("Insira mais um numero inteiro: ");
//int n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Voce digitou " + n1 + "e" + n2);

Console.WriteLine("=========");
// Entrada dos números
Console.Write("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

// Processo
int soma = n1 + n2;
int subtracao = n1 - n2;

// Saída
Console.WriteLine("\nResultado da soma: " + soma);
Console.WriteLine("Resultado da subtração: " + subtracao);








