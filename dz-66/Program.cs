/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.
*/

int SumPrint(int N, int M)
{
    if (N == M)
    {
        return 0;
    }
    return N + (N-1);
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа выведет сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели  число равное {numberN}");
Console.WriteLine("Введите M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели  число равное {numberM}");
int summ = SumPrint(numberN, numberM);
Console.Write($"{summ}");