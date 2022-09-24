/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Привет, Дмитрий Соломонов!");
Console.WriteLine("Введите значение числа");
string numberX =  Console.ReadLine();
Console.WriteLine(numberX);
char[] obrnunberX = numberX.ToCharArray();
Array.Reverse(obrnunberX);
string finalnuberX = new string(obrnunberX);
if (numberX == finalnuberX)
{
    Console.WriteLine("является палиндромом");
}
else
{
    Console.WriteLine("Не является палиндромом!!!");
}