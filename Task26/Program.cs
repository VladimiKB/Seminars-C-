// Задача 26.
// Напишите программу, которая:
// 1. Принимает на вход число.
// 2. Выдаёт количество цифр в числе.
// Например:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitNumbers = DigitNumbers(number);
Console.WriteLine($"Количество цифр в числе {number} = {digitNumbers}");

int DigitNumbers(int num)
{
    int digits = 0;
    while (num > 0)
    {
       num /= 10;
       digits++; 
    }
    return digits;
}