// Задача 69:
// Принимаем на вход два числа А и В, и возводим А в степень В с помощью рекурсии
// А = 3; B = 5->243
// A = 2; B = 3->8

int ShowSumOfDigits(int a, int b)
{
    if (b == 1) return a;
    return a * ShowSumOfDigits(a, b - 1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите число A: ");
int b = GetInput("Введите число B: ");
int power = ShowSumOfDigits(a, b);
Console.WriteLine($"A = {a}; B = {b} -> {power}");