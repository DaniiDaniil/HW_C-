//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

int count=3;  

int[] digits;

if(numb>99){

while (numb>0)

{
    digits = new int[count];

    digits[count]=numb%10;

    numb = numb/10;
    
    count++;
}
   
}

else {Console.Write($"Число двузначное, третьей цифры нет.");}

Console.Write(digits[2]);