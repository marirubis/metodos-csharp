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