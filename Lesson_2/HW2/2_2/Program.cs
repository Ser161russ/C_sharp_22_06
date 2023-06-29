/*Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

string a = Console.ReadLine()!;
switch (a)

{
    case "1":
    Console.Write("нет,это понедельник");
     break; 
    case "2":
    Console.Write("нет,ты попал на вториник");
     break; 
    case "3":
    Console.Write("Среда,маленькая пятница и тоже нет");
     break; 
    case "4":
    Console.Write("Скоро выходные но все еще нет");
     break; 
    case "5":
    Console.Write("можно выпить но очень близко");
     break; 
    case "6":
    Console.Write("Суббота,УРАААА");
     break; 
    case "7":
    Console.Write("Воскресение выходной но завтра на работу");
     break; 
    default:
    Console.Write("Такого дня недели нет");
    break;
    }