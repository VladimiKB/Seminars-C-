// Задача 21.
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// Например:
// A (3, 6, 8); B (2, 1, -7) -> 15.84
// A (7, -5, 0); B (1, -1, 9) -> 11.53

Console.WriteLine("Input first dot coordinates");
Console.WriteLine("X");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second dot coordinates");
Console.WriteLine("X");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z");
int zB = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance(xA, yA, zA, xB, yB, zB), 2, MidpointRounding.ToZero);

Console.WriteLine($"This number squared is {result}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}