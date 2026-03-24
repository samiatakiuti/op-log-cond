/*Ref (15 pontos)4 – Ler valor de nota de N1 e N2,
calcular a média e escrever a nota correspondente, tal que 0 é a menor nota e 10 a maior,
e imprimir o conceito equivalente (A, B, C, D ou E), conforme a seguinte tabela:
A - nota >= 8,5 e nota <= 10 B - nota >= 7 e nota < 8,5 C - nota >= 5 e nota < 7 D - nota >= 3 e nota < 5 E - nota < 3
Nome: Sâmia Sayuri Takiuti*/

using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Reflection;

public static class Atividade4
{
    public static void Executar()
    {
        double n1;
        double n2;
        double media;

        Console.WriteLine("Digitar o valor da nota 1: ");
        n1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digitar o valor da nota 2: ");
        n2 = double.Parse(Console.ReadLine()!);

        media = (n1 + n2)/2;


        if ( (media <= 10) && (media >= 8.5))
        {
            Console.WriteLine("a nota é A");
        }
        else if ((media <= 7) && (media < 8.5))
        {
            Console.WriteLine("a nota é B");
        }
        else if ((media >= 5) && (media < 7))
        {
            Console.WriteLine("a nota é C");
        }
        else if ((media >= 3) && (media < 5))
        {
            Console.WriteLine("a nota é D");
        }
        else
        {
            Console.WriteLine("a nota é E");
        }
    }
}