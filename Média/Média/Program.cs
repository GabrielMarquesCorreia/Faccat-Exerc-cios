Console.WriteLine("Média\r\n");

float n1 = 0;
float n2 = 0;
float n3 = 0;

Console.Write("Escreva o nome do aluno: ");
string name = Console.ReadLine();

Console.WriteLine();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Escreva a {i}° do aluno: ");
    float num = float.Parse( Console.ReadLine() );

    if (i == 1)
    {
        n1 = num;
    }
    if (i == 2)
    {
        n2 = num;
    }
    if (i == 3)
    {
        n3 = num;
    }
}

double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

Console.WriteLine();

Console.WriteLine($"A média de notas do aluno {name} é igual a: {media.ToString("N2")}");

if (media >= 6)
{
    Console.WriteLine($"O aluno {name} foi aprovado.");
}
else
{
    Console.WriteLine($"O aluno {name} foi reprovado.");
}
