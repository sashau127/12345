// string[,] table = new string[3, 5];
// table[1, 2] = "слова";

// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"---{table[rows, columns]}");
//     }
// }

int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
for(int rows = 0; rows < 3; rows++)
{
    for(int columns = 0; columns < 4; columns++)
{
    Console.Write($"{matr[rows, columns]} ");

}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
 for(int rows = 0; rows < 3; rows++)
 {
   for(int columns = 0; columns < 4; columns++)
   {
    matr[rows, columns] = new Random().Next(1, 10);
   }
 }   
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);