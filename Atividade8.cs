/*Ref. (10 pontos)8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime.
 As perguntas são: "Telefonou para a vítima?" "Esteve no local do crime?" "Mora perto da vítima?" "Devia para a vítima?" 
 "Já trabalhou com a vítima?"O programa deve, no final, emitir uma classificação sobre a participação da pessoa no crime. 
 Se a pessoa responder positivamente a 2 questões, ela deve ser classificada/exibida como "Suspeita",
  entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ela será classificada como "Inocente". Nome: Sâmia Sayuri Takiuti*/
public static class Atividade8
 {
     public static void Executar()
     {
        string resposta1;
        string resposta2;
        string resposta3;
        string resposta4;
        string resposta5;
 
        Console.WriteLine ("Telefonou para a vítima? (sim/não)");
        resposta1 = Console.ReadLine()!.ToLower();  

        Console.WriteLine ("Esteve no local do crime? (sim/não)");
        resposta2 = Console.ReadLine()!.ToLower();

        Console.WriteLine ("Mora perto da vítima? (sim/não)");
        resposta3 = Console.ReadLine()!.ToLower();

        Console.WriteLine ("Devia para a vítima? (sim/não)");
        resposta4 = Console.ReadLine()!.ToLower();

        Console.WriteLine ("Já trabalhou com a vítima? (sim/não)");
        resposta5 = Console.ReadLine()!.ToLower();
        
        int respostasSim = 0;
        if (resposta1 == "sim")
        {
            respostasSim++;
        }
        if (resposta2 == "sim")
        {
            respostasSim++;
        }
        if (resposta3 == "sim")
        {
            respostasSim++;
        }
        if (resposta4 == "sim")
        {
            respostasSim++;
        }
        if (resposta5 == "sim")
        {
            respostasSim++;
        }
        if (respostasSim == 2)
        {
            Console.WriteLine("Suspeita");
        }
        else if (respostasSim >= 3 && respostasSim <= 4)
        {
            Console.WriteLine(" Cúmplice");
        }
        else if (respostasSim == 5)
        {
            Console.WriteLine("Assassino");
        }
        else
        {
            Console.WriteLine("Inocente");
        }
 
    }
 }