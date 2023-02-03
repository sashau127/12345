// напишите программу, которая на вход принимает число, а на выход дает квадрат этого числа
// 4 -> 16
// -7 -> 49
// -3 -> 9
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"квадрат числа {number} равен {sqr}");