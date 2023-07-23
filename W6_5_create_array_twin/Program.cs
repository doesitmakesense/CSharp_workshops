// Задача 45: Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

//создать копию массива посредством перебора элементов

int[] CreateArrayTwin(int[] array)
{
    int[] arrayTwin = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayTwin[i] = array[i];
    }
    return arrayTwin;
}

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int length = GetInput("Введите длину массива: ");
int min = GetInput("Введите минимальное значение массива: ");
int max = GetInput("Введите максимальное массива: ");
int[] array = GenerateArray(length, min, max);
Console.Write($"Массив [{String.Join(", ", array)}] продублирован: ");
int[] arrayTwin = CreateArrayTwin(array);
Console.WriteLine($"[{String.Join(", ", arrayTwin)}].");
