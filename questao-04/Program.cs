Dictionary<string , int> itemsLoja = new Dictionary<string, int> {{"Mouse", 10},{"Teclado", 6}, {"Monitor", 4}, {"Cabo HDMI", 18}, {"Cadeira", 5}};

Console.WriteLine("=== ESTOQUE INICIAL ===");
foreach (var item in itemsLoja)
{
    Console.WriteLine($"Item: {item.Key} | Quantidade: {item.Value}");
}
Console.WriteLine();
Console.WriteLine("=== OPERAÇÕES ===");

itemsLoja.Add("SSD", 7);
Console.WriteLine($"Adicionando: SSD ({itemsLoja["SSD"]})");

itemsLoja["Teclado"] = 12;
Console.WriteLine($"Atualizando: Teclado ({itemsLoja["Teclado"]})");

bool existeWebcam = itemsLoja.ContainsKey("Webcam");
if (existeWebcam)
    Console.WriteLine("Existe Webcam? Sim");
else
    Console.WriteLine("Existe Webcam? Não");

int contadorEstoqueBaixo = 0;
foreach (var quantidade in itemsLoja)
{
    if (quantidade.Value < 8)
    contadorEstoqueBaixo++;
}
Console.WriteLine($"Estoque baixo (<8): {contadorEstoqueBaixo}");

itemsLoja.Remove("Monitor");
Console.WriteLine($"Removido: Monitor");
Console.WriteLine();
Console.WriteLine("=== ESTOQUE FINAL ===");
foreach (var item in itemsLoja)
{
    Console.WriteLine($"Item: {item.Key} | Quantidade: {item.Value}");
}
Console.WriteLine();
int totalProdutos = 0;
foreach (var quantidade in itemsLoja.Values)
    totalProdutos += quantidade;
Console.WriteLine($"Total de produtos: {totalProdutos}");
