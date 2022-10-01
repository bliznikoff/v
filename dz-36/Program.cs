/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/ 

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

void printArray(int[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
        if (i < (Array.Length -1))
        {
            Console.WriteLine(",");
        }
    }
    Console.WriteLine("]");
}

int sumChar1indexArray(int[] inArray)
{
int result = 0;
for (int i = 0; i < inArray.Length; i = i+2)
    {
         result += inArray[i];
    }
   return result;
 }

Console.Clear();
Console.WriteLine("Приветствую! Эта программа создает рандомно массив и выдаёт сумму элементов на нечетных позициях.");
Console.WriteLine("Введите значение числа A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число A равное {numberA}");

int[] restArray = getRandomArray(numberA, -99, 99);
printArray(restArray);
int sumChar = 0;
sumChar = sumChar1indexArray(restArray);
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве равно {sumChar}");