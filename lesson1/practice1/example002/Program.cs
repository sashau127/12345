// напишите программу, которая на вход принимает два числа, и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 49, b = 7 -> да
Console.Write("введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
