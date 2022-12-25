// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите число строк:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

int[,] matrix = new int[m,n];

for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {matrix[i,j] = rnd.Next(-100,100);
    Console.Write($"{matrix[i,j]};  ");
    }
    
 Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

int max;
int save;

for (int i = 0; i < matrix.GetLength(0); i++)
{        
  
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   max = -1000;
      for (int count = j; count < matrix.GetLength(1); count++)
      { 
        if (matrix[i,count] >= max)
        {max = matrix[i,count];
        save = matrix[i,j];
        matrix [i,j]=max;
        matrix[i,count]=save;
        }
    
                 
      }
      
    
    Console.Write($"{matrix[i,j]};  ");
    }
    
 Console.WriteLine();
}
