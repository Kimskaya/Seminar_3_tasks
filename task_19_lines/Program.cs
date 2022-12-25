// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет   12821 -> да   23432 -> да

int Get5DigitNumber (string message)
{
    Console.WriteLine(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}
int Number = Get5DigitNumber("Input 5 digit number");
int FirstHalf = Number/1000;
int SecondHalf = Number%100;
int First = FirstHalf/10;
int Second = FirstHalf%10;
int Fifth = SecondHalf%10;
int Forth = SecondHalf/10;

if (First == Fifth && Second == Forth)
{
    Console.WriteLine($" Number {Number} is a palindrome");
}
else 
{
    Console.WriteLine($" Number {Number} is not a palindrome");
}