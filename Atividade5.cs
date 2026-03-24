/*Ref (15 pontos)5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
 e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas,
  calcule e escreva o valor total da compra.Nome: Sâmia Sayuri Takiuti*/

public static class Atividade5
{
    public static void Executar()
    {
        double maca = 0;
        double custoTotal;

        Console.WriteLine ("digite a quantidade de maçãs");
        maca = double.Parse(Console.ReadLine()!);

        if (maca < 12)
        {
            custoTotal = maca*0.3;
        }
        else
        {
            custoTotal = maca*0.25;
        }
        Console.WriteLine($"o valor total da compra é {custoTotal}");
    }
}