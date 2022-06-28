/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
*/

Random rnd = new Random();
int number = rnd.Next(100, 1000);

Console.WriteLine($"Random number {number}");

int firstDigit = number / 100;
int secondDigit = (number / 10) % 10;
int thirdDigit = number % 10;

Console.WriteLine($"Second digit is {secondDigit}");