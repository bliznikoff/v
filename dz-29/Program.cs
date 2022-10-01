/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
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

Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход число длину массива и выдаёт массив рандомно");
Console.WriteLine("Введите значение длины массива A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели значение длины массива равное {numberA}");

int[] restArray = getRandomArray(numberA, 0, 88);
printArray(restArray);
