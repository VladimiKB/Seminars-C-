// Задача 45.
// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random { };
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void ArrayPrinted(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(5, -10, 10);
ArrayPrinted(array);

int[] newArray = CopyArray(array);
// проверка, что мы получаем новый массив - можно "newArray[0] = 111;" 
// присвоить нулевому индексу второго массива число, отличное от первого массива.
ArrayPrinted(newArray);