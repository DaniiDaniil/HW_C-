//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.Write("Введите число   ");

int numb=Math.Abs(Convert.ToInt32(Console.ReadLine()));

int N = numb;

int[] digits;

digits = new int[5];

for (int i = 0; i < 5; i++)
{
        digits[i]=N%10; 

        N = N/10;
}

if (numb > 9999 && numb < 100000)
 {  if (digits[0] == digits[4] && digits[1] == digits[3])
    {Console.Write($"Число является палиндромом");}
    else
    {Console.Write($"Число не является палиндромом");}

 }
else
    {Console.Write($"Число не пятизначное, введите пятизначное число и попробуйте снова");} 
