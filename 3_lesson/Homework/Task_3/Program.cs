//Принимает на вход число N и выдает таблицу кубов
//чисел от 1 до N.

void Cube(int Num)
{
    int i = 1;
    double Kub;
    while (i <= Num)
    {
        if (i < Num)
        {
            Kub = Math.Pow(i, 3);
            Console.Write($"{Kub}, ");
            i += 1;
        }
        else
        {
            Kub = Math.Pow(i, 3);
            Console.Write($"{Kub}");
            i += 1;
        }
    }
}

Console.WriteLine("Enter a Number");
int Num = int.Parse(Console.ReadLine());
Cube(Num);
