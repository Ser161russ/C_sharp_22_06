// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число произведений в степень");
int N = int.Parse(Console.ReadLine()!);
int I = 1;
double result = 1;

if (N == 0)
Console.WriteLine("значение равно 1");
else do
{

result = Math.Pow(I, 3);
Console.WriteLine("Значения = " + result);
I=I+1;

}
while (I <= N);