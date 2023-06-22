Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
 arr[i, j] = random.Next(1, 10);
 Console.Write(arr[i, j] + " ");
    }
 Console.WriteLine();
}
double sum = 0;
for (int j = 0; j < arr.GetLength(1); j++)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(i == j)
        {
          sum += arr[i, j];
        }
        
    }
 
}
Console.Write($"Cумма элементов, находящихся на главной диагонали: {sum}");
