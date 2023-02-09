// // вид1
// void Method1()
// {
//     Console.WriteLine("автор ...");
// }
// Method1();

// // вид2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("крамбабуля");

// void Method21(string msg, int count)
//  {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
//  }
//  Method21("текст", 4);

// //вид3

// int Method3()
// {
//     return DateTime.Now.Month;
// }
// int month = Method3();
// Console.WriteLine(month);

//вид4
string Method4(int count, string c)
{
int i = 0;
string result = String.Empty;

while(i < count)
{
    result = result + c;
    i++;
}
return result;
}
string res = Method4(24, "арафат");
Console.WriteLine(res);