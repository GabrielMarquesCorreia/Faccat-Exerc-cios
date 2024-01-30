Console.WriteLine("Celsius\r\n");

Console.Write("Escreva um valor de graus em Fahrenheit: ");
int fahrenheit = int.Parse(Console.ReadLine());

Console.WriteLine();

double celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"O valor de {fahrenheit}°F equivale ao mesmo que {celsius}°C.");
