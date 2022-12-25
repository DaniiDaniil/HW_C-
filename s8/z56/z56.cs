// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int min=1000;
int sum;
int str = 0;
int x = 0;

while (x < matrix.GetLength(0))
{
     sum = 0;
    for (int z = 0; z < matrix.GetLength(1); z++)
    {sum = sum + matrix[x,z];}
if (sum<min)
{min=sum;
str = x;
}
    
 Console.WriteLine();

x++;

}

Console.WriteLine($"Минимальная сумма в строке равна: {min} ({str+1}-я строка)");