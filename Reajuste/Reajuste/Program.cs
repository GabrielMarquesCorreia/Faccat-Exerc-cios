Console.WriteLine("Reajuste\r\n");

Console.Write("Escreva o atual salário de um funcionário: R$");
float salarioAtual = float.Parse(Console.ReadLine());

Console.WriteLine();

while (true)
{
    Console.Write("Agora escreva (-) para caso este funcionário receber uma diminuição salarial, ou (+) para caso este\r\n funcionário receber um aumento salarial: ");
    char op = char.Parse(Console.ReadLine());

    Console.WriteLine();

    if (op == '+')
    {
        Console.Write("Agora escreva quantos % ele receberá de aumento: ");
        float aumento = float.Parse(Console.ReadLine());

        double reajuste = (salarioAtual * aumento) / 100;
        double soma = salarioAtual + reajuste;

        Console.WriteLine();

        Console.WriteLine($"Este terá um slário de R${soma}.");
        break;
    }
    else if (op == '-')
    {
        Console.Write("Agora escreva quantos % ele perderá no slário: ");
        float aumento = float.Parse(Console.ReadLine());

        double reajuste = (salarioAtual * aumento) / 100;
        double soma = salarioAtual - reajuste;

        Console.WriteLine();

        Console.WriteLine($"Este terá um slário de R${soma}.");
        break;
    }
    else
    {
        Console.WriteLine("ERRO!! Por favor, escreva apenas (-) para um reajuste negativo ou (+) para um reajuste positivo\r\n no salário do funcionário.\r\n");
    }
}

