/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.
Nome:gabriel
*/


public static class atividade10
{
    public static void Executar()
    {
        double numero;

        Console.WriteLine("Escreva o número");
        numero = double.Parse(Console.ReadLine()!);

        if((numero % 2)== 0)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é impar");
        }
    }
}