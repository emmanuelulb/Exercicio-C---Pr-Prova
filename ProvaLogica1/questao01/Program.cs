string nomeProduto;
int quantidadeProduto =0;
decimal valorProduto =0;
int promocaoValida;
decimal valorDescontoReal = 0;
string validacaoPromocao;
decimal valorPorcentoDesconto = 0;

nomeProduto = ValidarString("Digite o produto que deseja: ");
valorProduto = ValidarDecimal("Digite o valor desse produto: ");
quantidadeProduto = ValidarInteiro("Digite a quantidade que deseja comprar desse produto: ");
promocaoValida = ValidarInteiroComLimite("Hoje é dia de promoção (1 - Sim/ 2 - Não): " , 1 , 2);

decimal subTotal = quantidadeProduto * valorProduto;
if (promocaoValida == 1)
{
    validacaoPromocao = "sim";
    valorPorcentoDesconto = ValidarDecimal("Qual a porcentagem de desconto que será aplicado: ");
    valorDescontoReal = subTotal * (valorPorcentoDesconto/100);
}
else
    validacaoPromocao = "não";

decimal valorFinal = subTotal - valorDescontoReal;

Console.Clear();
Console.WriteLine("========== VENDA PRODUTO ===========");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço Unitário: {valorProduto:C}");
Console.WriteLine($"Quantidade: {quantidadeProduto}");
Console.WriteLine($"Em promoção: {validacaoPromocao}");
Console.WriteLine();
Console.WriteLine($"Subtotal: {subTotal:C}");
Console.WriteLine($"Desconto ({valorPorcentoDesconto/100:p}): {valorDescontoReal:C}");
Console.WriteLine($"Valor final: {valorFinal:C}");




string ValidarString (string mensagem)
{
    Console.Write(mensagem);
    string entrada = Console.ReadLine();
    while(string.IsNullOrWhiteSpace(entrada) || entrada.Any(char.IsNumber))
    {
        Console.Write("Erro, entrada inválida. Tente novamente: ");
        entrada = Console.ReadLine();
    }
    return entrada;
}

int ValidarInteiro (string mensagem)
{
    int entrada;
    Console.Write(mensagem);
    while(!int.TryParse(Console.ReadLine(), out entrada) || entrada < 0)
        Console.WriteLine("Erro, tente novamente: ");
    return entrada;
}

int ValidarInteiroComLimite (string mensagem, int minimo, int maximo)
{
    int entrada;
    Console.Write(mensagem);
    while(!int.TryParse(Console.ReadLine(), out entrada) || entrada < minimo || entrada > maximo)
        Console.WriteLine("Erro, tente novamente: ");
    return entrada;
}

decimal ValidarDecimal (string mensagem)
{
    decimal entrada;
    Console.Write(mensagem);
    while(!decimal.TryParse(Console.ReadLine(), out entrada) || entrada < 0 )
        Console.WriteLine("Erro, tente novamente: ");
    return entrada;
}