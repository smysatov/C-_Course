// Принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Day of the week number");
int num = int.Parse(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Entered wrong number");
}

if (num > 7)
{
    Console.WriteLine("Entered wrong number");
}

if (num > 0 && num < 6)
{
    Console.WriteLine("Weekday");
}

if (num > 5 && num < 8)
{
    Console.WriteLine("Weekend");
}