// выдает название дня недели по заданному номеру

Console.WriteLine("Enter number");

int y = int.Parse(Console.ReadLine());

if ( y == 1)
{
    Console.WriteLine("Monday");
}

else if (y == 2)
{
    Console.WriteLine("Tuesday");
}

else if (y == 3)
{
    Console.WriteLine("Wednesday");
}

else if (y == 4)
{
    Console.WriteLine("Thursday");
}

else if (y == 5)
{
    Console.WriteLine("Friday");
}

else if (y == 6)
{
    Console.WriteLine("Saturday");
}

else if (y == 7)
{
    Console.WriteLine("Sunday");
}

else
{
    Console.WriteLine("error");
}