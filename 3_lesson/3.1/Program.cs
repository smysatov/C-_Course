// По заданному номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

Console.WriteLine("Write a quarter number: ");
int N = int.Parse(Console.ReadLine());

void Range(int N)
{
    if (N == 1)
        Console.WriteLine("x>0 & y>0");
    else if (N == 2)
        Console.WriteLine("x<0 & y>0");
    else if (N == 3)
        Console.WriteLine("x<0 & y<0");
    else if (N == 4)
        Console.WriteLine("x>0 & y<0");
    else
        Console.Write(" -> wrong quarter!!!");
}

Range(N);
