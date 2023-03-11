// Задача 29.
//  Напишите программу, которая:
// 1. Задаёт массив из 8 элементов.
// 2. Выводит их на экран.
// Например:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++) // size == arrey.Length
    {
        array[i] = rnd.Next(0, 101);
    }
    return array;
}

void OutputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int[] arr = CreateArray(8);
OutputArray(arr);



