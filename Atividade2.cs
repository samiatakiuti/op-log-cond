/* Ref (5 pontos)2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante. Nome: Sâmia Sayuri Takiti*/

public static class Atividade2
{
    public static void Executar()
    {
        string letra;

        Console.WriteLine("Digite a letra: ");
        letra = Console.ReadLine()!;

        if( (letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra =="u"))
        {
            Console.WriteLine("Vogal");
        }
        else
        {
            Console.WriteLine("Consoantes");
        }
    }
}