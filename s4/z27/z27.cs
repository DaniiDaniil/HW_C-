//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (numb>0)
{sum = sum + numb%10;
numb/=10;    
}

Console.Write(sum);