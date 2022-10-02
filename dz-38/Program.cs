/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
        Console.Write(Array[i]);
        if (i < (Array.Length -1))
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] multiplayCharСoupleArray(int[] inArray)
{
     int[] resultArray = new int[(inArray.Length / 2)];
     for (int i = 0; i < (inArray.Length / 2); i++)
     {
        resultArray[i] = inArray[i] * inArray[inArray.Length -1 - i];
     }
         
    return resultArray;
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход число длину массива и выдаёт произведение пар чисел b массив рандомно");
Console.WriteLine("Введите значение длины массива A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели значение длины массива равное {numberA}");
int[] restArray = getRandomArray(numberA, 1, 9);
printArray(restArray);
int[] Multi = multiplayCharСoupleArray(restArray);
printArray(Multi);

