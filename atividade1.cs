//*Ref (5 pontos)1 - Faça um programa que calcule e apresente o valor do volume de uma lata,sabendo que PI é um valor constante de 3.14159,
// programa deve pedir os valores de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.Nome:gabriel*/

public static class atividade1
{
        public static void Executar()
    {
        double volume;
        double PI = 3.14159;
        double Raio;
        double Altura;

        Console.WriteLine("Digite o valor do raio");
        Raio = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite o valor da altura");
        Altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o valor do volume");
        volume = double.Parse(Console.ReadLine()!);

    volume = PI * (Raio * Raio) * Altura;
Console.WriteLine("O valor de volume é");
Console.WriteLine(volume);
    }
}

   