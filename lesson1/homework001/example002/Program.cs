// Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



int a = 44;
int b = 5;
int c = 292;
int max = a;
if (max < b)
 {
    max = b;
 }
 if (max < c)
{
  max = c;
}
else
{
  max = a;
}

Console.WriteLine(max);


