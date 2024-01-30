Console.WriteLine("Postivo ou negativo\r\n");

Console.Write("Escreva um número: ");
float num = float.Parse(Console.ReadLine());

if (num < 0 )
{
    Console.WriteLine("Este número é negativo.");
}
else
{
    Console.WriteLine("Este número é positivo.");
}
