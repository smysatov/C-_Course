// Выводит случайное число на отрезке [10,99]
// и показывает наибольшую цифру числа

int Maxnumber(int num)
{
    Console.WriteLine(num);

    if (num % 10 > num / 10)
        return num % 10;
    else
        return num / 10;
}

Console.WriteLine(Maxnumber(new Random().Next(10, 100)));