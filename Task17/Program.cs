﻿// Задача 17.
// Напишите программу, которая
// 1. принимает на вход координаты точки (X и Y),
// причём X # 0 и Y # 0
// 2. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.WriteLine("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 // если
                ? $"Указанные координаты соответствуют четверти -> {quarter}" // тогда
                : "Введены некорректные координаты"; // иначе

Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
