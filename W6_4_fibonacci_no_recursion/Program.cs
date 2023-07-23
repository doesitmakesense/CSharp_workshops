// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// f(n) = f(n-1) + f(n-2)
// Фибоначчи - следующее число равно сумме двух предыдущих

void Fibonacci(int number)
{

    Console.Write("если N = " + number + " -> 0 1 ");
    int number1 = 0;
    int number2 = 1;
    for (int i = 2; i < number; i++)
    {
        int number3 = number1 + number2;
        number1 = number2;
        number2 = number3;
        Console.Write($"{number3} ");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число N: ");
Fibonacci(number);