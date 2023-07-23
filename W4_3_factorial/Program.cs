// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int getFactorial(int x)
// {
//     int product = 1;
//     for (int i = 1; i <= x; i++)
//     {
//         product *= i; // product = product * i;
//     }
//     return product;
// }

int GetFactorial(int x)
{
    if (x <= 1)
    {
        return 1;
    }
    else
    {
        return x * GetFactorial(x - 1);
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите число N: ");

Console.WriteLine($"Произведение чисел от 1 до {x} равно {GetFactorial(x)} ♥♥♥");