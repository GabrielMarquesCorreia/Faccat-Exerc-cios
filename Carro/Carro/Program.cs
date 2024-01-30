Console.WriteLine("Carro\r\n");

Console.Write("Escreva o preço de fábrica de um carro: R$");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine();

double d = n1 + (n1 * 28 / 100);
double i = n1 + (n1 * 45 / 100);
double r = n1 + d + i;

Console.WriteLine($"O valor deste carro é de R${r.ToString("N2")}.");