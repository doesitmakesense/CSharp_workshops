// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] FindTheLeastElementAndDeleteRowAndColumn(int[,] array)
{
    int[,] workingArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int temp = array[0, 0];
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (temp > array[i, j])
            {
                temp = array[i, j];
                index1 = i;
                index2 = j;
            }

        }
    }

    int r = 0, c = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != index1)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != index2)
                {
                    workingArray[r, c] = array[i, j];
                    c++;
                }
            }
            c = 0;
            r++;
        }
    }
    return workingArray;
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
int[,] newArray = FindTheLeastElementAndDeleteRowAndColumn(array);
PrintTwoDimensionalArray(newArray);