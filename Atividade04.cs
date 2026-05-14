static string LerNomeCliente(string mensagem)
{
    Console.Write(mensagem);
    string cliente = Console.ReadLine()!;
    return cliente;
}

static double LerValorCompra(string mensagem)
{
    Console.Write(mensagem);
    double valorCompra = double.Parse(Console.ReadLine()!);
    return valorCompra;
}

static double CalcularDesconto(double valorCompra)
{
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
    return valorFinal;
}

static void ExibirCompra()
{
    string cliente = LerNomeAluno("Digite o nome do cliente: ");
    double valorCompra = LerValorCompra("Digite o valor da compra: ");
    double valorFinal = CalcularDesconto(valorCompra);

    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {valorCompra - valorFinal}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}
