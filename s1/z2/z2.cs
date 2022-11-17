//напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

System.Console.Write("Введите первое число   ");

int numb1=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число   ");

int numb2=Convert.ToInt32(Console.ReadLine());

if (numb1>numb2)
{System.Console.Write($"max={numb1}");
System.Console.Write($"min={numb2}");
}

else
if(numb1==numb2)
{System.Console.Write($"max={numb2}    ");
System.Console.Write($"   min={numb1}");
    }