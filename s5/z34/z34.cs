//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] mass = new int[4];

Random rnd = new Random();

mass[0] = rnd.Next(100,999);
mass[1] = rnd.Next(100,999);
mass[2] = rnd.Next(100,999);
mass[3] = rnd.Next(100,999);

int count = 0;

for (int i = 0; i < 4; i++)
{if (mass[i]%2==0)
{count++;}}

Console.WriteLine("["+string.Join(", ", mass)+"]");
Console.Write(count);