// На вход принимает координаты точки (X и Y), причем
//X или Y не равно 0 и выдает номер четверти плоскости,
//в которой находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x=0 or y=0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
}

Quarters(2, -6);
