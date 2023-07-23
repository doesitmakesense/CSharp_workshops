// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FindNumber(int[] array, int number)
{
    string text = "---";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            text = "++++";
            break;
        }
    }
    Console.WriteLine(text);
}

int[] array = { 1, 2, 3, 4, 5, 6, 7};
Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
FindNumber(array, number);