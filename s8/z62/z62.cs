// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4,4];
int count = 01;


for (int i = 0; i < 4; i++)
{matrix[0,i]=count;
count++;
}
for (int i = 0; i < 4; i++)
{matrix[i,3]=count;
count++;
}
for (int i = 2; i > -1; i--)
{matrix[3,i]=count;
count++;
}
for (int i = 2; i > 0; i--)
{matrix[i,0]=count;
count++;
}
for (int i = 1; i < 3; i++)
{matrix[1,i]=count;
count++;
}
for (int i = 2; i > 0; i--)
{matrix[2,i]=count;
count++;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{for (int j = 0; j < matrix.GetLength(1); j++)
       {Console.Write($"{matrix[i,j].ToString("00")} ");}
Console.WriteLine();}