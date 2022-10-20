/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.
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

int[,] ArraySort(int[,] Array)
{
int[,] ArrayM = Array;
    int temp = 0;
    
    for (int j = 0; j < ArrayM.GetLength(1)-1; j++)
    for (int i = j + 1; i < ArrayM.GetLength(1); i++)
    for (int k = 0; k < ArrayM.GetLength(0); k++)
    
        
        if (ArrayM[k,j] < ArrayM[k,i])
        {
        temp = ArrayM[k,j];
        ArrayM[k,j] = ArrayM[k,i];
        ArrayM[k,i] = temp;
        }
        return ArrayM;
    }





Console.Clear();
Console.WriteLine("Приветствую! Эта программа упорядочит по убыванию элементы каждой строки двумерного массива.");
int m = 4;
int n = 5;
int[,] generatedArray = generate2DArray(m,n,0,9);
Print2DArray(generatedArray);
int[,] ArrayMin = ArraySort(generatedArray);
Print2DArray(ArrayMin);

    

 
 