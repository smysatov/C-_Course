//Принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

Console.WriteLine("Enter five digit number");
int Num = int.Parse(Console.ReadLine());

void Pal(int Num1, int Num2, int Num3, int Num4, int Num5)
{
    if (Num1 == Num5 && Num2 == Num4)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

if (Num > 9999 && Num < 100000 || Num > -100000 && Num < -9999)
{
    int Num1 = Num / 10000;
    int Num2 = Num / 1000 % 10;
    int Num3 = Num / 100 % 10;
    int Num4 = Num / 10 % 10;
    int Num5 = Num % 10;
    Pal(Num1, Num2, Num3, Num4, Num5);
}
else
{
    Console.Write("Wrong number");
}
