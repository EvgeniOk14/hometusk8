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
    int[] m = new int[matrix.GetLength(0)];  
    int sum =0;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {         
                 sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   sum = sum + matrix[i,j];
                }
                   Console.WriteLine("Сумма " + i + " строки равна " + " " + sum);
                   m[i] = sum;
    }
                   Console.WriteLine("одномерный массив, состоящий из сумм строк: ");
                   Console.WriteLine($"[{String.Join(" ", m)}]");      

                  int SumMin = m[0];
                   for (int i = 0; i < m.Length -1; i++)
                     {
                         
                           for (int j=1; j < m.Length; j++)
                           {
                            
                                  if (m[i]  < SumMin) 
                                    {
                                      SumMin = m[i];
                                    }
                            }
                     }
                  Console.WriteLine("Минимальная сумма равна "  + SumMin); 
 }

Console.Clear();
Console.Write("Введите размеры массива ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("введённый массив: ");
InputArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReleaseArray(matrix);


