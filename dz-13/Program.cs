 /*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int numberDigit(int numberX)
  {
        int  n10 = (int)Math.Log10(numberX) + 1;
    return  n10;
  }

 Console.WriteLine("Привет, Дмитрий Соломонов!");
Console.WriteLine("Введите значение числа");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberX);

int n10 = numberDigit(numberX);
if  (n10 >= 3)
{
    int numberR = (numberX / (int)Math.Pow(10, (n10-3)) % 10);
    Console.WriteLine(numberR);
}
else
{
Console.WriteLine("третьей цифры нет");
}