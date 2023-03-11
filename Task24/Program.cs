// Задача 24.
// Напишите программу, которая:
// 1. Принимает на вход число (А).
// 2. Выдаёт сумму чисел от 1 до A.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + i
    }

    return sum;
}