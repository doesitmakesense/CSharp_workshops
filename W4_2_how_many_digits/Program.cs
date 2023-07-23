// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ShowOutput(int x)
{
    x = Math.Abs(x);
    int count = 0;
    while (x > 0)
    {
        x = x / 10; // x/=10;
        count = count + 1; // count++;
    }
    return count;
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите число N: ");
int result = ShowOutput(x); // лучше вынести это отдельно вот так, потому что потому
Console.WriteLine($"Кол-во цифр в числе {x} равно {result}");