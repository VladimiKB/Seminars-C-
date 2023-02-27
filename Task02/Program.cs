// Задача 2.
// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3


Console.WriteLine("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"max = {numberB}");
}
else Console.Write("Числа равны.");
