// наптшите программу которая на входе принимает одно число N а на выходе
// показывает все целые числа в промежутке от -n до n 

int a = int.Parse(Console.ReadLine()!);
int count = -a;
Console.WriteLine(count);
while (count!=a){
    if (a>0)
    count++;//cout=count+1
    else 
    count--;//count=count-1
    Console.WriteLine(count);    
} 
