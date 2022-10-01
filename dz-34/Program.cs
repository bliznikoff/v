/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int numberChar2Array(int[] inArray)
{
int result = 0;
for (int i = 0; i < inArray.Length; i++)
    {
            if (inArray[i] % 2 == 0)
        {
            result += 1;
        }
   }
   return result;
 }

Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход число длину массива формирует массив показыват количество четных чисел");
Console.WriteLine("Введите значение длины массива A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели значение длины массива равное {numberA}");

int[] restArray = getRandomArray(numberA, 100, 999);
printArray(restArray);
int sumChar = 0;
sumChar = numberChar2Array(restArray);
Console.WriteLine($"Количество четных чисел в мвссиве равно {sumChar}");