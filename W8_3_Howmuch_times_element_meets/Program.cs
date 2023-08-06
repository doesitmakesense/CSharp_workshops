// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь 
// содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

void FrequencyDictionary(int[,] array, int a = 1, int b = 9)
{
    int count = 0;
    while (a <= b)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (array[i, j] == a) count++;
            }
        }
        if (count > 0) Console.WriteLine($"{a} встречается {count} раз");
        a++;
        count = 0;
    }
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t", -3);
        }
        Console.WriteLine();
    }
}

int[,] GenerateTwoDimensionalArray(int rows, int columns, int startValue, int finishValue)
{
    int[,] workingArray = new int[rows, columns];
    for (int i = 0; i < workingArray.GetLength(0); i++)
    {
        for (int j = 0; j < workingArray.GetLength(1); j++)
        {
            workingArray[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return workingArray;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] array = GenerateTwoDimensionalArray(m, n, 1, 9); //будем от 1 до 9
PrintTwoDimensionalArray(array);
Console.WriteLine();
FrequencyDictionary(array, 1, 9);