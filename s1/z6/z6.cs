//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

if (numb%2==0)
{System.Console.Write($"четное");
}

else
{   System.Console.Write($"нечетное");
    }