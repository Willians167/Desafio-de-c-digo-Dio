using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string entrada = Console.ReadLine();

        
        decimal[] valores = entrada.Split(',').Select(decimal.Parse).ToArray();

        
        decimal salarioBase = valores[0];
        int horasExtras = (int)valores[1];
        decimal valorHoraExtra = valores[2];
        decimal descontoIR = valores[3];
        decimal descontoINSS = valores[4];

        
        decimal salarioLiquido = salarioBase + (horasExtras *  valorHoraExtra) - descontoIR - descontoINSS;

        
        Console.WriteLine($"{salarioLiquido:F2}");
    }
}