// Напишите программу, которая выводит случайное трехзначное число и удаляет 
// вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int firstDigit = x / 100;
int secondDIgit = x / 10 % 10;
Console.WriteLine(secondDIgit);
int thirdDigit = x % 10;

Console.WriteLine($"Число без второй цифры: {firstDigit}{thirdDigit}");