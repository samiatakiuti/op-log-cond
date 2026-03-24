 /*Ref. (15 pontos)7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg.
  Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode doar sangue ou não;
   caso não possa, diga o(s) motivo(s).Nome:*/
 public static class Atividade7
{
    public static void Executar()
    {
        int idade;
        double peso;
 
        Console.WriteLine ("digite a sua idade");
        idade = int.Parse(Console.ReadLine()!);
 
        Console.WriteLine ("digite o seu peso");
        peso = double.Parse(Console.ReadLine()!);
 
        if (idade >= 18 && idade <= 67 && peso > 60)
        {
            Console.WriteLine ("Você pode doar sangue");
        }
        else
        {
            Console.WriteLine("Você não pode doar sangue por: ");
            if (idade < 18)
            {
                Console.WriteLine("Ter menos de 18 anos");
            }
            if (idade > 67)
            {
                Console.WriteLine("Ter mais de 67 anos");
            }
            if (peso <= 60)
            {
                Console.WriteLine("Ter 60 kg ou menos");
            }
        }
    }
}
 