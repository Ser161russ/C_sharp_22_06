﻿ // напишите программу которачя принимает на вход число а и выдает сумму чисел от 1 до а

 int SumNum( int num)
 {
    int all_sum = 0;
    for (int i = 0; i <= num; i++)
    all_sum +=i;
    return all_sum;
 }


 int A = int.Parse(Console.ReadLine());
 int result = SumNum( A );
 Console.WriteLine(result);