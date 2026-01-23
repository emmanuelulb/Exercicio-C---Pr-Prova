// string nomeFuncionario;
// decimal salarioBruto = 0;
// decimal horasExtra = 0;
// decimal valorHoraExtra = 0;
// string recebeValeTransporte = "";
// decimal salarioComHorasExtras;
// decimal salarioDescontoInss;
// decimal salarioDescontoVT;
// decimal taxaInssPorcentagem = 0;
// decimal taxaInss;
// decimal taxaVTPorcentagem = 0;
// decimal taxaVt = 0;

// Console.Write("Digite o nome do funcionário: ");
// nomeFuncionario = Console.ReadLine();
// nomeFuncionario = ValidadorString(nomeFuncionario);

// Console.Write("Digite o salário do funcionário: ");
// salarioBruto = ValidadorDecimal(salarioBruto);

// Console.WriteLine("Digite a quantidade de horas extras trabalhadas: ");
// horasExtra = ValidadorDecimal(horasExtra);

// Console.WriteLine("Digite o valor da horas extras: ");
// valorHoraExtra = ValidadorDecimal(valorHoraExtra);

// Console.WriteLine("Recebe vale transporte (Sim/Não): ");
// recebeValeTransporte = ValidadorString(recebeValeTransporte).ToLower();

// salarioComHorasExtras = salarioBruto + horasExtra*valorHoraExtra;

// Console.WriteLine("Digite a taxa de inss(%): ");
// taxaInssPorcentagem = ValidadorDecimal(taxaInssPorcentagem);

// taxaInss = salarioComHorasExtras * (taxaInssPorcentagem/100);
// salarioDescontoInss = salarioComHorasExtras - taxaInss;

// Console.WriteLine("Digite a taxa de vale transporte(%): ");
// taxaVTPorcentagem = ValidadorDecimal(taxaVTPorcentagem);

// if (recebeValeTransporte.Equals("sim"))
// {
//     taxaVt = salarioDescontoInss*taxaVTPorcentagem/100;
//     salarioDescontoVT = salarioDescontoInss - taxaVt;
// }

// else
//     salarioDescontoVT = salarioDescontoInss;

// Console.Clear();
// Console.WriteLine("=== FOLHA DE PAGAMENTO ===");
// Console.WriteLine();
// Console.WriteLine($"Bruto total: {salarioBruto:C}");
// Console.WriteLine($"Horas extras: {horasExtra}");
// Console.WriteLine($"Valor hora extra: {valorHoraExtra:C}");
// Console.WriteLine();
// Console.WriteLine($"Valor descontado INSS: {taxaInss:C}");
// Console.WriteLine($"Valor descontado VT: {taxaVt:C}");
// Console.WriteLine();
// Console.WriteLine($"Líquido a receber: {salarioDescontoVT:C}");

string ValidadorString (string variavelString)
{
    while (string.IsNullOrWhiteSpace(variavelString))
    {
        Console.WriteLine("Entrada inválida, tente novamente: ");
        variavelString = Console.ReadLine();
    }
    return variavelString;
}

decimal ValidadorDecimal (decimal variavelDecimal)
{
    while(!decimal.TryParse(Console.ReadLine(), out variavelDecimal) || variavelDecimal < 0)
        Console.WriteLine("Entrada inválida, tente novamente: ");    
    return variavelDecimal;
}

List<int> teste = [2, 3, 4, 5];

int valor = ContadorLista(teste);

for (int i = 0; i < valor; i++)
    Console.WriteLine($"indice {i}: {teste[i]}");

teste.Add(9);
teste.Add(1);

valor = ContadorLista(teste);


for (int i = 0; i < valor; i++)
    Console.WriteLine($"indice {i}: {teste[i]}");

int ContadorLista<T> (List<T> lista)
{
    int contador = 0;
    foreach ( var item in lista)
        contador++;

    return contador;
}


