using System.Text.Json;
using System;
using TargetTeste;
using TargetTeste.model;

// 2
int input = 4;

bool result = Fibonacci.IsFibonacci(input);
Console.WriteLine(result ? $"{input} é da sequência Fibonacci." : $"{input} não é da sequência Fibonacci.");

// 3
try
{
    string dataPath = "../../../data/dados.json";
    string dataJson = File.ReadAllText(dataPath);
    dadosModel[] dados = JsonSerializer.Deserialize<dadosModel[]>(dataJson);

    Distributor.GetInformation(dados);
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}

// 4
decimal sp = 67836.43m;
decimal rj = 36678.66m;
decimal mg = 29229.88m;
decimal es = 27165.48m;
decimal outros = 19849.53m;
decimal faturamentoTotal = sp + rj + mg + es + outros;

decimal percentualSP = Month.CalcularPercentual(sp, faturamentoTotal);
decimal percentualRJ = Month.CalcularPercentual(rj, faturamentoTotal);
decimal percentualMG = Month.CalcularPercentual(mg, faturamentoTotal);
decimal percentualES = Month.CalcularPercentual(es, faturamentoTotal);
decimal percentualOutros = Month.CalcularPercentual(outros, faturamentoTotal);

Console.WriteLine("Percentual de representação por estado:");
Console.WriteLine($"SP: {percentualSP:F2}%");
Console.WriteLine($"RJ: {percentualRJ:F2}%");
Console.WriteLine($"MG: {percentualMG:F2}%");
Console.WriteLine($"ES: {percentualES:F2}%");
Console.WriteLine($"Outros: {percentualOutros:F2}%");

// 5
string inputToInvert = "Eu sou uma string invertida";
string inverted = StringReverser.StringReverse( inputToInvert );
Console.WriteLine(inverted);


