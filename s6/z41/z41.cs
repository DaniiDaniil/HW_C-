// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

System.Console.WriteLine("Какое количество чисел вы введете?   ");

int M =Convert.ToInt32(Console.ReadLine());

int[] mass = new int[M];

int count = 0;

for (int i = 0; i < M; i++)
{
System.Console.WriteLine($"Введите {i+1}-е число:  ");

mass[i] =Convert.ToInt32(Console.ReadLine());

if (mass[i]>0)
{count++;}
}

Console.Write("Количество чисел больше нуля:" + count);