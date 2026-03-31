
/*Ref (5 pontos)1 - Faça um programa que calcule e apresente o valor do volume de uma lata, 
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores de RAIO e ALTURA,
 utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
 Nome: Sâmia Sayuri Takiuti*/

public static class Atividade1
{
    public static void Executar()
    {
        double Pi = 3.14159;
        double Raio;
        double Altura;
        double Volume;

        Console.WriteLine("Digitar o valor de Raio: ");
        Raio = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digitar o valor de Altura: ");
        Altura = double.Parse(Console.ReadLine()!);

        Volume = Pi * (Raio * Raio) * Altura;

        Console.WriteLine("O valor do volume é: {Volume}");



    }

}