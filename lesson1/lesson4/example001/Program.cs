string[,] table = new string[3, 5];
table[1, 2] = "слова";

for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"---{table[rows, columns]}");
    }
}