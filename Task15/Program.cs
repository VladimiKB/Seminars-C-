// Задача 15.
// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введи цифру, обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

void CheckingDayWeek (int numberDay)
{
  if (numberDay == 6 || numberDay == 7)
  {
  Console.WriteLine("Этот день недели выходной -> да");
  }
  else if (numberDay < 1 || numberDay > 7)
  {
    Console.WriteLine("Это вообще не день недели");
  }
  else Console.WriteLine("Этот день недели не выходной -> нет");
}

CheckingDayWeek(numberDay);
