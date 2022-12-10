// Программа преобразовывает десятичное число в двоичное

string binary(int num)
{
    string sum = "";
    while (num > 0)
    {
        sum = num % 2 + sum;
        num = num / 2;
    }
    return sum;
}
Console.Write("Введите десятичное число, ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Двоичное число, {binary(num)}");
