// Задача 11.
// Напишите программу, которая:
// 1. Выводит случайное трёхзначное число.
// 2. Удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782-> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine($"Искомое двухзначное число = {result}");

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Искомое двухзначное число = {removeSecondDigit}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}