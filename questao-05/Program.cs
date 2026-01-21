Console.Write("Digite o nome do cliente: ");
string nomeCliente = Console.ReadLine();

decimal valorCompra;
Console.Write("Digite o valor da compra: R$ ");
while (!decimal.TryParse(Console.ReadLine(), out valorCompra) || valorCompra < 0)
    Console.WriteLine("Valor inválido");

bool exit = true;
decimal desconto = 0;
while (exit)
{
    Console.Write("Tem cupom de desconto (Sim/Não): ");
    string temCupom = Console.ReadLine().ToLower();
    bool cupomAplicado;
    
    switch (temCupom)
    {
        case "sim":
            cupomAplicado = true;
            desconto = valorCompra * 0.1m;
            exit = false;

            break;

        case "não":
            cupomAplicado = false;
            exit = false;
            break;

        default:
            Console.WriteLine("Entrada inválida. Tente novamente. ");
            break;
    }
}
decimal valorComCupom = valorCompra - desconto;

Console.WriteLine("Escolha a forma de pagamento: ");
Console.WriteLine("1 - Dinheiro ");
Console.WriteLine("2 - Pix");
Console.WriteLine("3 - Débito");
Console.WriteLine("4 - Crédito");
Console.WriteLine("Digite 1 a 4");

string numeropagamento = Console.ReadLine();
string formaPagamento = "" ;
decimal ajustePagamento = 0;
string pagamento = "";
int quantidadeParcelas = 0;
bool loop = true;
while (loop)
{

    switch (numeropagamento)
    {
        case "1":
            formaPagamento = "Dinheiro";
            ajustePagamento = valorComCupom * 0.05m;
            pagamento = "Pagamento à vista";
            loop = false;
            break;

        case "2":
            formaPagamento = "Pix";
            ajustePagamento = valorComCupom * 0.03m;
            pagamento = "Pagamento à vista";
            loop = false;
            break;

        case "3":
            formaPagamento = "Débito";
            pagamento = "Pagamento à vista";
            loop = false;
            break;

        case "4":
            formaPagamento = "Crédito";
            ajustePagamento = valorComCupom * (-0.05m);
            Console.Write("Quantas parcelas: ");
            while(!int.TryParse(Console.ReadLine(), out quantidadeParcelas) || quantidadeParcelas <= 0)
                Console.WriteLine("Entrada Inválida");
            pagamento = "Parcelado";
            loop = false;
            break;

        default:
            Console.WriteLine("Entrada inválida");
            break;
    }
}
decimal valorFinal = valorComCupom - ajustePagamento;
decimal valorParcelas = 0;
Console.Clear();
Console.WriteLine($"=== COMPRA ONLINE ===");
Console.WriteLine($"Cliente: {nomeCliente}");
Console.WriteLine();
Console.WriteLine($"CALCULO");
Console.WriteLine($"Valor Original: {valorCompra}");
Console.WriteLine($"Cupom: {desconto:C}");
Console.WriteLine($"Ajuste Pagamento: {ajustePagamento:C} ");
Console.WriteLine($"Pagamento: {formaPagamento}");
Console.WriteLine($"Tipo: {pagamento}");
if (pagamento == "Parcelado")
{
    valorParcelas = valorFinal/quantidadeParcelas;
    Console.WriteLine($"Parcela: {parcelas:C}");
}

