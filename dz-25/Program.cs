/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int numberStep(int numberA ,int numberB)
{
    int i = 1;
    int result = 1;
    for (i =1; i <= numberB; i++)
    {
        result *= numberA;
    }
      return result;   
}


Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
Console.WriteLine("Введите значение числа A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число A равное {numberA}");
Console.WriteLine("Введите значение числа B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число B равное {numberB}");

int result = numberStep(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно  {result}");