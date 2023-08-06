// Задача 53:
// Задайте двухмерный массив. Напишите программу, которая поменяет местами первую и последнюю
// строку массива.

// void ReplaceRows(int[,] array, int m, int n)
// {
//     int[,] workingArray = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i == 0 || i == (m - 1))
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {

//                 workingArray[i, j] = array[i, j];
//                 array[i, j] = array[m - 1, j];
//                 array[m - 1, j] = workingArray[i, j];
//                 Console.Write($"{array[i, j]}\t", -3);
//             }
//             Console.WriteLine();
//         }
//         else
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}\t", -3);
//             }
//             Console.WriteLine();
//         }
//     }
// }

void ReplaceRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
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
ReplaceRows(array);
PrintTwoDimensionalArray(array);