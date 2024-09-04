using System;

class Programa
{
    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();


        string[] notasString = entrada.Split(',');
        int produtividade = int.Parse(notasString[0]);
        int qualidade = int.Parse(notasString[1]);
        int pontualidade = int.Parse(notasString[2]);


        double media = (produtividade + qualidade + pontualidade) / 3.0;



        string elegivelParaBonus;
        if (media >= 7)
        {
            elegivelParaBonus = "Sim";
        }
        else
        {
            elegivelParaBonus = "Nao";
        }

        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Elegivel para bonus: {elegivelParaBonus}");
    }
}