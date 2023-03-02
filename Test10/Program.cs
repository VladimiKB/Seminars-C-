// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра введенного числа = {secondDigit}");

int SecondDigit(int num)
{
    int twoDigit = num / 10;
    int result = twoDigit % 10;
    return result;
}