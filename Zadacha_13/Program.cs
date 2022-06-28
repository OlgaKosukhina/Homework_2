/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Insert number");
string number = Console.ReadLine();
int length = number.Length;

int i = 0;

for (i = 0; i < length; i++)
{
    if (i == 2)
    {
        Console.WriteLine($"Third digit is {number[i]}");
    }
}

if (length < 3)
{
    Console.WriteLine("There is no third digit");
}