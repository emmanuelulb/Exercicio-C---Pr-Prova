List<decimal> valoresVendas = new List<decimal> ();

decimal valorVenda;
decimal totalVendido =0;

int quantidadeVendasRegistrar = ValidarInteiro("Digite quantas vendas serão registradas: ");

for (int i = 0; i < quantidadeVendasRegistrar; i++)
{
    valorVenda = ValidarDecimal($"Digite o valor em real da venda {i+1}: ");
    valoresVendas.Add(valorVenda);
}

int contadorLista = ContadorLista(valoresVendas);
for (int i = 0; i < contadorLista; i++)
    totalVendido += valoresVendas[i];

decimal mediaVendas = totalVendido/contadorLista;
int contadorAcimaMedia = 0;
decimal maiorVenda = valoresVendas[0];
decimal menorVenda = valoresVendas[0];

for (int i = 0; i < contadorLista; i++)
{
    if (valoresVendas[i] > mediaVendas)
        contadorAcimaMedia++;

    if(valoresVendas[i] > maiorVenda)
        maiorVenda = valoresVendas[i];

    if(valoresVendas[i] < menorVenda)
        menorVenda = valoresVendas[i];
}

string classificacaoDia;

if (totalVendido < 600)
    classificacaoDia = "Fraco";
else if (totalVendido < 1200)
    classificacaoDia = "Regular";
else if (totalVendido < 2000)
    classificacaoDia = "Bom";
else
    classificacaoDia = "Excelente";

Console.Clear();
Console.WriteLine("=== RELATÓRIO DE VENDAS ===");
for (int i = 0; i < contadorLista; i++)
    Console.WriteLine($"Venda {i + 1}: {valoresVendas[i]:C}");
Console.WriteLine();
Console.WriteLine($"Total vendido: {totalVendido:C}");
Console.WriteLine($"Média das vendas: {mediaVendas:C}");
Console.WriteLine($"Vendas acima da média: {contadorAcimaMedia}");
Console.WriteLine($"Maior venda: {maiorVenda:C}");
Console.WriteLine($"Menor venda: {menorVenda:C}");

string ValidarString (string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();
    while(string.IsNullOrWhiteSpace(entrada) || entrada.Any(char.IsNumber))
    {
        Console.WriteLine("Entrada inválida. Tente novamente: ");
        entrada = Console.ReadLine();
    }
    return entrada;
}

int ValidarInteiro (string mensagem)
{
    int entrada;
    Console.WriteLine(mensagem);
    while(!int.TryParse(Console.ReadLine(), out entrada) || entrada < 0)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

double ValidarDoubleIntervalado (string mensagem, int minimo, int maximo)
{
    double entrada;
    Console.WriteLine(mensagem);
    while(!double.TryParse(Console.ReadLine(), out entrada) || entrada < minimo || entrada > maximo)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

decimal ValidarDecimal (string mensagem)
{
    decimal entrada;
    Console.WriteLine(mensagem);
    while(!decimal.TryParse(Console.ReadLine(), out entrada) || entrada < 0)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

int ContadorLista<T> (List<T> lista)
{
    int contador = 0;
    foreach (var item in lista)
        contador++;
    return contador;
}
