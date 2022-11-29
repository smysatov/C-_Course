// Принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "NO";
    if (num == 7 || num == 6)
        text = "YES";
    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()));
