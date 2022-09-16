/* 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine(" Hello, Geek!");
Console.WriteLine("Введите значение a");
int userNumerA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumerA);
Console.WriteLine("Введите значение b");
int userNumerB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumerB);
if (userNumerA > userNumerB)
{
   Console.WriteLine("max");
    Console.WriteLine(userNumerA);
}
else
{
    Console.WriteLine("max");
    Console.WriteLine(userNumerB);
}