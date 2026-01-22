int contadorMaior30 = 0;
decimal valorTotal = 0;
decimal maiorVenda = decimal.MinValue;
decimal menorVenda = decimal.MaxValue;
ClassificacaoEnum classificacao = ClassificacaoEnum.Inativo;


List<decimal> valoresComandas = new List<decimal>();
valoresComandas.Add(22.50m);
valoresComandas.Add(18);
valoresComandas.Add(45);
valoresComandas.Add(9.50m);
valoresComandas.Add(60);
valoresComandas.Add(12);
valoresComandas.Add(30);

foreach (var valor in valoresComandas)
{
    if (valor > 30)
        contadorMaior30++;
}

foreach (var valor in valoresComandas)
    valorTotal += valor;


if (valorTotal < 60)
    classificacao = ClassificacaoEnum.Fraco;
else if (valorTotal < 120)
    classificacao = ClassificacaoEnum.Regular;
else if (valorTotal < 200)
    classificacao = ClassificacaoEnum.Bom;
else
    classificacao = ClassificacaoEnum.Otimo;

Console.Clear();
Console.WriteLine($"=== RELATÓRIO DO DIA ===");

for (int i = 0; i < valoresComandas.Count; i++)
{
    Console.WriteLine($"Comanda {i + 1}: {valoresComandas[i]}");

    if (valoresComandas[i] > maiorVenda)
        maiorVenda = valoresComandas[i];

    if (valoresComandas[i] < menorVenda)
        menorVenda = valoresComandas[i];

}

Console.WriteLine();
Console.WriteLine($"Faturamento Total: {valorTotal:C}");
Console.WriteLine($"Pedidos acima de R$30: {contadorMaior30}");
Console.WriteLine($"Maior venda: {maiorVenda:C}");
Console.WriteLine($"Menor venda: {menorVenda:C}");
Console.WriteLine($"Status do dia: {classificacao} ");

enum ClassificacaoEnum
{
    Otimo,
    Bom,
    Regular,
    Fraco,
    Inativo
}