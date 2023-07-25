// Задача 48: Задайте двумерный массив размера m на n, каждый элемент
//  в массиве находится по формуле: Aₘₙ = i+j. Выведите
//   полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

int[,] GenerateTwoDimensionalArrayExponential(int rows, int columns)
{
    int[,] workingArray = new int[rows, columns];
    for (int i = 0; i < workingArray.GetLength(0); i++)
    {
        for (int j = 0; j < workingArray.GetLength(1); j++)
        {
            workingArray[i, j] = i+j; // туточки заполняем по формуле задачи
        }
    }
    return workingArray;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Напишите 3: ");
int n = GetInput("Напишите 4: ");
int[,] array = GenerateTwoDimensionalArrayExponential(m, n); 
PrintTwoDimensionalArray(array);