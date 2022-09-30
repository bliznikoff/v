/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/ 
Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Введите значение числа A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число A равное {numberA}");
int sumCharNumber = 0;

while (numberA > 0)
{
    int C = 0;   
     C = numberA % 10;
     sumCharNumber += C;
    numberA = numberA /10;
}  
Console.WriteLine($"Сумма чисел равна {sumCharNumber}");
























































    