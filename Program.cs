// See https://aka.ms/new-console-template for more information
using Calculadora.models;
Console.WriteLine("Bem vindo a Calculadora Simples !");

Console.Write("Digite o primeiro numero:");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero:");
int numero2 = int.Parse(Console.ReadLine());

Operacoes operacao = new Operacoes(numero1, numero2);


while (true)
{
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("O resultado da soma é:{0}", operacao.Soma());
            break;
        case 2:
            Console.WriteLine("O resultado da subtração é: {0}", operacao.Subtracao());
            break;
        case 3:
            Console.WriteLine("O resultado da multiplicação é : {0}", operacao.Multiplicacao());
            break;
        case 4:
            Console.WriteLine("O resultado da divisão é : {0}", operacao.Divisao());
            break;
        case 5:
            Console.WriteLine("Saindo da calculadora...");
            return;

    }
}







