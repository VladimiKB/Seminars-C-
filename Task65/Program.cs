// Задача 65.
// Задайте значения М и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от М до N.
// Например:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

Console.WriteLine("Введите целое число М: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(numberM, numberN);

// РЕКУРСИВНЫЙ МЕТОД

// void NaturalNumbersRange(int numM, int numN)
// {
//     if (numM == numN)
//     {
//         Console.Write($"{numM}");
//         return;
//     }
//     if (numM < numN)
//     {
//         Console.Write($"{numM} ");
//         NaturalNumbersRange(numM + 1, numN);
//     }
//     else
//     {
//         Console.Write($"{numM} ");
//         NaturalNumbersRange(numM - 1, numN);
//     }
// }

// МЕТОД 2

void NaturalNumbersRange(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersRange(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersRange(numM - 1, numN);
    }
    else
    {
        Console.Write($"{numM}");
    }
}