// Принимает на вход число и выдает количество цифр в числе.

int Sum(int num)
{
    if (num == 0)
        return (1);

    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}

Console.Write("Введите число -> ");
Console.WriteLine($"Количество цифр в числе -> {Sum(int.Parse(Console.ReadLine()))}");
