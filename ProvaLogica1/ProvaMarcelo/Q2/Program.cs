List<string> nomesAlunos = new List<string>();
List<double> notas1 = new List<double>();
List<double> notas2 = new List<double>();
List<double> notas3 = new List<double>();
List<double> mediasAlunos = new List<double>();
List<SituacaoProvaEnum> situacoesAlunos = new List<SituacaoProvaEnum>();

string nomeAluno;
double nota1;
double nota2;
double nota3;
double mediaAluno;

int quantidadeCadastrarAluno = ValidarInteiro("Quantos alunos deseja cadastrar: ");

for (int i = 0; i < quantidadeCadastrarAluno; i++)
{
    nomeAluno = ValidarString($"Digite o nome do Aluno {i + 1}: ");
    nomesAlunos.Add(nomeAluno);

    nota1 = ValidarDoubleIntervalado($"Digite sua nota 1: ", 0, 10);
    notas1.Add(nota1);

    nota2 = ValidarDoubleIntervalado($"Digite sua nota 2: ", 0, 10);
    notas2.Add(nota2);

    nota3 = ValidarDoubleIntervalado($"Digite sua nota 3: ", 0, 10);
    notas3.Add(nota3);
}

int contadorLista = ContadorLista(nomesAlunos);

for (int i = 0; i < contadorLista; i++)
{
    mediaAluno = (notas1[i] + notas2[i] + notas3[i]) / 3;
    mediasAlunos.Add(mediaAluno);
}

int contadorAprovado = 0;
int contadorRecuperacao = 0;
int contadorReprovado = 0;

for (int i = 0; i < contadorLista; i++)
{
    if (mediasAlunos[i] < 5)
    {
        situacoesAlunos.Add(SituacaoProvaEnum.Reprovado);
        contadorReprovado++;
    }
    else if (mediasAlunos[i] < 7)
    {
        situacoesAlunos.Add(SituacaoProvaEnum.Recuperacao);
        contadorRecuperacao++;
    }
    else
    {
        situacoesAlunos.Add(SituacaoProvaEnum.Aprovado);
        contadorAprovado++;
    }
}

Console.WriteLine("=== BOLETIM DA TURMA ===");
for (int i = 0; i < contadorLista; i++)
{
    Console.WriteLine($"Aluno: {nomesAlunos[i]}");
    Console.WriteLine($"Notas: {notas1[i]}, {notas2[i]}, {notas3[i]}");
    Console.WriteLine($"Média: {mediasAlunos[i]:f2}");
    Console.WriteLine($"Situação: {situacoesAlunos[i]}");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Aprovados: {contadorAprovado}");
Console.WriteLine($"Recuperação: {contadorRecuperacao}");
Console.WriteLine($"Reprovados: {contadorReprovado}");

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

enum SituacaoProvaEnum
{
    Aprovado = 1,
    Recuperacao = 2,
    Reprovado = 3,
    Indisponivel = 4,
}
