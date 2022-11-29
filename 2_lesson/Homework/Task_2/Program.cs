//Выводит случайное трехзначное число и удаляет
//вторую цифру этого числа

int Num(int num)
{
    Console.WriteLine($"Random three digit number {num}");
    Console.Write("Without second digit ");
    return (num / 100) * 10 + num % 10;
}
Console.WriteLine(Num(new Random().Next(100, 1000)));
