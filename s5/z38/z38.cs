//Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int length = 5;

double[] mass = new double[length];

Random rnd = new Random();

for (int i = 0; i < length; i++)
{mass[i] = rnd.Next(-1000,1001);}

double max = mass[0], min = mass[0];

for (int i = 0; i < length; i++)
{if (max<=mass[i])
{max = mass[i];}}

for (int i = 0; i < length; i++)
{if (min>=mass[i])
{min = mass[i];}}

double dif = max - min;

Console.WriteLine("["+string.Join("; ", mass)+"]");
Console.WriteLine("Максимальное значение =  "+max);
Console.WriteLine("Минимальное значение =  "+min);
Console.WriteLine("Разница между максимальным и минимальным значениями =  "+ dif);