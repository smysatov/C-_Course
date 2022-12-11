//Программа, которая найдет точку пересечения двух прямых,
//заданных уравнениями y = k1 * x +b1, y = k2*x + b2; значения
//b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());

void Tochka(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения, ({x}, {y})");
}

Tochka(b1, k1, b2, k2);
