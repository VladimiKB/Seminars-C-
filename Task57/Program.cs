// Задача 57.
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.
// Например:

// набор данных:                       частотный массив:

// {1, 9, 9, 0, 2, 8, 0, 9}            О встречается 2 раза
//                                     1 встречается 1 раз
//                                     2 встречается 1 раз
//                                     8 встречается 1 раз
//                                     9 встречается 3 раза

// 1, 2, 3                             1 встречается 3 раза
// 4, 6, 1                             2 встречается 2 раз
// 2, 1, 6                             3 встречается 1 раз
//                                     4 встречается 1 раз
//                                     6 встречается 2 раза

Console.Clear();

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество столбцов: ");
int startValue = Prompt($"Введите начало диапазона случайных чисел массива: ");
int endValue = Prompt($"Введите конец диапазона случайных чисел массива: ");

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

int[] MatrixToArrey(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[count] = matrix[i, j];
            count++;
        }
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void FrequencyDictionaryFromArray(int[] array)
{
    int currentValue = array[0];
    int counter = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentValue) counter++;
        else
        {
            Console.WriteLine($"Элемент {currentValue} встречается {counter} раз(а)");
            currentValue = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"Элемент {currentValue} встречается {counter} раз(а)");
}

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array);
Console.WriteLine();

int[] newArr = MatrixToArrey(array);
Array.Sort(newArr);
PrintArray(newArr);
Console.WriteLine();

FrequencyDictionaryFromArray(newArr);