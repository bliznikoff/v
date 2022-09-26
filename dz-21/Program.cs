/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.
*/

Console.WriteLine("Привет, Дмитрий Соломонов!");
double userCoordinateX = 0;
double userCoordinateY = 0;
double userCoordinateZ = 0;
double userCoordinateX1 = 0;
double userCoordinateY1 = 0;
double userCoordinateZ1 = 0;
double distans = 0;
Console.WriteLine("Введите координаты: ");
Console.Write("X: ");
userCoordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
userCoordinateY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
userCoordinateZ = Convert.ToInt32(Console.ReadLine());
Console.Write("X1: ");
userCoordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
userCoordinateY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
userCoordinateZ1 = Convert.ToInt32(Console.ReadLine()); 

distans = Math.Pow((userCoordinateX1-userCoordinateX), 2)
 + Math.Pow((userCoordinateY1-userCoordinateY), 2) + Math.Pow((userCoordinateZ1-userCoordinateZ) , 2); 

Console.WriteLine(distans);