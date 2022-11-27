//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] mass = new int [8];

for (int i = 0; i < 8; i++)
{System.Console.Write($"Введите {i+1}-e число   ");

mass [i] = Convert.ToInt32(Console.ReadLine());
}

    Console.Write(string.Join(", ", mass));