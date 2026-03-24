/*Ref. (10 pontos)6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado.
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, pois só assim eles formam um triângulo.
Depois, se um dos ângulos for igual a 90°, o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo.
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.Nome:Sâmia Sayuri Takiuti*/

public static class Atividade6
{
    public static void Executar()
    {
        double ang1;
        double ang2;
        double ang3;
 
         Console.WriteLine ("digite o primeiro angulo");
      ang1 = double.Parse(Console.ReadLine()!);
 
      Console.WriteLine ("digite o segundo angulo");
      ang2 = double.Parse(Console.ReadLine()!);
 
     Console.WriteLine ("digite o terceiro angulo");
      ang3 = double.Parse(Console.ReadLine()!);
 
      double Sangs= ang1 + ang2 + ang3;
 
        if (Sangs != 180)
        {
            Console.WriteLine("Não é um triangulo");
        }
        else if (ang1 == 90 || ang2 ==90 || ang3 == 90)
        {
            Console.WriteLine("É um triangulo retângulo");
        }
        else if (ang1 >90 || ang2>90 || ang3> 90)
        {
              Console.WriteLine("É um triangulo obtusângulo");
        }
        else if  (ang1<90 && ang2<90 && ang3 < 90)
        {
            Console.WriteLine("É um triangulo acutângulo");
 
        }
       
    }
}