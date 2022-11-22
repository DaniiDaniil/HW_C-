//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Write("Введите число   ");

int numb=Convert.ToInt32(Console.ReadLine());

int N = numb;

int count=0;

while (N>0){

N=N/10;

count++;}

int[] digits;

digits = new int[count];

if(count>2){

for (int i = 0; i < count;i++)
{   digits[i]=numb%10;
    
    numb = numb/10;

} 

int dig3 = count-3;

Console.Write(digits[dig3]);
   
}

else {Console.Write($"Число двузначное, третья цифра отсутствует.");}