List<string> nomeAluno = new List<string>();
List<decimal> notaAluno = new List<decimal>();

decimal nota;
decimal mediaNotas;
decimal maiorNota = decimal.MinValue;
decimal menorNota = decimal.MaxValue;
int contadorNota7 = 0;
int contadorNota5 = 0;
decimal somaNotas = 0m;
string desempenho;

for (int i = 0; i < 3; i++)
{
    Console.Write("Digite o nome do Aluno: ");
    nomeAluno.Add(Console.ReadLine());
    Console.Write("Digite sua nota: ");
    while (!decimal.TryParse(Console.ReadLine(), out nota) || nota <= 0)
        Console.WriteLine("Nota informada inválida");
    notaAluno.Add(nota);
}

for (int i = 0; i < notaAluno.Count; i++)
{
    somaNotas += notaAluno[i];
    if (notaAluno[i] > maiorNota)
        maiorNota = notaAluno[i];
      
    if (notaAluno[i] < menorNota)
        menorNota = notaAluno[i];
    
    if (notaAluno[i] >= 7)
        contadorNota7++;
    else
        contadorNota5++;

}

mediaNotas = somaNotas/notaAluno.Count;

if (mediaNotas < 5)
    desempenho = "Fraca";
else if (mediaNotas < 6)
    desempenho = "Regular";
else if (mediaNotas < 8)
    desempenho = "Boa";
else
    desempenho = "Excelente";

Console.Clear();
Console.WriteLine($"=== RELATÓRIO DA TURMA ===");
Console.WriteLine($"Média: {mediaNotas:f2}");
Console.WriteLine($"Maior nota: {maiorNota}");
Console.WriteLine($"Menor nota: {menorNota}");
Console.WriteLine($"Aprovados: {contadorNota7}");
Console.WriteLine($"Reprovados: {contadorNota5}");
Console.WriteLine($"Desempenho: {desempenho}");
