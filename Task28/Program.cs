// Задача 28.
// Напишите программу, которая:
// 1. Принимает на вход число N.
// 2. Выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiply = MultiplicationNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiply}");

int MultiplicationNumbers(int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
    {
        multiply *= i; // multiply = multiply * i
    }

    return multiply;
}