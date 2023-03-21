﻿// Задача 44.
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// "Фибоначчи - сумма двух предидущих чисел (может начинаться с 0 или 1)"
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacciArray = FibonacciArray(number);
ArrayPrinted(fibonacciArray);

int[] FibonacciArray(int num)
{
     int[] arr = new int[num];
     // arr[0] = 0; можно не псиать т.к. изначально массив заполнен нулями.
     arr[1] = 1;
     for (int i = 2; i < num; i++)
     {
        arr[i] = arr[i-1] + arr[i-2];
     }
     return arr;
}

void ArrayPrinted(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}