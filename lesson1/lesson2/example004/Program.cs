int[] array = {1, 5, 8, 95, 857, 587, 57, 85};

int n = array.Length;
int find = 95;

int index = 0;
 while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        index = index+1;
    }
}