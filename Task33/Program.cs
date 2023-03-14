// Задача 33.
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив (6, 7, 19, 345, 3] -> да

int length = Prompt("введите целое число - длинна массива: ");
int min = Prompt("введите целое число - начальное число диапазона значении: ");
int max = Prompt("введите челое число начальное число пиапазона значении: ");

int[] arr = CreateArrayRndInt(length, min, max);
OutputArray(arr);

int number = Prompt("введите искомое число: ");
Console.WriteLine(FindNumber(number, arr)
    ? $"Число {number} найдено"
    : $"Число {number} не найдено");

bool FindNumber(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

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

void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



