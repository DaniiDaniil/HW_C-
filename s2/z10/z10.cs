//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

if(numb>99&&numb<1000){

    int fig1=numb/100*100;

    int fig3=numb%10;

    int fig2=(numb-fig1-fig3)/10;

    System.Console.Write($"{fig2}");
}

else {System.Console.Write($"Число не трёхзначное, введите трехзначное число и попробуйте снова");}