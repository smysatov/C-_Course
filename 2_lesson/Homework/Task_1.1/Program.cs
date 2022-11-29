//Принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Enter three digit number, ");
string NumSec(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"Second digit {num / 10 % 10}";
    return "The number is not three-digit";
}

Console.WriteLine(NumSec(int.Parse(Console.ReadLine())));
