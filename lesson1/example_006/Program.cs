Console.WriteLine("введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("ура!!! это же маша!!!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username); 
}