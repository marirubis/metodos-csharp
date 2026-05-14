/*
Refatore o arquivo Calc.cs, deixe tudo dentro de função, 

Sugestão:
- Crie uma função Menu(){  } , que quando executada chama a função Opção() { }
na última linha do código chame a função Menu();

*/

/* 
double numero1;
double numero2;
double resultado = 0;
string opcao;
string continuar = "s";

while (continuar == "s" || continuar == "S")
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("+ Soma");
        Console.WriteLine("- Subtração");
        Console.WriteLine("* Multiplicação");
        Console.WriteLine("/ Divisão");
        Console.Write("Escolha uma opção: ");
        opcao = Console.ReadLine()!;

        Console.Write("Digite o primeiro número: ");
        numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        numero2 = double.Parse(Console.ReadLine()!);

        if (opcao == "+")
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"Resultado da soma: {resultado}");
        }
        else if (opcao == "-")
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"Resultado da subtração: {resultado}");
        }
        else if (opcao == "*")
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }
        else if (opcao == "/")
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

    Console.WriteLine();
    Console.Write("Deseja fazer outro cálculo? (s/n): ");
    continuar = Console.ReadLine()!;
}

Console.Write("Fim de programa!!");
*/
