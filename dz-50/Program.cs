/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/ 

int[,] generate2DArray(int height,int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd+1 );
        }
    }
    return twoDArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void element(int[,]  generatedArray, int numberA, int n, int m)
{
    int numberR = 0;
    int i = 0;
    int j = 0;
    i = numberA / n;
        if (i < m)
            {
            j = numberA % n;
            numberR = generatedArray[i,j];
            Console.WriteLine(numberR); 
            }
        else
            {
            Console.WriteLine();
            Console.WriteLine("Нет такой позиции! в данном массиве.");
            }
  }


Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход позицию элемента в двумерном массиве  и выдаёт элемент");
Console.WriteLine("Введите позицию элемента в двумерном массиве");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели позицию элемента  {numberA}");

int m = 3;
int n = 4;
int[,] generatedArray = generate2DArray(m,n,0,9);
print2DArray(generatedArray);
element(generatedArray, numberA, m, n);