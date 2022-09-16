/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


    Console.WriteLine(" Hello, Geek!");
    Console.WriteLine("Введите значение числа");
    int userNumer = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(userNumer);
    int i = 0;
    for (int i = 0; i <= userNumer; i + 2)        
        {
            Console.Write(i + " ");
        }