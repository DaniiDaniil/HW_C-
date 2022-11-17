//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

int count=0;

System.Console.Write($"Четные числа от 1 до вашего: ");

while (count<numb)
{count+=2;
{System.Console.Write($"{count}, ");}
} 

