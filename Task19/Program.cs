// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// string reverse = string.Concat(number.Reverse());
// Console.WriteLine(number == reverse ? "палиндром" : "не палиндром");

// Console.WriteLine("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine());
// int rev = 0, num = number;
// while (number > 0)
// {
//     rev = rev * 10 + number % 10; number /= 10;
// }
// Console.WriteLine(num == rev ? "палиндром" : "не палиндром");

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int rev = 0, num = number;
while (number > 0)
{
    rev = rev * 10 + number % 10; number /= 10;
}
Console.WriteLine(num == rev ? "палиндром" : "не палиндром");