Console.WriteLine("Eleição");

Console.Write($"Escreva quantos eleitores tiveram em um município: ");
int e = int.Parse( Console.ReadLine());

Console.Write($"Agora escreva o total de votos em branco: ");
int b = int.Parse( Console.ReadLine());

Console.Write($"Agora escreva o total de votos nulos: ");
int n = int.Parse( Console.ReadLine());

Console.Write($"Agora escreva o total de votos válidos: ");
int v = int.Parse(Console.ReadLine());

double tB = 100 * b / e;
double tN = 100 * n / e;
double tV = 100 * v / e;

Console.WriteLine($"Este município teve um total de {e} votos, {tB.ToString("N2")}% das pessoas votaram em branco, {tN.ToString("N2")}% das pessoas votaram nulo, {tV.ToString("N2")}% das pessoas tiveram votos válidos.");
