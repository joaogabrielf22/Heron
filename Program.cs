Console.Clear();

double ladoA, ladoB, ladoC, s, area; // s = semiperímetro

Console.WriteLine("-= Calculadora de Heron =-\n");

Console.WriteLine("Insira as medidas do triângulo:");

Console.Write("Lado A: ");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado B: ");
ladoB = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado C: ");
ladoC = Convert.ToDouble(Console.ReadLine());

s = (ladoA + ladoB + ladoC) / 2;

area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

Console.WriteLine("\n-= Resultado =-\n");

Console.Write("Semiperímetro: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{s:N2}");

Console.ResetColor();

Console.Write("Área do triângulo: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{area:N2}");

Console.ResetColor();