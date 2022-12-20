// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите число строк:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

double[,] matrix = new double[m,n];

for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {matrix[i,j] = rnd.Next(-100,100);
    Console.Write($"{matrix[i,j]};  ");
    }
    
 Console.WriteLine();
}

double sum;
Console.WriteLine("Среднее арифметическое в каждом столбце равно:");

for (int col = 0; col < matrix.GetLength(1); col++)
{
    sum = 0;

    for (int str = 0; str < matrix.GetLength(0); str++)
    {sum = sum + matrix[str,col];}
    
    Console.WriteLine($"В {col+1}-м столбце равно: {sum/matrix.GetLength(0)}");
}