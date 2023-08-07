// Задача 67:
// Принимаем на вход число, возвращаем сумму его цифр
// 453 -> 12

int ShowSumOfDigits(int n)
{
    if (n < 10) return n;
    return n % 10 + ShowSumOfDigits(n / 10);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите число N: ");
int sum = ShowSumOfDigits(n);
Console.WriteLine($"{n} -> {sum}");