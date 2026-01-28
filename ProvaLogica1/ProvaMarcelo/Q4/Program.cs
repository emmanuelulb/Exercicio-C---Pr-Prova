decimal valorFinal = 0;
decimal valorDescontoReal;
int contadorDinheiro = 0;
int contadorPix = 0;
int contadorDebito = 0;
int contadorCredito = 0;
int numeroFormaPagamentoMinimo = 1;
int numeroFormaPagamentoMaximo = 4;

List<string> nomesClientes = new List<string>();
List<decimal> valoresPedidos = new List<decimal>();
List<FormaPagamentoEnum> formaPagamentos = new List<FormaPagamentoEnum>();

int quantidadePedidoRegistrar = ValidarInteiro("Quantos pedidos deseja registrar: ");

for (int i = 0; i < quantidadePedidoRegistrar; i++)
{
    nomesClientes.Add(ValidarString($"Digite o nome do cliente do pedido {i + 1}: "));
    valoresPedidos.Add(ValidarDecimal("Digite o valor do pedido: "));
    formaPagamentos.Add((FormaPagamentoEnum)ValidarInteiroIntervalado("Forma de pagamento (1 - Dinheiro; 2 - Pix; 3 - Debito; 4 - Crédito): ", numeroFormaPagamentoMinimo, numeroFormaPagamentoMaximo));
}

int contadorLista = ContadorLista(nomesClientes);
Console.Clear();
Console.WriteLine("=== RELATÓRIO DE PEDIDOS ===");
for (int i = 0; i < contadorLista; i++)
{
    decimal descontoValorDecimal = formaPagamentos[i] switch
    {
        FormaPagamentoEnum.Dinheiro => 0.05m,
        FormaPagamentoEnum.Pix => 0.03m,
        FormaPagamentoEnum.Debito => 0,
        FormaPagamentoEnum.Credito => -0.05m,
        _ => 0
    };

    switch (formaPagamentos[i])
    {
        case FormaPagamentoEnum.Dinheiro:
            valorDescontoReal = valoresPedidos[i] * descontoValorDecimal;
            valorFinal = valoresPedidos[i] - valorDescontoReal;
            contadorDinheiro++;
            break;

        case FormaPagamentoEnum.Pix:
            valorDescontoReal = valoresPedidos[i] * descontoValorDecimal;
            valorFinal = valoresPedidos[i] - valorDescontoReal;
            contadorPix++;
            break;

        case FormaPagamentoEnum.Debito:
            valorDescontoReal = valoresPedidos[i] * descontoValorDecimal;
            valorFinal = valoresPedidos[i] - valorDescontoReal;
            contadorDebito++;
            break;

        case FormaPagamentoEnum.Credito:
            valorDescontoReal = valoresPedidos[i] * descontoValorDecimal;
            valorFinal = valoresPedidos[i] - valorDescontoReal;
            contadorCredito++;
            break;
    }
    Console.WriteLine();
    Console.WriteLine($"Cliente: {nomesClientes[i]}");
    Console.WriteLine($"Forma de pagamento: {formaPagamentos[i]}");
    Console.WriteLine($"Valor final: {valorFinal:C}");
}
Console.WriteLine();
Console.WriteLine($"Pedidos em dinheiro: {contadorDinheiro}");
Console.WriteLine($"Pedidos em Pix: {contadorPix}");
Console.WriteLine($"Pedidos em Débito: {contadorDebito}");
Console.WriteLine($"Pedidos em Crédito: {contadorCredito}");

string ValidarString(string mensagem)
{
    Console.WriteLine(mensagem);
    string entrada = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(entrada) || entrada.Any(char.IsNumber))
    {
        Console.WriteLine("Entrada inválida. Tente novamente: ");
        entrada = Console.ReadLine();
    }
    return entrada;
}

int ValidarInteiro(string mensagem)
{
    int entrada;
    Console.WriteLine(mensagem);
    while (!int.TryParse(Console.ReadLine(), out entrada) || entrada < 0)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

int ValidarInteiroIntervalado(string mensagem, int minimo, int maximo)
{
    int entrada;
    Console.WriteLine(mensagem);
    while (!int.TryParse(Console.ReadLine(), out entrada) || entrada < minimo || entrada > maximo)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

double ValidarDoubleIntervalado(string mensagem, int minimo, int maximo)
{
    double entrada;
    Console.WriteLine(mensagem);
    while (!double.TryParse(Console.ReadLine(), out entrada) || entrada < minimo || entrada > maximo)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

decimal ValidarDecimal(string mensagem)
{
    decimal entrada;
    Console.WriteLine(mensagem);
    while (!decimal.TryParse(Console.ReadLine(), out entrada) || entrada <= 0)
        Console.WriteLine("Entrada inválida. Tente novamente: ");
    return entrada;
}

int ContadorLista<T>(List<T> lista)
{
    int contador = 0;
    foreach (var item in lista)
        contador++;
    return contador;
}

enum FormaPagamentoEnum
{
    Dinheiro = 1,
    Pix = 2,
    Debito = 3,
    Credito = 4,
}
