// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество столбцов: ");
int startValue = Prompt($"Введите начало диапазона случайных целых чисел массива: ");
int endValue = Prompt($"Введите конец диапазона случайных целых чисел массива: ");
Console.WriteLine();

void MatrixAverageColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage += matrix[i, j];
    }
    avarage /= row;
    avarage = Math.Round(avarage, 2);
    Console.Write(avarage + "; ");
}
}

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

int[,] array2d = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array2d);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
MatrixAverageColumn(array2d);


// int matrixAverageColumn = MatrixAverageColumn(array2d);
// Console.WriteLine($"Среднее аримфметическое столбцов: {matrixAverageColumn}; ");

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}