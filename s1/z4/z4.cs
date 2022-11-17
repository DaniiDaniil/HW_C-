//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.Write("Введите первое число   ");

int numb1=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число   ");

int numb2=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число   ");

int numb3=Convert.ToInt32(Console.ReadLine());


if (numb1>=numb2&&numb1>=numb3)
{System.Console.Write($"max={numb1}");
}

else
{   if (numb2>=numb1&&numb2>=numb3)
   { System.Console.Write($"max={numb2}");
    }
    else {System.Console.Write($"max={numb3}");
    }
}