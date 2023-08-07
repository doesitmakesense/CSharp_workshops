// Задача 63:
// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа от 1 до N.
// N = 5 -> "1,2,3,4,5"

string ShowNumbers(int n)
{
    if (n == 1) return n.ToString();
    return ShowNumbers(n - 1) + ", " + n;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите число N: ");
Console.WriteLine($"N = {n} -> {ShowNumbers(n)}");