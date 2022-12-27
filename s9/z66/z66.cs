// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите меньшее число:  ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите большее число:  ");
int M = Convert.ToInt32(Console.ReadLine());

int numb (int N)
{   
    if (N==M)
        {return N;}

    else
        {return N + numb(N+1);}
}
Console.Write($"Сумма всех натуральных чисел в промежутке между указанными числами равна: {numb (N)}.");  