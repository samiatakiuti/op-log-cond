/*Ref. (5 pontos)10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.Nome: Sãmia Sayuri Takiuti*/

using System.Globalization;

public static class Atividade10
{
    public static void Executar()
    {
        double numero;

        Console.WriteLine("Digitar o número ");
        numero = double.Parse(Console.ReadLine()!);

        if ((numero % 2)== 0)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é impar");
        }
        
    }
}