Console.Write("Nome do produto: ");
string nomeProduto = Console.ReadLine();

decimal precoProduto;
int quantidadeProduto;

decimal subtotal = 0;
decimal descontoAplicado = 0;
string promocaoAtiva;

decimal frete = 0;
decimal valorFinal = 0;


while (true)
{
    Console.Write("Digite o valor do produto: ");
    string precoProdutoInformado = Console.ReadLine();
    if (decimal.TryParse(precoProdutoInformado, out precoProduto))
        break;
    else
        Console.WriteLine("Valor informado inválido\n");
}

Console.Write("Digite quantas unidades desse produto deseja: ");
while (!int.TryParse(Console.ReadLine(), out quantidadeProduto) || quantidadeProduto < 0)
    Console.WriteLine("Quantidade informada inválida");


subtotal = precoProduto * quantidadeProduto;



Console.Write("Está em promoção (Sim/Não): ");
promocaoAtiva = Console.ReadLine().ToLower();
switch (promocaoAtiva)
{
    case "sim":
        descontoAplicado = subtotal * 0.12m;
        break;

    case "não":
        descontoAplicado = 0;
        break;

    default:
        Console.WriteLine("Entrada inválida");
        break;
}



decimal total = subtotal - descontoAplicado;

if (total >= 800m)
    valorFinal = total;
else
{
    frete = 35;
    valorFinal = total + frete;
}

Console.Clear();
Console.WriteLine("=== FECHAMENTO DE COMPRA ===");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço Unitário: {precoProduto:C}");
Console.WriteLine($"Quantidade: {quantidadeProduto}");
Console.WriteLine();
Console.WriteLine($"Subtotal : {subtotal:C}");
Console.WriteLine($"Promoção Ativa: {promocaoAtiva}");
Console.WriteLine($"Desconto(12%): {descontoAplicado:C}");
Console.WriteLine();
Console.WriteLine($"Frete Aplicado: {frete:C}");
Console.WriteLine($"VALOR FINAL: {valorFinal:C}");


