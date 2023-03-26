// Задача 53.
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество столбцов: ");
int startValue = Prompt($"Введите начало диапазона случайных чисел массива: ");
int endValue = Prompt($"Введите конец диапазона случайных чисел массива: ");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random { };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("");
    }
}

void ReplaceFirstLastRow(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
       int temp = matrix[firstRow, i];
        matrix[firstRow, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] array2d = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array2d);
ReplaceFirstLastRow(array2d);
Console.WriteLine();
PrintMatrix(array2d);