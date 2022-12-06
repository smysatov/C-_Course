//Принимает на вход число и выдает сумму цифр в числе.

int Sum(int num)
{
    if (num == 0)
        return (num);

    int i = 0;
    int sum = num % 10;

    while (num > 0)
    {
        num = num / 10;
        sum = sum + num % 10;
        i++;
    }
    return sum;
}

Console.Write("Введите число -> ");
Console.WriteLine($"Сумма цифр в числе -> {Sum(int.Parse(Console.ReadLine()))}");
