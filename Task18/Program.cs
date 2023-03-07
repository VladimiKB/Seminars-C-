// Задача 18.
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.WriteLine("Введите номер четверти: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string coordinateRange = CoordinateRange(numberQuarter);
string result = coordinateRange != "Error" // если, не равно (!=)
                ? $"Данной четверти соответствует диапазон координат -> {coordinateRange}" // тогда
                : "Введен некорректный номер четверти"; // иначе

Console.WriteLine(result);

string CoordinateRange(int numQuarter)
{
    if (numQuarter == 1) return "x > 0, y > 0";
    if (numQuarter == 2) return "x < 0, y > 0";
    if (numQuarter == 3) return "x < 0, y < 0";
    if (numQuarter == 4) return "x > 0, y < 0";
    return "Error";
}