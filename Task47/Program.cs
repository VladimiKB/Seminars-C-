// Задача 47.
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// Например:
// 0,5   7    -2    -0,2
// 1    -3,3   8    -9,9
// 8     7,8  -7,1   9

Console.Clear();

int row = Prompt($"Введите количество строк: ");
int col = Prompt($"Введите количество столбцов: ");
int startValue = Prompt($"Введите начало диапазона случайных чисел массива: ");
int endValue = Prompt($"Введите конец диапазона случайных чисел массива: ");

double[,] CreateMatrixRndRealNum(int rows, int columns, int min, int max)
{
    Random rnd = new Random { };
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(startValue, endValue)) / 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("");
    }
}

double[,] array2d = CreateMatrixRndRealNum(row, col, startValue, endValue);
PrintMatrix(array2d);

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
