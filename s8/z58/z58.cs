// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int m = 2;
int n = 2;

Random rnd = new Random();

int[,] matrix1 = new int[m,n];
int[,] matrix2 = new int[m,n];
int[,] matrix3 = new int[m,n];

for (int i = 0; i < matrix1.GetLength(0); i++)
{for (int j = 0; j < matrix1.GetLength(1); j++)
    {Console.WriteLine($"Введите строку {i+1}, столбец {j+1} первой матрицы:  ");
    matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < matrix2.GetLength(0); i++)
{for (int j = 0; j < matrix2.GetLength(1); j++)
    {Console.WriteLine($"Введите строку {i+1}, столбец {j+1} второй матрицы:  ");
    matrix2[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}


matrix3[0,0]=matrix1[0,0]*matrix2[0,0]+matrix1[0,1]*matrix2[1,0];
matrix3[0,1]=matrix1[0,0]*matrix2[0,1]+matrix1[0,1]*matrix2[1,1];
matrix3[1,0]=matrix1[1,0]*matrix2[0,0]+matrix1[1,0]*matrix2[1,0];
matrix3[1,1]=matrix1[1,0]*matrix2[0,1]+matrix1[1,1]*matrix2[1,1];

Console.WriteLine("Произведение матриц:   ");

for (int i = 0; i < matrix3.GetLength(0); i++)
{

    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
    Console.Write($"{matrix3[i,j]};  ");
    }
    
 Console.WriteLine();
}