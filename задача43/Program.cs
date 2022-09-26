// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("введите k1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("введите b1:");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("введите k2:");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("введите b2:");
double b2 = double.Parse(Console.ReadLine()!);

SolveEquations(k1, b1, k2, b2);

void SolveEquations(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"точка пересечения: x = {x:F2}, y = {y:F2}");
    }
}
