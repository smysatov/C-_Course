//Принимает на вход число (N) и выдает таблицу
//квадратов чисел от 1 до N
void Chet(int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i += 1;
        if (i == (N))
        {
            pere = Math.Pow(i, 2);
            Console.Write($"{pere}");
        }
        else
        {
            pere = Math.Pow(i, 2);
            Console.Write($"{pere},");
        }
    }
}
Console.WriteLine("Enter a number");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);
