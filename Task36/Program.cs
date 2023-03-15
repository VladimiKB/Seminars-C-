// Задача 36.
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите целое число - размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число - минимальное число диапазона значений: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число - максимальное число диапазона значений: ");
int max = Convert.ToInt32(Console.ReadLine());

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

int SumElemOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(size, min, max);
ArrayPrinted(array);

int sumElemOddPosition = SumElemOddPosition(array);
Console.WriteLine($"Сумма элементов на четных позициях = {sumElemOddPosition}");
