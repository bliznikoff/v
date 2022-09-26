/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Привет, Дмитрий Соломонов!");
Console.WriteLine("Введите значение числа");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

for (int i = 0; i < (number + 1); i++)
{
    i = (int)Math.Pow(i, 3);
    Console.Write(i);
}

