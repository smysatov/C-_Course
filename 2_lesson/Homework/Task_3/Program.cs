//Выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет

Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("The third digit does not exist");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }

    num = num % 10;

    Console.WriteLine($"Third digit is {num}");
}
