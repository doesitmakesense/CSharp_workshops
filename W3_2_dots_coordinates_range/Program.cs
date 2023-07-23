// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

void ShowQuarter(int x)
{
    if (x == 1) Console.WriteLine("В первой четверти - x > 0, y > 0");
    else if (x == 2) Console.WriteLine("Во второй четверти - x < 0, y > 0");
    else if (x == 3) Console.WriteLine("В третьей четверти - x < 0, y < 0");
    else if (x == 4) Console.WriteLine("В четвертой четверти - x > 0, y < 0");
    else Console.WriteLine("Такой четверти нет");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите номер четверти в которой бы хотели узнать диапозон возможных координат: ");

ShowQuarter(x);