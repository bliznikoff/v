/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/ 

int count(int[] inArray)
{
    int Result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
          Result++;  
        }
    }
    return Result;
}

int[] enterNunbers(int numberM)
{
    int[] resultArray = new int[numberM];
     int numberi = 0;
        for (int i = 0; i < numberM; i++)
        {  
             int n = i + 1;    
            Console.WriteLine($"enter {n}");
            numberi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели {numberi}");
            resultArray[i] = numberi;
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

 Console.Clear();
 Console.WriteLine("Приветствую! Эта программа принимает на вход от пользователя вводит с клавиатуры M чисел.");
 Console.WriteLine("Введите m количество чисел которое желаете ввести");
 int numberM = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine($"Вы ввели количество чисел равное {numberM}");

int[] restArray = enterNunbers(numberM);
printArray(restArray);
int sumPositiv = count(restArray);
Console.WriteLine($"Количество положительных чисел равно {sumPositiv}");
