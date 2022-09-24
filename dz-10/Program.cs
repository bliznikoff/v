/*
  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/



int numberDigit(int numberX)
  {
        int  n10 = (int)Math.Log10(numberX) + 1;
    return  n10;
  }

int digit2number(int numberX)
{
  int digit2 = numberX / 10 % 10;
  return digit2;
}

Console.WriteLine("Привет, Дмитрий Соломонов!");
Console.WriteLine("Введите значение числа");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberX);

int n10 = numberDigit(numberX);
if  (n10 == 3)
{
Console.WriteLine(n10);
}
else
{
  Console.WriteLine("Число не трёхзначное!!!");
}

int digit2 = digit2number(numberX);
Console.WriteLine($"Второй знак в числе [{numberX}] {digit2}");


