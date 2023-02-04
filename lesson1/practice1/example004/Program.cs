// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("введите n");
int n = int.Parse(Console.ReadLine());
int b = -n;
while(b <= n)
{
    Console.Write($"{b} ");
    b = b+1;
}


