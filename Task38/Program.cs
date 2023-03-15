// Задача 38.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите целое число - размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вещественное число - минимальное число диапазона значений: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вещественное число - максимальное число диапазона значений: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random { };
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void ArrayPrintedDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DiffBetweenMax(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double DiffBetweenMin(double[] arr)
{
    double min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(size, min, max);
ArrayPrintedDouble(array);

double diffBetweenMax = DiffBetweenMax(array);
double diffBetweenMin = DiffBetweenMin(array);
Console.WriteLine($"Максимальное значение массива: {diffBetweenMax}");
Console.WriteLine($"Минимальное значение массива: {diffBetweenMin}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {diffBetweenMax - diffBetweenMin}");
