// Задача 67.
// Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// Например:
// 453 -> 12
// 45 -> 9

Console.Clear();

// МЕТОД ВЫЧИСЛЕНИЯ ФАКТОРИАЛА

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }
// Console.WriteLine (FactorialRec(10));

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа = {sumNumbers}");

int SumNumbers(int num)
{
if (num == 0) return 0;
else return num % 10 + SumNumbers(num / 10);
}