﻿/*напишите программу которая принемает на вход координаты двух точек и находит 
расстояние между ними в 3д пространстве 
А(3.6.8) В(2,1,-7)-> 15.84*/

double VectorLenght(int x1, int y1, int z1, int x2, int y2, int z2)
 {
    return Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

 }
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!); 

double result = VectorLenght(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками = " + result);