//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.Write("Введите цифру, обозначающую день недели:  ");

int numb=Convert.ToInt32(Console.ReadLine());

if (numb==6|numb==7)
{
    Console.Write($"День недели    В Ы Х О Д Н О Й");
}
else
{
    Console.Write($"День недели   Р А Б О Ч И Й");
}