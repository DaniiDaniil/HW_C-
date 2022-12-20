// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.Write("Напишите число, которое хотите найти в массиве:  ");
int numb = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {   if (matrix[i,j] == numb)
    {Console.WriteLine($"строка {i+1}, столбец {j+1} = {numb};");}
        else
        {count++;}
    }

}
if (count==m*n)
{
    Console.Write("Числа нет в массиве");
}
