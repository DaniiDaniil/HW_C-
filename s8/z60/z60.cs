// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] matrix = new int[2,2,2];

for (int x = 0; x < matrix.GetLength(2); x++)
{for (int i = 0; i < matrix.GetLength(0); i++)
{for (int j = 0; j < matrix.GetLength(1); j++)
    {Console.WriteLine($"Введите строку {i+1}, столбец {j+1}, страницу {x+1}:  ");
    matrix[i,j,x] = Convert.ToInt32(Console.ReadLine());
    }
}
}

for (int x = 0; x < matrix.GetLength(2); x++)
{for (int i = 0; i < matrix.GetLength(0); i++)
{for (int j = 0; j < matrix.GetLength(1); j++)
    {Console.Write($"{matrix[i,j,x]} [{i},{j},{x}]; ");}
Console.WriteLine();}
}