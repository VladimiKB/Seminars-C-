// Задача 12.
// Напишите программу, которая будет принимать на вход два числа и
// выводить, является ли первое число кратным второму. Если первое
// число не кратно второму числу, то программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// int remains = number1 % number2;

// 1 способ
// if (remains == 0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Не кратно, остаток: {remains}");

// 2 способ
// Console.WriteLine(remains == 0 ? "кратно" : $"не кратно, остаток {remains}");

// 3 способ
// string result = remains == 0 ? "кратно" : $"не кратно, остаток {remains}";
// Console.WriteLine(result);

int remains = Remains(number1, number2);
string result = remains == 0 ? "кратно" : $"не кратно, остаток {remains}";
Console.WriteLine(result);

int Remains(int num1, int num2)
{
    return num1 % num2;
}