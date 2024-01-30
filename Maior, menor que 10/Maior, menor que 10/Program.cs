Console.WriteLine("Maior, menor que 10\r\n");

Console.Write("Escreva um número: ");
float num = float.Parse(Console.ReadLine());

if (num > 10)
{
    Console.WriteLine("Este número é maior que 10!!");
}
else if (num == 10)
{
    Console.WriteLine("Este número é igual a 10!!");
}
else
{
    Console.WriteLine("Este número é menor que 10!!");
}
