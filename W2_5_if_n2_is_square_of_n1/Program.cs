// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
// квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Написать в виде функции. Функции снизу вверх расставлябтся

Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine());

Square(x, y); //cpmputer, do Method

void Square(int x, int y) //created Method and explaining what is inside
{
    if (x * x == y)
    {
        Console.WriteLine("Yes");
    }
    else
        Console.WriteLine("No");
}


