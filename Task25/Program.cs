// Задача 25.
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int exponent = a;

for (int i = 1; i < b; i++)
{
exponent *= a;
}
Console.WriteLine("A в степени B равно: " + exponent);

