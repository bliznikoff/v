/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
    Console.Write("]");
}

int[] columnSum(int[,] inArray )
{
 int[] restArray = new int[inArray.GetLength(1)];  
  for (int j = 0; j < inArray.GetLength(1); j++)
 {
    for (int i = 0; i < inArray.GetLength(0); i++)

    {
       restArray[j] += inArray[i,j]; 
    }

 }
 return restArray;
}

double[] arifmeticMean(int[] inArray)
{
  double[] restArray = new double[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        restArray[i] = (double)inArray[i] / inArray.Length;
    }
    return restArray;
} 

void printArrayDouble(double[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < (Array.Length -1))
        {
            Console.Write("; \t");
        }
    }
    Console.Write("]");
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа создает двумерный массив  и выдаёт среднее арифметическое элементов в каждом столбце");
int m = 3;
int n = 4;
int[,] generatedArray = generate2DArray(m,n,0,9);
print2DArray(generatedArray);
int[] sumColumnArray = columnSum(generatedArray);
Console.WriteLine();
printArray(sumColumnArray);
double[] MeanArifmetic = arifmeticMean(sumColumnArray);
Console.WriteLine();
printArrayDouble(MeanArifmetic);