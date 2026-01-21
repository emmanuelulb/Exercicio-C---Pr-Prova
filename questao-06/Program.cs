decimal consumoEnergia;
decimal faturaValor;
decimal valorBase = 0.72m;
int escolhaConvertida;
BandeiraEnum bandeira = BandeiraEnum.INATIVA;
decimal acrescimoBandeira = 0;
decimal descontoSustentabilidade = 0;
decimal totalBandeira = 0;
decimal totalPagar;
string nomeCliente;

while (true)
{
    Console.Write("Digite o nome do cliente: ");
    nomeCliente = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(nomeCliente))
        Console.WriteLine("Nome inválido ou vazio");
    else
        break;
}

Console.Write("Digite o consumo do mês: ");
while (!decimal.TryParse(Console.ReadLine(), out consumoEnergia) || consumoEnergia < 1)
    Console.WriteLine("Digite novamente.");

faturaValor = consumoEnergia * valorBase;

Console.WriteLine("Operando com bandeira: ");
Console.WriteLine("1 - Verde");
Console.WriteLine("2 - Amarela");
Console.WriteLine("3 - Vermelha");
Console.WriteLine("Escolha entre as opções 1 a 3");


while (!int.TryParse(Console.ReadLine(), out escolhaConvertida) || escolhaConvertida < 1 || escolhaConvertida > 3)
    Console.WriteLine("Entrada inválida.");
bool loop = true;
while (loop)
{
    switch (escolhaConvertida)
    {
        case 1:
            bandeira = BandeiraEnum.VERDE;
            loop = false;

            break;

        case 2:
            bandeira = BandeiraEnum.AMARELA;
            acrescimoBandeira = faturaValor * 0.05m;
            totalBandeira = faturaValor + acrescimoBandeira;
            loop = false;
            break;

        case 3:
            bandeira = BandeiraEnum.VERMELHA;
            acrescimoBandeira = faturaValor * 0.1m;
            totalBandeira = faturaValor + acrescimoBandeira;
            loop = false;
            break;

        default:
            Console.WriteLine("Entrada inválida.");
            break;
    }
}
if (consumoEnergia < 200)
{
    descontoSustentabilidade = totalBandeira * 0.08m;
    totalPagar = totalBandeira - descontoSustentabilidade;
}
else
    totalPagar = totalBandeira;

Console.Clear();
Console.WriteLine("===== FATURA =====");
Console.WriteLine($"Cliente: {nomeCliente}");
Console.WriteLine($"Subtotal: {faturaValor:C}");
Console.WriteLine($"Bandeira: {bandeira}");
Console.WriteLine($"Acréscimo da bandeira: {acrescimoBandeira:C}");
Console.WriteLine($"Desconto do Programa: {descontoSustentabilidade:C}");
Console.WriteLine("");
Console.WriteLine($"TOTAL A PAGAR: {totalPagar:C}");


enum BandeiraEnum
{
    VERDE,
    AMARELA,
    VERMELHA,
    INATIVA
}
