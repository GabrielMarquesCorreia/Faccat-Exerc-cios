Console.WriteLine("Maçãs\r\n");

Console.Write("Escreva quantas maçãs você deseja comprar em uma feira: ");
int macas = int.Parse(Console.ReadLine());

Console.WriteLine();

if (macas < 12)
{
    double r = macas * 1.30;
    Console.WriteLine($"Você decidiu comprar {macas} maçãs, portanto gastará um total de R${r.ToString("N2")}");
}
else
{
    Console.WriteLine($"Você decidiu comprar {macas} maçãs, portanto gastará um total de R${macas}");
}
