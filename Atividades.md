# Atividades Práticas — Métodos em C#

**Curso:** Técnico em Desenvolvimento de Sistemas  
**Tema da aula:** Métodos em C#  
**Objetivo:** praticar a criação, chamada, organização e reutilização de métodos em programas de console.

---

## Orientações gerais

Nesta aula, você deverá resolver os exercícios utilizando **métodos em C#**.

Cada atividade deve conter:

- Um método principal para controlar o fluxo do programa.
- Métodos separados para leitura de dados, processamento e exibição de resultados.
- Nomes de métodos claros e relacionados à responsabilidade executada.
- Uso de `return` quando o método precisar devolver algum valor.
- Uso de `void` quando o método apenas executar uma ação, como exibir uma mensagem.
- Use o arquivo `Program.cs para desenvolver` quando resolver a atividade, salve o conteúdo no respectivo arquivo.
- 


Evite resolver toda a lógica dentro do `Main`. O objetivo da aula é treinar a **organização do código por responsabilidade**.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Atividade 01 — Sistema de cálculo de média escolar

## Situação-problema

Uma escola deseja criar um pequeno programa para calcular a média final de um aluno. O sistema deve receber o nome do aluno e três notas. Ao final, deve exibir a média e informar se o aluno foi aprovado, ficou em recuperação ou foi reprovado.

## Regras de negócio

- Média maior ou igual a 7: aluno aprovado.
- Média maior ou igual a 5 e menor que 7: aluno em recuperação.
- Média menor que 5: aluno reprovado.

## Requisitos do programa

Crie um programa em C# que possua, no mínimo, os seguintes métodos:

```csharp
static string LerNomeAluno(){}
static double LerNota(string mensagem){}
static double CalcularMedia(double nota1, double nota2, double nota3){}
static string VerificarSituacao(double media)
static void ExibirResultado(string nome, double media, string situacao){}
```

## Entrega esperada

O programa deve solicitar o nome do aluno, receber três notas, calcular a média e exibir a situação final.

## Exemplo de saída

```text
Nome do aluno: Ana
Nota 1: 8
Nota 2: 7
Nota 3: 6

Aluno: Ana
Média final: 7,00
Situação: Aprovado
```

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Atividade 02 — Sistema de tabuada personalizada

## Situação-problema

Um professor deseja criar um programa para ajudar alunos do ensino fundamental a estudar tabuada. O sistema deve permitir que o usuário escolha um número e exibir a tabuada de 1 até 10.

## Regras de negócio

- O usuário deve informar o número da tabuada.
- O sistema deve exibir a multiplicação de 1 até 10.
- Após exibir a tabuada, o programa deve perguntar se o usuário deseja consultar outra.

## Requisitos do programa

Crie métodos para:

```csharp
static int LerNumeroTabuada() {}
static void ExibirTabuada(int numero){}
static string LerContinuacao() {}
static bool DesejaContinuar(string resposta) {}
static void ExecutarTabuada() {}
```

## Entrega esperada

O programa deve usar repetição e métodos para permitir a consulta de várias tabuadas.

## Exemplo de saída

```text
Digite o número da tabuada: 7

7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70

Deseja consultar outra tabuada? s/n: s
```

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Atividade 03 — Conversor de temperatura - RESPONDIDO

## Situação-problema

Uma empresa precisa de um programa para converter temperaturas entre Celsius e Fahrenheit. O usuário deve escolher o tipo de conversão e informar a temperatura.

## Regras de negócio

- Celsius para Fahrenheit: `(celsius * 9 / 5) + 32`
- Fahrenheit para Celsius: `(fahrenheit - 32) * 5 / 9`
- O sistema deve exibir o resultado da conversão.

## Requisitos do programa

Crie métodos para:

```csharp
static void ExibirMenuConversao() { }
static string LerOpcaoConversao() { }
static double LerTemperatura() { }
static double ConverterCelsiusParaFahrenheit(double celsius) { }
static double ConverterFahrenheitParaCelsius(double fahrenheit) { }
static void ExibirResultadoConversao(double resultado, string unidade) { }
```

## Entrega esperada

O programa deve permitir a escolha da conversão e apresentar o resultado corretamente.

## Exemplo de saída

```text
=== CONVERSOR DE TEMPERATURA ===
1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
Escolha uma opção: 1
Digite a temperatura: 30

Resultado: 86 °F
```

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


# Atividade 04 — Refatoração de código sem métodos

## Situação-problema

O código abaixo funciona, mas está concentrando todas as responsabilidades em um único bloco. Sua tarefa é refatorar o programa utilizando métodos.

## Código inicial

```csharp
Console.Write("Digite o nome do cliente: ");
string cliente = Console.ReadLine()!;

Console.Write("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine()!);

double desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.15;
}
else
{
    desconto = valorCompra * 0.05;
}

double valorFinal = valorCompra - desconto;

Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
```

## Tarefa

Reorganize o código criando, no mínimo, os seguintes métodos:

```csharp
static string LerNomeCliente()
static double LerValorCompra()
static double CalcularDesconto(double valorCompra)
static double CalcularValorFinal(double valorCompra, double desconto)
static void ExibirResumo(string cliente, double valorCompra, double desconto, double valorFinal)
```

## Entrega esperada

O programa deve manter o mesmo funcionamento, porém com o código separado em métodos.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Atividade 05 — Refatoração de código sem métodos

## Situação-problema

O código no arquivo Avividade05.cs não faz uso de métodos.


## Tarefa

Reorganize o código usando métodos para todos os casos possíveis