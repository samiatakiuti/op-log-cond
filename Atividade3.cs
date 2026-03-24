/*Ref. (10 pontos)3 - Escreva um programa que receba três números inteiros e mostre eles em ordem crescente.Nome:Sâmia Sayuri Takiuti*/
public static class Atividade3
{
    public static void Executar()
    {
       int n1;
       int n2;
       int n3;
       int maiorn = 0;
       int medion = 0;
       int menorn = 0;

       Console.WriteLine("Digite o 1º número ");
       n1 = int.Parse(Console.ReadLine()!);

       Console.WriteLine("Digite o 2º número ");
       n2 = int.Parse(Console.ReadLine()!);

       Console.WriteLine("Digite o 3º número ");
       n3 = int.Parse(Console.ReadLine()!);
       
       if (n1 > n2 || n1 > n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                
                maiorn = n1;
            }

            else
            { 
                medion = n1;
            }

        }
        else
        {
            menorn = n1;
        }



         if (n2 > n1 || n2 > n3)
        {
            if (n2 > n1 && n2 > n3)
            {
                
                maiorn = n2;
            }

            else
            { 
                medion = n2;
            }

        }
        else
        {
            menorn = n2;
        }



         if (n3 > n1 || n3 > n2)
        {
            if (n3 > n1 && n3 > n2)
            {
                
                maiorn = n3;
            }

            else
            { 
                medion = n3;
            }

        }
        else
        {
            menorn = n3;
        }

        Console.WriteLine($"os números digitados em ordem crescente são: {menorn}, {medion}, {maiorn}");
      
    }
}
    