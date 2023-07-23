// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int x = new Random().Next(10, 100);
int firstDigit = x / 10;
int secondDigit = x % 10;

int max = firstDigit;

if(max < secondDigit)
{
    max = secondDigit;
}

Console.WriteLine($"Максимальная цифра в числе {x} -> {max}");