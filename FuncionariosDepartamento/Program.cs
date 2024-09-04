using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // para teste digite como exemplo, Financeiro - Rh - Ti , separados por virgula, repita quantas vezes quiser para verificar a insidência.
        string input = Console.ReadLine();

        
        List<string> departamentos = input.Split(',')
                                            .ToList();

        
        Dictionary<string, int> contagemDepartamentos = ContarFuncionariosPorDepartamento(departamentos);

        
        var resultado = string.Join(Environment.NewLine,
                                        contagemDepartamentos.OrderBy(depto => depto.Key)
                                                            .Select(depto => $"{depto.Key}: {depto.Value}"));

        Console.WriteLine(resultado);
    }

    
    static Dictionary<string, int> ContarFuncionariosPorDepartamento(List<string> departamentos)
    {
        var contagem = new Dictionary<string, int>();

        foreach (string departamento in departamentos)
        {
            if (contagem.ContainsKey(departamento))
            {
                
                contagem[departamento]++;
            }
            else
            {
                
                contagem[departamento] = 1;
            }
        }

        return contagem;
    }
}