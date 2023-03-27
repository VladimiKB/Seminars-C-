// Задача 58.
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int rowA = Prompt($"Введите количество строк первой матрицы: ");
int colA = Prompt($"Введите количество столбцов первой матрицы: ");
int rowB = Prompt($"Введите количество строк второй матрицы: ");
int colB = Prompt($"Введите количество столбцов второй матрицы: ");
int startValue = Prompt($"Введите начало диапазона случайных чисел массива: ");
int endValue = Prompt($"Введите конец диапазона случайных чисел массива: ");
Console.WriteLine();

int[,] matrixA = CreateMatrixRndInt(rowA, colA, startValue, endValue);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = CreateMatrixRndInt(rowB, colB, startValue, endValue);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrixB);
Console.WriteLine();


int[,] resultMatrix = MultiplyMatrix(matrixA, matrixB);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintMatrix(resultMatrix);
Console.WriteLine();

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0)) throw new Exception("Матрицы нельзя перемножать.");
    int[,] resultMatrix = new int[rowA, colB];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
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

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
