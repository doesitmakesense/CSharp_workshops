// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт 
// сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ShowOutput(int x)
{
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        sum += i;
    }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите число N: ");

Console.WriteLine($"Сумма чисел от 1 до числа {x} равна {ShowOutput(x)}");