// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void ToBinary(int number)
{
    Console.Write(number + " -> ");
    string count = String.Empty;
    while (number > 0)
    {
        if (number % 2 == 0) count = "0" + count;
        else count = "1" + count;
        number = number / 2;
    }
    Console.Write(count);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
ToBinary(number);
