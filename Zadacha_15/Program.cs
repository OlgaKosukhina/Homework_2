/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Insert number");
string number = Console.ReadLine();
int numberN = int.Parse(number);

switch (numberN)
{
    case 1:
        Console.WriteLine("Weekday");
        break;
    case 2:
        Console.WriteLine("Weekday");
        break;
    case 3:
        Console.WriteLine("Weekday");
        break;
    case 4:
        Console.WriteLine("Weekday");
        break;
    case 5:
        Console.WriteLine("Weekday");
        break;
    case 6:
        Console.WriteLine("Weekend");
        break;
    case 7:
        Console.WriteLine("Weekend");
        break;
}