// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.

// когда работаем с массивами, должен быть неповторимый оригинал, и копия, с которой я 
// провожу всякие действия, типа переворот или заполнение и тд

int GetSumMinusOrPlus(int[] array, bool positive)
{
    int sum = 0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (positive)
            {
                if (array[i] > 0)
                    sum = sum + array[i];
            }
            else
            if (array[i] < 0)
                sum = sum + array[i];
        }
    }
    return sum;

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
Console.Write($"В массиве [{String.Join(",", array)}]");
Console.WriteLine($" сумма положительных чисел равна {GetSumMinusOrPlus(array, true)}, сумма отрицательных равна {GetSumMinusOrPlus(array, false)}.");