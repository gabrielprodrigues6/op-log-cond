/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado. 
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, 
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°, 
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo. 
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome:gabriel
*/

using System;

public static class atividade6
{
    public static void Executar()
    {
        Console.Write("Digite o primeiro ângulo: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo ângulo: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o terceiro ângulo: ");
        int c = int.Parse(Console.ReadLine()!);

        int soma = a + b + c;

        if (soma != 180)
        {
            Console.WriteLine("Os ângulos não formam um triângulo.");
        }
        else
        {
            if (a == 90 || b == 90 || c == 90)
            {
                Console.WriteLine("Triângulo retângulo.");
            }
            else if (a > 90 || b > 90 || c > 90)
            {
                Console.WriteLine("Triângulo obtusângulo.");
            }
            else
            {
                Console.WriteLine("Triângulo acutângulo.");
            }
        }
    }
}