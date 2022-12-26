void InputArray1(int[,] matrix)
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
/*void ReleaseArray(int[,]matrix)
{
 int[,] matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
 int product = 1;
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           
        }
      }
}
*/
Console.Clear();
Console.Write("Введите размеры массива ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
Console.WriteLine("1й массив matrix1: ");
for (int i =0; i < matrix1.GetLength(0); i++)
  {
     for (int j =0; j < matrix1.GetLength(1); j++)
     {
        matrix1[i,j] = new Random().Next(0,101);
     }
  }
PrintArray(matrix1);
Console.WriteLine();
int[,]matrix2 = new int[size[0], size[1]];
Console.WriteLine("2й массив matrix2: ");
for (int i =0; i < matrix2.GetLength(0); i++)
  {
     for (int j =0; j < matrix2.GetLength(1); j++)
     {
        matrix2[i,j] = new Random().Next(0,101);
     }
  }
PrintArray(matrix2);
 Console.WriteLine();
 Console.WriteLine("3Й массив - произведение первых двух: ");
 int[,] matrix = new int[size[0], size[1]];
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = matrix1[i,j] * matrix2[i,j];
           
           Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
      }
