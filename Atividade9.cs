/*Ref. (5 pontos)9 - Escreva um programa que leia um número e verifique se ele é positivo,negativo ou zero.Nome: Sâmia Sayuri Takiuti*/

public static class Atividade9
{
    public static void Executar()
    {
        double numero;

        Console.WriteLine("Digitar o número ");
        numero = double.Parse(Console.ReadLine()!);

        if (numero > 0)
        {
            Console.WriteLine("o número é positivo");
        }
        else if (numero == 0)
        {
            Console.WriteLine("o número é zero");
        }
        else
        {
             Console.WriteLine("o número é negativo");
        }
        
    }
}