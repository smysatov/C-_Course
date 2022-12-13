//Принимает на вход три числа и проверяет, может ли
//существовать треугольник со сторонами такой длины
//теорема о неравенстве: каждая сторона треугольника меньше
//суммы двух других сторон

void Triangle(int a, int b, int c)
{
    if (a < b + c & b < a + c & c < a + b)
    {
        Console.WriteLine("Треугольник существует");
    }
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}

Console.WriteLine("введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Triangle(a, b, c);
