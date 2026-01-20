        ## ✅ PROVA 1

### Questão 1 — Venda com Frete e Desconto Condicional
Uma loja online registrou a seguinte mensagem do pedido:

>“Cliente levou "X" unidades do produto Y. Cada unidade custa R$ XXXX,XX. O frete padrão está marcado como R$ 35,00. A promoção do dia pode ou não estar ativa, com 12% de desconto sobre o subtotal caso seja ativada. 
Regra do frete: se o subtotal for maior ou igual a R$ 800,00, o frete será grátis.”

**Tarefas**
- Ler/receber os valores (por input) e **converter** para os tipos corretos  
- Exibir relatório formatado

**Saída Esperada**
```
=== FECHAMENTO DE COMPRA ===
Produto: <nome>
Preço Unitário: R$ <preco>
Quantidade: <qtd>

Subtotal: R$ <subtotal>
Promoção ativa: <Sim/Não>
Desconto (12%): R$ <desconto>

Frete aplicado: R$ <frete>
VALOR FINAL: R$ <final>
```

---

### Questão 2 — Classificação de Aluno (Média + Frequência)

>“Um aluno recebe três notas, a primeira tem peso 1, a segunda nota tem peso 5 e a ultima nota peso 4, para o aluno ser aprovado ele precisa ter uma frequência de pelo menos 75% de assiduidade, caso contrario ele será reprovado diretamente. O aluno será aprovado se sua média for pelo menos 7.0, caso a média seja entre e 5 e 7, o aluno irá para recuperação, caso contrario o aluno será reprovado por nota.
”

**Saída Esperada**
```
=== BOLETIM FINAL ===
Aluno: <nome>
Notas: <n1>, <n2>, <n3>
Média: <media>
Frequência: <freq>%

Situação: <situação final>
```

---

### Questão 3 — Relatório de Notas com Lista
O professor anotou no diário digital:

> “Insira a quantidade de alunos que uma turma de estagiarios deve ter, e dê uma nota média para cada um. apos isso informe: ”
- Calcular:
  - média
  - maior e menor
  - quantas notas pelo menos 7 (aprovados)
  - quantas notas menor que 5 (reprovados)
- Classificação desempenho(faixas bem claras):
  - média pelo menos 8,0 → “Excelente”
  - média pelo menos 6,0 e menor que 8,0 → “Boa”
  - média pelo menos 5,0 e menor que 6,0 → “Regular”
  - média menor que 5,0 → “Fraca”

**Saída Esperada**
```
=== RELATÓRIO DA TURMA ===
Nota 1: <valor>
...
Média: <media>
Maior: <maior>
Menor: <menor>
Aprovados: <qtd>
Reprovados: <qtd>
Desempenho: <classificação>
```

---

### Questão 4 — Controle de Estoque com Dicionário
O gerente deixou escrito no relatório:

> “Estoque atual: Mouse = **10** unidades, Teclado = **6**, Monitor = **4**, Cabo HDMI = **18**, Cadeira = **5**. Hoje entrou o produto SSD com **7** unidades. O Teclado foi recontado e agora tem **12**. Precisamos verificar se existe Webcam no estoque. Também remover o Monitor do sistema.
Deve informar quantos e quais itens estão com estoque baixo (menos que 8)”


**Saída Esperada**
```
=== ESTOQUE INICIAL ===
...

=== OPERAÇÕES ===
Adicionado: SSD (7)
Atualizado: Teclado (12)
Existe Webcam? <Sim/Não>
Estoque baixo (<8): <qtd>
Removido: Monitor

=== ESTOQUE FINAL ===
...
Total de produtos: <total>
```

---

### Questão 5 — Validação e Processamento de Compra (Texto → Tipos)
O checkout enviou esta mensagem como texto:

> “informe o nome do cliente, quao o valor da compra, forma de pagamento, e se teve algum cupom.”

**Regras (faixas bem claras)**
- Cupom:
  - se cupom = true -> desconto de **10%**
  - se cupom = false -> desconto = **0**
- Pagamento:
  - Dinheiro -> desconto adicional **5%**
  - PIX -> desconto adicional **3%**
  - Débito -> **0%**
  - Crédito -> **taxa de 5%**
- Parcelamento:
  - Se pagamento = Crédito -> mostrar valor de cada parcela
  - Caso contrário -> “Pagamento à vista”

**Saída Esperada**
```
=== COMPRA ONLINE ===
Cliente: <nome>

CÁLCULO
Valor original: R$ <v>
Cupom: R$ <desconto cupom>
Ajuste pagamento: R$ <ajuste>
Valor final: R$ <final>
Pagamento: <forma>
Tipo: <À vista/Parcelado>
Parcela: R$ <valor parcela> (se crédito)
```

---

## ✅ PROVA 2: Lógica de Programação e Interpretação

### Questão 1 — O E-mail da Concessionária de Energia
Carlos Menezes recebeu a fatura de energia elétrica deste mês por e-mail, informando que seu consumo foi de **350 kWh**. O texto da fatura explica que o valor base do kWh na região é de **R$ 0,72**.

No rodapé, há um aviso importante sobre a política de tarifas:

> "Prezado cliente, este mês estamos operando com a **Bandeira Amarela**. Lembramos que a Bandeira Verde não gera custos extras; a **Amarela** gera uma taxa adicional de **5%** sobre o valor consumido; e a Vermelha acarreta um adicional de **10%**."

Além disso, a empresa destaca o programa de sustentabilidade:
> "Consumidores que gastarem **menos de 200 kWh** receberão um bônus (desconto) automático de **8%** sobre o valor do consumo. Para consumos iguais ou superiores a esse limite, não há bonificação."

**Sua missão:** Crie um programa que processe essas informações e gere o extrato final detalhado.

=== FATURA ===
Cliente: "nome "
Subtotal: R$ 
Bandeira (cor): + R$ "valor do acréscimo"
Desconto: - R$ "valor do desconto"
TOTAL A PAGAR: R$ "valor final"

---

### Questão 2 — A Política de Crédito do Banco
O sistema do banco recebeu uma solicitação de empréstimo da cliente **Input**. Os dados extraídos do formulário mostram que ela tem uma renda mensal de **R$ valor**, um Score de crédito de **valor** pontos e está no emprego atual há **tempo**.

O departamento de risco enviou o seguinte memorando com as regras de aprovação:

1. Clientes com renda muito alta (**R$ 4.000 ou mais**) ou uma renda de pelo menos **R$ 2.800** e esmpregado a 6 meses são aprovados automaticamente, recebendo um limite de crédito equivalente a **40%** de sua renda.
2. Para quem ganha menos de R$ 4.000, a aprovação é mais rígida: o cliente precisa, **simultaneamente**, ter:
   * Renda de pelo menos **R$ 2.000**;
   * Score mínimo de **650**;
   * Estar empregado há pelo menos **10 meses**.
   * *Se passar nesses três critérios, o limite liberado será de **25%** da renda.*
3. Qualquer outro caso deve ser reprovado automaticamente.

**Sua missão:** Determine se será aprovada e, em caso positivo, qual o valor exato do limite liberado.

=== ANÁLISE DE CRÉDITO ===
Cliente: "nome"
Renda Mensal: R$
Score:
Tempo de Emprego: "meses" meses
Status: "Aprovado/Reprovado"
Limite de Crédito: R$ "valor do limite"

---

### Questão 3 — O Fechamento do Caixa da Lanchonete
Ao final do expediente, o gerente da lanchonete recolheu as comandas manuais e digitou os valores dos 7 pedidos realizados no dia:
`22,50`; `18,00`; `45,00`; `9,50`; `60,00`; `12,00` e `30,00`.

Ele precisa de um relatório estatístico para a diretoria. O sistema deve listar todos os valores e calcular o faturamento total. A diretoria pediu atenção especial para pedidos "premium" (aqueles **maiores que R$ 30,00**), exigindo a contagem de quantos foram. Também é necessário identificar qual foi a venda mais cara, a mais barata e a média de valor por pedido.

Por fim, o sistema deve classificar o dia de vendas com base no faturamento total, seguindo a escala da franquia:
* **"Ótimo"**: Total de R$ 200,00 ou mais.
* **"Bom"**: Total entre R$ 120,00 (inclusive) e R$ 200,00.
* **"Regular"**: Total entre R$ 60,00 (inclusive) e R$ 120,00.
* **"Fraco"**: Total abaixo de R$ 60,00.

**Sua missão:** Processe a lista de pedidos e gere o relatório completo com a classificação de desempenho.

=== RELATÓRIO DO DIA ===
Faturamento Total: R$ "soma"
Pedidos > R$30: "quantidade"
Maior Venda: R$ "maior"
Menor Venda: R$ "menor"
Status do dia: "classificação"

---

### Questão 4 — O Organizador de Tarefas do Estudante
Um estudante está tentando organizar sua rotina de estudos usando um software de listas. Ele começou o dia digitando a seguinte sequência de tarefas:

1. Estudar lógica
2. Fazer exercícios
3. Revisar conteúdo
4. Enviar atividade

No entanto, a rotina mudou. Ele precisa que o sistema realize as seguintes atualizações na ordem:

1. Lembrou que precisa **"Ler apostila"**, mas pode deixar para o final de tudo.
2. A tarefa **"Assistir aula"** é urgente e precisa ser encaixada logo na **2ª posição** da lista.
3. Ele quer consultar o sistema para saber se a tarefa **"Almoçar"** já está cadastrada na lista, caso não esteja, essa tarefa deve ser adicionada ao final da lista.
4. Como ele já terminou de **"Revisar conteúdo"**, essa tarefa deve ser removida da lista.

**Sua missão:** Manipule a estrutura de lista conforme os passos acima e exiba a lista final atualizada .

=== SUA LISTA FINAL ===
1. "tarefa"
2. "tarefa"
...

---

### Questão 5 — Integração de Sistema Legado (RH)
Você está criando um formulário de cadastro de funcionários para o RH. O problema é que o usuário pode digitar qualquer coisa, mas o sistema precisa garantir que os cálculos sejam feitos matematicamente.
Entradas de Dados: Solicite os dados como texto simples (string), simulando um formulário web cru:
"Digite o Nome do Funcionário:"
"Digite o Salário Bruto:"
"Digite as Horas Extras:"
"Digite o Valor da Hora Extra:"
"Recebe Vale-Transporte? (digite 'sim' ou 'nao'):"

Para processar a folha, o sistema novo deve seguir este roteiro:
1. **Conversão:** Converter esses textos para as tipagens certas.
2. **Cálculo Bruto:** Somar ao salário bruto o valor total das horas extras.
3. **INSS:** Sobre o montante total, deve ser descontado **8%**.
4. **Vale-Transporte:** Verificar o campo do Vale-Transporte.
   * Se o valor for verdadeiro, deve-se descontar **6%** do montante total.
   * Se for falso, não há desconto de VT.

=== FOLHA DE PAGAMENTO ===
Bruto Total: R$ "valor bruto"
(+) Horas Extras: R$ "valor horas extras"
(-) INSS: R$ "valor inss"
(-) VT: R$ "valor"
========================
Líquido a Receber: R$ "valor líquido"