// Задача 8.
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int divTwo = 2;
if(number > 1)
{
    while(divTwo <= number)
    {
        Console.Write(divTwo + " ");
        divTwo = divTwo + 2;
    }
}