using System;
using Calculadora;

Calculadora1 cal = new Calculadora1();

Console.WriteLine("Escolha uma das operações:");
Console.WriteLine("1.Adição");
Console.WriteLine("2.Subtração");
Console.WriteLine("3.Multiplicação");
Console.WriteLine("4.Divisão");
int escolha = int.Parse(Console.ReadLine());

if (escolha == 1) {
    Console.WriteLine("Digite os números:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    cal.Somar(x, y);
} 
else if (escolha == 2) {
    Console.WriteLine("Digite os números:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    cal.Subtrair(x, y);
} 
else if (escolha == 3) {
    Console.WriteLine("Digite os números:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    cal.Multiplicação(x, y);
} 
else  {
    Console.WriteLine("Digite os números:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    cal.Divisão(x, y);
} 

