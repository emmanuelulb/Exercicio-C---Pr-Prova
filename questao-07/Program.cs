decimal valorRendaMensal;
decimal scoreCredito;
DateTime admissaoNoEmprego;
DateTime hoje = DateTime.Today;
decimal limiteCredito;
string nomeCliente;
string statusEmprestimo;
while (true)
{
    Console.Write("Digite o nome do Cliente: ");
    nomeCliente = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(nomeCliente))
        Console.WriteLine("Nome inválido ou vazio");
    else
        break;
}

Console.Write("Digite o valor da renda mensal: ");
while(!decimal.TryParse(Console.ReadLine(), out valorRendaMensal) || valorRendaMensal < 0)
    Console.WriteLine("Entrada inválida. Tente novamente.");

Console.Write("Digite o score: ");
while(!decimal.TryParse(Console.ReadLine(), out scoreCredito) || scoreCredito < 0)
    Console.WriteLine("Entrada inválida. Tente novamente.");

Console.Write("Data da admissão (AAAA-MM-DD): ");
while(!DateTime.TryParse(Console.ReadLine(), out admissaoNoEmprego))
    Console.WriteLine("Data inválida");

TimeSpan tempoNoEmprego = hoje - admissaoNoEmprego;
int tempoNoEmpregoMeses = tempoNoEmprego.Days/30;

if (valorRendaMensal >= 4000 || (valorRendaMensal >= 2800 && tempoNoEmpregoMeses >= 6))
{
    limiteCredito = valorRendaMensal*0.4m;
    statusEmprestimo = "Aprovado";
}
else
{
    if (valorRendaMensal >= 2000 && scoreCredito >=650 && tempoNoEmpregoMeses >= 10)
    {   
        limiteCredito = valorRendaMensal*0.25m;
        statusEmprestimo = "Aprovado";
    }
    else
    {
        limiteCredito = 0;
        statusEmprestimo = "Reprovado";
    }
}

Console.Clear();
Console.WriteLine("=== ANÁLISE DE CRÉDITO ===");
Console.WriteLine($"Cliente: {nomeCliente}");
Console.WriteLine($"Renda Mensal: {valorRendaMensal:C}");
Console.WriteLine($"Score: {scoreCredito}");
Console.WriteLine($"Tempo de emprego: {tempoNoEmpregoMeses}");
Console.WriteLine($"Status: {statusEmprestimo}");
Console.WriteLine($"Limite Crédito: {limiteCredito:C}");
