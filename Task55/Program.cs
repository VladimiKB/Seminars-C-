// Задача 55.
// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.

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

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// ПЕРВЫЙ МЕТОД РЕШЕНИЯ (через создание новой матрицы)

// int[,] ReplaceRowWithColumn(int[,] matr)
// {
//     int[,] anotherMatrix = new int[matr.GetLength(1), matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             anotherMatrix[j, i] = matr[i, j];
//         }
//     }
//     return anotherMatrix;
// }

void ReplaceRowWithColumn(int[,] matr)
{
       for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            int temp = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temp;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array2d);
Console.WriteLine();

if (array2d.GetLength(0) == array2d.GetLength(1))
{
    // int[,] moreNewMatrix = ReplaceRowWithColumn(array2d);
    ReplaceRowWithColumn(array2d);
    // PrintMatrix(moreNewMatrix);
    PrintMatrix(array2d);
}
else
{
    Console.WriteLine("Замена строк на столбцы невозможна.");
}

