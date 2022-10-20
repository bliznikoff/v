/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.
*/ 

void RangePrint(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.WriteLine($"{N}, ");
    RangePrint(N-1);
}


Console.Clear();
Console.WriteLine("Приветствую! Эта программа выведет все натуральные числа в промежутке от N до 1.");
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели  число равное {numberN}");
RangePrint(numberN);