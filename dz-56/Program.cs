/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
 с наименьшей суммой элементов.
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
void Print2DArray(int[,] arrayToPrint)
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

int[] RowSum(int[,] inArray )
{
 int[] restArray = new int[inArray.GetLength(0)];  
  for (int j = 0; j < inArray.GetLength(0); j++)
 {
    for (int i = 0; i < inArray.GetLength(1); i++)

    {
       restArray[j] += inArray[j,i]; 
    }

 }
 return restArray;
}

void RowSumMin(int[] Array)
{
    int rowSumMinArray = Array[0];
    int rowIndex = 0;
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] < rowSumMinArray)
        rowSumMinArray = Array[i];
        rowIndex = i;

    }   
Console.WriteLine($" строка с индексом {rowIndex} , имеет наименьшую сумму {rowSumMinArray} ");
        
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа находит строку в [,] с наименьшей суммой элементов.");
int m = 7;
int n = 8;
int[,] generatedArray = generate2DArray(m,n,0,9);
Print2DArray(generatedArray);
int[] rowSumArray = RowSum(generatedArray);
Console.WriteLine();
RowSumMin(rowSumArray);