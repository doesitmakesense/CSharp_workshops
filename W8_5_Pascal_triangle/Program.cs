// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

void WriteArray(int[,] array) //печать с выравниванием треугольника в красивый ровный
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j]} ");
            }
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}

void TransformationPascalTriangle(int[,] array) // трансформация в "левую" пол.треугольника
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0) //проверка, что текущий эл-т не ноль
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}

void FillPascalTriangle(int[,] pascalTriangle) // выглядит как правая половинка треугольника 
{
    for (int k = 0; k < pascalTriangle.GetLength(0); k++)
    {
        pascalTriangle[k, 0] = 1;
    }
    for (int i = 1; i < pascalTriangle.GetLength(0); i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
            // два числа сверху над нужным (сверху и правее, сверху и левее)
        }
    }
}


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int n = InputNumbers("Введите количество строк: ");
n = n - 1;

int[,] pascalTriangle = new int[n + 1, 2 * n + 1];

FillPascalTriangle(pascalTriangle);

TransformationPascalTriangle(pascalTriangle);

Console.WriteLine();
WriteArray(pascalTriangle);