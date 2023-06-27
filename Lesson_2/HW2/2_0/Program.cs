/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("введи пожалуйста трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 100 || Num > 1000) Console.WriteLine("Трехзначное пожалуйста");
else Console.WriteLine((Num - (Num % 10) - (Num / 100) *100) / 10);

