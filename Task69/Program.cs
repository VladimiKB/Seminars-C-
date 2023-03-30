// Задача 69.
// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// Например:
// A = 3; B = 5 -> 243 (3 в 5 степени)
// A = 2; B = 3 -> 8

Console.Clear();

int Power(int numA, int numB)
{
if (numB == 0) return 1;
else return numA * Power(numA, numB - 1);
}

Console.WriteLine("Input number A:");
int numberA = Convert. ToInt32(Console. ReadLine ());

Console.WriteLine("Input number B:");
int numberB = Convert. ToInt32(Console. ReadLine ());


int pow = Power(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} = {pow}");