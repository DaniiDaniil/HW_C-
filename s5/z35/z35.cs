//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[ 10, 11, 12, 13, 14 ] -> 5

int[] mass = new int[123];

Random rnd = new Random();

int count = 0;

for (int i = 0; i < 123; i++)
{mass[i] = rnd.Next(-1000,1000);
    if (mass[i]>9 && mass[i]<100)
    {
        count++;
    }
}

Console.WriteLine("["+string.Join(", ", mass)+"]");
Console.Write("Количество чисел от 10 до 99 =  "+count);

