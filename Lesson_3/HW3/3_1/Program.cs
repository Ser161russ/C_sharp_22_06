//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
 
 

 void Pali(int num)
 {
      int num1 =num / 1000;
      int num2 =num % 10;
      int num3 =num / 10 % 10;

   if (num1 == num2 * 10 + num3)
   Console.WriteLine($"Да,{num}");

   else 
   Console.WriteLine($"Нет,{num}");
}
 
Console.WriteLine("Введите 5 цифр");
int val = int.Parse(Console.ReadLine()!);
Pali(val);