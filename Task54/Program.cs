// Задача 54.
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int row = Prompt($"Введите количество строк: ");
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

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] SortedArray(int[,] newMatrix)
{
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
    for (int j = 0; j < newMatrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < newMatrix.GetLength(1) - 1; z++)
        {
            if (newMatrix[i, z] < newMatrix[i, z + 1])
            {
                int temp = 0;
                temp = newMatrix[i, z];
                newMatrix[i, z] = newMatrix[i, z + 1];
                newMatrix[i, z + 1] = temp;
            }
        }
    }
}
return newMatrix;
}

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array);
Console.WriteLine();

SortedArray(array);
PrintMatrix(array);