// Задача 65:
// Задайте M и N. Выведите все натур.числа от M до N.
// M = 1; N = 5 -> "1,2,3,4,5"

string ShowNumbers(int m, int n)
{
    if (n == m) return $"{m}"; // Integer.toString(m) вариант
    return ShowNumbers(m, n - 1) + ", " + n;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число M: ");
int n = GetInput("Введите число N: ");
Console.WriteLine($"M = {m}; N = {n} -> {ShowNumbers(m, n)}");