/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine(" Hello, Geek!");
Console.WriteLine("Введите значение числа");
int userNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumer);
if (userNumer % 2==1)
{
    Console.WriteLine("число нечетное ");
}
else
{
    Console.WriteLine("число четное! ");
}