/*(Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> */
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if  (Num < 100) Console.WriteLine("Третьей цифры нет"); 
else { Console.WriteLine("Окей, сейчас");
while (Num > 999) 
{
    Num = Num / 10;
}
Console.WriteLine($"Третья цифра вашего числа - {Num % 10}"); }