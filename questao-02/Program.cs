string nomeAluno;
decimal nota1;
decimal nota2;
decimal nota3;
decimal mediaNotas;
decimal frequencia;
string situacaoAluno;

Console.Write("Digite seu nome: ");
nomeAluno = Console.ReadLine();

Console.Write("Digite a primeira Nota: ");
while (!decimal.TryParse(Console.ReadLine(), out nota1))
    Console.WriteLine("Quantidade informada inválida\n");

Console.Write("Digite a segunda Nota: ");
while (!decimal.TryParse(Console.ReadLine(), out nota2))
    Console.WriteLine("Quantidade informada inválida\n");

Console.Write("Digite a terceira Nota: ");
while (!decimal.TryParse(Console.ReadLine(), out nota3))
    Console.WriteLine("Quantidade informada inválida\n");

Console.WriteLine("Digite a frequência do aluno(%): ");
while (!decimal.TryParse(Console.ReadLine(), out frequencia))
    Console.WriteLine("Quantidade informada inválida\n");

frequencia /= 100;
if (frequencia < 0.8m)
{
    situacaoAluno = "Reprovado por falta";
    Console.Clear();
    Console.WriteLine($"=== BOLETIM FINAL ===");
    Console.WriteLine($"Aluno: {nomeAluno}");
    Console.WriteLine($"Situação: {situacaoAluno}");
}

else
{
    mediaNotas = ((nota1 * 1) + (nota2 * 5) + (nota3 * 4)) / 10m;

    if (mediaNotas < 5)
        situacaoAluno = "Reprovado";
    else if (mediaNotas < 7)
        situacaoAluno = "Fazer recuperação";
    else
        situacaoAluno = "Aprovado";

    Console.Clear();
    Console.WriteLine($"=== BOLETIM FINAL ===");
    Console.WriteLine($"Aluno: {nomeAluno}");
    Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
    Console.WriteLine($"Média: {mediaNotas}");
    Console.WriteLine($"Frequencia: {frequencia:p}");
    Console.WriteLine();
    Console.WriteLine($"Situação: {situacaoAluno}");
}


