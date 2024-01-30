Console.WriteLine("Comissão por venda\r\n");

double soma = 0;

Console.Write("Escreva quantas vendas um funcionário fez em uma concessionária: R$ ");
int vendas = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1;  i <= vendas; i++)
{
    Console.Write($"Escreva o valor da {i}° venda: R$ ");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine();

    double comissao = valor * 0.05;

    soma += comissao;

}

Console.Write("Agora o atual salário deste funcionário: R$ ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine();

double ganho = salario + soma;

Console.Write($"Este funcionário terá um ganho de 5% das vendas, portanto receberá no próximo salário um total de R$ {ganho}");
