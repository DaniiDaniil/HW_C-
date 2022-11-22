//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Таблица кубов чисел от 1 до Вашего числа:");

int i = 1;

while (i < numb)
{   
    Console.Write($"{Math.Pow((i), 3)},  ");
    
    i++;
}

Console.Write($"{Math.Pow((i), 3)}.");
