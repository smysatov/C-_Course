//Напишиет программу, которая будет принимать на вход
//число и возвращать сумму его цифр используя рекурсию.


int Summa(int num)
{
    if (num == 0)
        return 0;
    return Summa(num / 10) + num % 10;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.Write($"Сумма цифр: {Summa(num)}");
