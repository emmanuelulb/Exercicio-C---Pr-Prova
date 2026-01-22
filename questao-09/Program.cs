string atividade;
int numeroDeAtividadesIniciais;
int posicaoTarefaUrgente;
List<string> tarefasEstudo = new List<string>();

Console.WriteLine("Quantas tarefas deseja adicionar inicialmente a sua rotina: ");
while (!int.TryParse(Console.ReadLine(), out numeroDeAtividadesIniciais) || numeroDeAtividadesIniciais < 1)
    Console.WriteLine("Entrada inválida, tente novamente: ");

for (int i = 0; i < numeroDeAtividadesIniciais; i++)
{
    while (true)
    {
        Console.Write("Digite sua tarefa desejada: ");
        atividade = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(atividade))
        {   
            Console.Write("Entrada inválida, tente novamente: ");
            i--;
        }
        else
            break;
    }

    tarefasEstudo.Add(atividade);
}


Console.Write("Digite sua tarefa que você lembrou posteriomente: ");
atividade = Console.ReadLine();

while (string.IsNullOrWhiteSpace(atividade) || !atividade.Any(char.IsLetter))
{
    Console.Write("Entrada inválida, tente novamente: ");
    atividade = Console.ReadLine();
}

tarefasEstudo.Add(atividade);


while (true)
    {
        Console.Write("Digite sua tarefa de caratér urgente: ");
        atividade = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(atividade))
            Console.Write("Entrada inválida, tente novamente: ");

        else
            break;
    }

Console.WriteLine("Qual posição dessa tarefa urgente: ");
while (!int.TryParse(Console.ReadLine(), out posicaoTarefaUrgente) || posicaoTarefaUrgente < 0)
    Console.WriteLine("Entrada inválida, tente novamente: ");

tarefasEstudo.Insert(posicaoTarefaUrgente , atividade);


while (true)
    {
        Console.Write("Qual tarefa deseja saber se tem: ");
        atividade = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(atividade))
            Console.Write("Entrada inválida, tente novamente: ");
        else
            break;
    }

bool contemAtividade = tarefasEstudo.Contains(atividade);
if (contemAtividade)
    Console.WriteLine($"Contém \"{atividade}\"");
else
{
    Console.WriteLine($"Não Contém \"{atividade}\"");
    tarefasEstudo.Add(atividade);
}


while (true)
    {
        Console.Write("Qual tarefa você já finalizou: ");
        atividade = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(atividade))
            Console.Write("Entrada inválida, tente novamente: ");
        else
            break;
    }
tarefasEstudo.Remove(atividade);

Console.Clear();
Console.WriteLine("=== SUA LISTA FINAL ===");
int indiceListaFinal = 1;
foreach (var tarefa in tarefasEstudo)
{
    Console.WriteLine($"{indiceListaFinal}. {tarefa}");
    indiceListaFinal++;
}
