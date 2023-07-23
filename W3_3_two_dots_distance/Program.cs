// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

void ShowQuarter(int ax, int ay, int bx, int by)
{
    double distance = Math.Sqrt(Math.Pow(ax-bx, 2)+Math.Pow(ay-by, 2));
    Console.WriteLine($"{Math.Round(distance, 3)}"); //округление
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координатy x точки А: ");
int ay = GetInput("Введите координатy y точки А: ");
int bx = GetInput("Введите координатy x точки B: ");
int by = GetInput("Введите координатy y точки B: ");


ShowQuarter(ax, ay, bx, by);

