int quantidadeCadastrar;
string nomeProduto;
int quantidadeProduto;
decimal precoProduto;


List<string> nomesProdutos = new List<string>();
List<int> quantidadesProdutos = new List<int>();
List<decimal> precoProdutos = new List<decimal>();

quantidadeCadastrar = ValidarInteiro("Quantos produtos deseja cadastrar: ");

for (int i = 0; i < quantidadeCadastrar; i++)
{
    nomeProduto = ValidarString($"Digite o nome do produto {i+1}: ");
    nomesProdutos.Add(nomeProduto);

    precoProduto = ValidarDecimal($"Digite o preço do produto {i+1}: ");
    precoProdutos.Add(precoProduto);

    quantidadeProduto = ValidarInteiro($"Digite a quantidade desse produto {i+1}: ");
    quantidadesProdutos.Add(quantidadeProduto);
}

decimal valorTotalEmEstoque =0;
decimal maiorValor = 0;
int menorEstoque = quantidadesProdutos[0];
string nomeProdutoMaisCaro = "";
string nomeProdutoMenorEstoque = "";

int contadorLista = ContadorLista(quantidadesProdutos);

for (int i = 0; i < contadorLista; i++)
{
    valorTotalEmEstoque += quantidadesProdutos[i] * precoProdutos[i];

    if(precoProdutos[i] > maiorValor)
    {
        maiorValor = precoProdutos[i];
        nomeProdutoMaisCaro = nomesProdutos[i];
    }

    if(quantidadesProdutos[i] < menorEstoque)
    {
        menorEstoque = quantidadesProdutos[i];
        nomeProdutoMenorEstoque = nomesProdutos[i];
    }
}

Console.WriteLine("====== RELATÓRIO DE PRODUTOS ======");
for (int i = 0; i < contadorLista; i++)
    Console.WriteLine($"Produto {i + 1}: {nomesProdutos[i]} | {precoProdutos[i]:C} | {quantidadesProdutos[i]} quantidades");
Console.WriteLine();
Console.WriteLine($"Valor total em estoque: {valorTotalEmEstoque:C}");
Console.WriteLine($"Produto mais caro: {nomeProdutoMaisCaro}");
Console.WriteLine($"Produto com menor estoque: {nomeProdutoMenorEstoque}");








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

decimal ValidarDecimal (string mensagem)
{
    decimal entrada;
    Console.WriteLine(mensagem);
    while(!decimal.TryParse(Console.ReadLine(), out entrada) || entrada <= 0)
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