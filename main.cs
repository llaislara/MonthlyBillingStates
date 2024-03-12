using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Ler o arquivo JSON
        string jsonText = File.ReadAllText("faturamento.json");

        // Desserializar o JSON para um objeto C#
        var faturamentoPorEstado = JsonSerializer.Deserialize<FaturamentoPorEstado>(jsonText);

        // Calculando o valor total mensal da distribuidora
        decimal valorTotal = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            valorTotal += valor;
        }

        // Calculando e exibindo o percentual de representação de cada estado
        foreach (var estado in faturamentoPorEstado.Keys)
        {
            decimal percentual = (faturamentoPorEstado[estado] / valorTotal) * 100;
            Console.WriteLine($"Percentual de representação de {estado}: {percentual:F2}%");
        }
    }
}

class FaturamentoPorEstado : System.Collections.Generic.Dictionary<string, decimal>
{
}
