// Задача 40.
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// "Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон."

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool isExistTriangle = IsExistTriangle(a, b, c);
Console.WriteLine(isExistTriangle ? "truth" : "false");

bool IsExistTriangle(int side1, int side2, int side3)
{
    return side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2;
}