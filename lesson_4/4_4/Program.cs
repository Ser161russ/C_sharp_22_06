﻿// напишите программу которая выводит массив из 8 элементов 
/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[8];


FillArray(array);
PrintArray(array);*/

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
       collection[i] = new Random().Next(0,2);
        i++;
    }  
}
void printArray(int[] col)
{
 int count = col.Length;
 int position = 0;
 while (position < count )
 {
    Console.Write(col[position]+">");
    position++;

 }
}
int[] array = new int[8];
FillArray(array);
printArray(array);