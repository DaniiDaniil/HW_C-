//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] mass = new int[7];

Random rnd = new Random();

int sum = 0;

for (int i = 0; i < 7; i++)
{mass[i] = rnd.Next(-1000,1000);}

for (int i = 1; i < 7; i+=2)
{sum = sum + mass[i];}

Console.WriteLine("["+string.Join(", ", mass)+"]");
Console.Write("Сумма чисел, стоящих на нечетных позициях =  "+sum);