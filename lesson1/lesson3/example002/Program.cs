﻿string Method4(int count, string c)
{
string result = String.Empty;
for (int i = 0; i < count; i++)
{
    result = result + c;
   
}
return result;
}
string res = Method4(24, "арафат");
Console.WriteLine(res);