// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Replace(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
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

int[] array = GenerateArray(12, -9, 10);
Console.WriteLine($" ♥ [{String.Join(",", array)}] ♥ ");
Replace(array);
Console.WriteLine($" ♥ [{String.Join(",", array)}] ♥ ");