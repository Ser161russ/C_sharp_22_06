﻿// Напишите программу которая принимает на вход число n и выдает произведение чисел от 1 до n 
int SumNum(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
        all_sum = all_sum*i;

    return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);
