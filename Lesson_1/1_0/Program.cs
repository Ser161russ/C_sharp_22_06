// напишите программу, которая принимает число и выдает уго квадрат (число умноженое на само себя)

Console.WriteLine("Write a number: ");
string num_str = Console.ReadLine()!;

int num = int.Parse(num_str);

Console.WriteLine(num * num);