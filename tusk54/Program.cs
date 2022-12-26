void InputArray(int[,] matrix)
{
  for (int i =0; i < matrix.GetLength(0); i++)
  {
     for (int j =0; j < matrix.GetLength(1); j++)
     {
        matrix[i,j] = new Random().Next(0,101);
     }
  }
}
void PrintArray(int[,] matrix)
{
  for (int i =0; i < matrix.GetLength(0); i++)
   {
     for(int j= 0; j < matrix.GetLength(1); j++)
     Console.Write($"{matrix[i,j]} \t");
     Console.WriteLine();
   }
}

void ReleaseArray(int[,] matrix)
{
    
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[i, j] > matrix[i, k]) 
                        {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                        }
                    }
                }
    }                 
} 
Console.Clear();
Console.Write("Введите размеры массива ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("введённый массив: ");
InputArray(matrix);
PrintArray(matrix);
Console.WriteLine("отсортированный массив: ");
ReleaseArray(matrix);
PrintArray(matrix); 

