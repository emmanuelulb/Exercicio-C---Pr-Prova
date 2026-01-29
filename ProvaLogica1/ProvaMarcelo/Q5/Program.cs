int idadeMinima = 18;
int idadeMaxima = 120;
int contadorAtivos = 0;
int contadorInativos = 0;
int contadorMaior30Anos = 0;
string usuarioAtivo = "a";
string usuarioInativo = "i";
int idadeMaior = 30;
string statusUsuario = "";

List<string> nomesUsuarios = new List<string>();
List<int> idadesUsuarios = new List<int>();
List<string> emailsUsuarios = new List<string>();
List<string> statusUsuarios = new List<string>();

int quantidadeRegistros = ValidarInt("Digite quantos clientes deseja cadastrar: ");

for (int i = 0; i < quantidadeRegistros; i++)
{
    nomesUsuarios.Add(ValidarString($"Digite o nome do usuario {i + 1}: "));
    idadesUsuarios.Add(ValidarIntIntervalado("Digite sua idade (18-120): ", idadeMinima, idadeMaxima));
    emailsUsuarios.Add(ValidarEmail("Digite o email do usuário: "));
    statusUsuarios.Add(ValidarChar("Digite o status do usuário (A - Ativo/ I - inativo): \n"));
}

int contadorItensLista = ContagemLista(nomesUsuarios);

Console.Clear();
Console.WriteLine("=== USUÁRIOS CADASTRADOS ===");

for (int i = 0; i < contadorItensLista; i++)
{
    if (usuarioAtivo == statusUsuarios[i])
        contadorAtivos++;

    if (usuarioInativo == statusUsuarios[i])
        contadorInativos++;
    
    if (idadeMaior < idadesUsuarios[i])
        contadorMaior30Anos++;

    if (statusUsuarios[i].Equals("a"))
        statusUsuario = "Ativo";
    else    
        statusUsuario = "Inativo";

    Console.WriteLine($"Nome: {nomesUsuarios[i]}");
    Console.WriteLine($"Idade: {idadesUsuarios[i]}");
    Console.WriteLine($"Email: {emailsUsuarios[i]}");
    Console.WriteLine($"Status: {statusUsuario}\n");
}
Console.WriteLine();
Console.WriteLine($"Usuários Ativos: {contadorAtivos}");
Console.WriteLine($"Usuários Inativos: {contadorInativos}");
Console.WriteLine($"Usuários acima de 30 anos: {contadorMaior30Anos}");

string ValidarChar (string mensagem)
{
    Console.Write(mensagem);
    string entrada = Console.ReadLine().ToLower();
    while(entrada!="a" && entrada != "i")
    {
        Console.WriteLine("Erro. Tente novamente: ");
        entrada = Console.ReadLine();
    }
    return entrada;
}

string ValidarString (string mensagem)
{
    Console.Write(mensagem);
    string entrada = Console.ReadLine();
    while(string.IsNullOrWhiteSpace(entrada) || entrada.Any(c=>!char.IsLetter(c)&&!char.IsWhiteSpace(c)))
    {
        Console.WriteLine("Erro. Tente novamente: ");
        entrada = Console.ReadLine();
    }
    return entrada;
}

int ValidarInt (string mensagem)
{
    int entrada;
    Console.Write(mensagem);
    while(!int.TryParse(Console.ReadLine(), out entrada))
        Console.WriteLine("Erro, digite novamente: ");
    return entrada;
}

int ValidarIntIntervalado (string mensagem, int minimo, int maximo)
{
    int entrada;
    Console.Write(mensagem);
    while(!int.TryParse(Console.ReadLine(), out entrada) || entrada < minimo || entrada > maximo)
        Console.WriteLine("Erro, digite novamente: ");
    return entrada;
}

string ValidarEmail (string mensagem)
{
    Console.Write(mensagem);
    string email = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains(".") || email.StartsWith("@") || email.StartsWith(".") || email.EndsWith("@") || email.EndsWith("."))
    {
    Console.WriteLine($"Email Invalido. Deve conter '@' e '.'.\nTente Novamente: ");
    email = Console.ReadLine();
    }
    return email;
}

int ContagemLista<T> (List<T> lista)
{
    int contador = 0;
    foreach (var item in lista)
        contador++;
    return contador;
}
