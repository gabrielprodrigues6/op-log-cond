/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.Nome:gabriel
*/





public static class atividade2
{
    public static void Executar()
    {
        Console.WriteLine("Digite a letra");
        string letra = Console.ReadLine()!;

        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra =="u")
        {
            Console.WriteLine("A letra é uma vogal");
        }
    
    else
        {
            Console.WriteLine("A letra é uma consoante");
        }
    
    }
}