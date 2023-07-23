// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void ShowOutput(int x)
{
    for (int i = 0; i < x; i++)
    {
        Console.Write(i * i + ", ");
    }
    Console.Write(x * x);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = Math.Abs(GetInput("Введите число N: "));

ShowOutput(x);