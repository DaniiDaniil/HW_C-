// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5
System.Console.Write("Введите число   ");

int N = Convert.ToInt32(Console.ReadLine());

int numb (int N)
{
if (N==0) return 0;
else
{
    return 1 + numb(N/10);
}
}
Console.Write($"Количество цифр равно: {numb(N)}");