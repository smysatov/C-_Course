//Принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Write a three digit number: ");
int num = int.Parse(Console.ReadLine());

if (99<num && num<1000)
{
    num = num / 10;
    num = num % 10;
    Console.WriteLine($"Second digit {num}");
}
else
{
    Console.WriteLine("Wrong Number");
}
