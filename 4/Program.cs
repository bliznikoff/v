/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine(" Hello, Geek!");
Console.WriteLine("Введите значение a");
int userNumerA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumerA);
Console.WriteLine("Введите значение b");
int userNumerB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumerB);
Console.WriteLine("Введите значение с");
int userNumerC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumerC);
int m = userNumerA;
if (userNumerB > m)
{
    int maxim = userNumerB;
}
if (userNumerC > m)
{
    int m = userNumerC;
}
Console.WriteLine(m);