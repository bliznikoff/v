/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 k1 * x + b1 = k2 * x + b2
*/ 

int[] enterRatio(int numberR)
    { 
         int[] resultArray = new int[numberR];
        int numberi = 0;
        for (int i = 0; i < numberR; i++)
        {  
             if (i == 0)
             {
                Console.WriteLine($"Введите коэффициент k1");
                numberi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вы ввели {numberi}");
                resultArray[i] = numberi;  
             }
            if (i == 1)
             {
                Console.WriteLine($"Введите коэффициент b1");
                numberi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вы ввели {numberi}");
                resultArray[i] = numberi;  
             }
                if (i == 2)
             {
                
                Console.WriteLine($"Введите коэффициент k2");
                numberi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вы ввели {numberi}");
                resultArray[i] = numberi;  
             }
             if (i == 3)
             {
                
                Console.WriteLine($"Введите коэффициент b2");
                numberi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вы ввели {numberi}");
                resultArray[i] = numberi;  
             }
        }
        return resultArray;
}        
double[] xyAraay(int[] inArray)
{
    double[] resultArray = new double[2];
    resultArray[0] = (double)(inArray[3] - inArray[1]) / (inArray[0] - inArray[2]);
    resultArray[1] =  inArray[0] * resultArray[0] + inArray[1];
    return resultArray;
}
void printArray(double[] Array)

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
Console.Clear();
Console.WriteLine("Приветствую! Эта программа найдёт точку пересеченя двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
int numberR = 4;
int[] ratioArray = enterRatio(numberR);
double[] restArray = xyAraay(ratioArray);
printArray(restArray);
