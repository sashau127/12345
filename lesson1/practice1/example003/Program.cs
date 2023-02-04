// написать программу, которая будет выдавать названия дней недели по заданному номеру
// 3-> среда
// 5 -> пятниц
Console.Write("ВВЕДИТЕ НОМЕР ДНЯ НЕДЕЛИ: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if(numberDayOfWeek < 1 || numberDayOfWeek >7)
{
    Console.WriteLine("такого дня недели не существует");
}