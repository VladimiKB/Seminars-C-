// Задача 66.
// Задайте значения М и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от М до N.
// Выполнить с помощью рекурсии.

// Например:

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

Console.WriteLine("Введите целое число М: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int sumNaturalNumbers = SumNaturalNumbers(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sumNaturalNumbers}");
Console.WriteLine();

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN)
    {
        //Console.Write($"{numM}");
        return numM;
    }
    if (numM < numN)
    {
        //Console.Write($"{numM} ");
        return numM + SumNaturalNumbers(numM + 1, numN);
    }
    else
    {
        //Console.Write($"{numM} ");
        return numN + SumNaturalNumbers(numM, numN + 1);
    }
}