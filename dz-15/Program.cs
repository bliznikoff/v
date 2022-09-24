/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Привет, Дмитрий Соломонов!");
Console.WriteLine("Введите значение числа дня недели");
int numberWeek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberWeek);
if (numberWeek == 1)
{
Console.WriteLine("Понедельник не является выходным днем");
}
if (numberWeek == 2)
{
Console.WriteLine("Вторник не является выходным днем");
}
if (numberWeek == 3)
{
Console.WriteLine("Среда не является выходным днем");
}
if (numberWeek == 4)
{
Console.WriteLine("Четверг не является выходным днем");
}
if (numberWeek == 5)
{
Console.WriteLine("Пятница не является выходным днем");
}
if (numberWeek == 6)
{
Console.WriteLine("Суббота - выходной день");
}
if (numberWeek == 7)
{
Console.WriteLine("Воскресенье - выходной день");
}
else
{
    Console.WriteLine($"{numberWeek} Не является номером дня недели попробуйте еще раз");
}