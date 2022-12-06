// Принимает на вход число N и выдает
// произведение чисел от 1 до N.

int Mult(int num)
{
    int proiz = 1;
    for (int i = 1; i <= num; i++)
    {
        proiz = proiz * i;
    }
    return proiz;
}

Console.WriteLine(Mult(int.Parse(Console.ReadLine())));
