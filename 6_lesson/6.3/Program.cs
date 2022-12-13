//Не использую рекурсию, выводит первые N чисел Фибоначи.
//Первые два числа Фибоначчи: 0 и 1.

void Fibonacci(int num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Fibonacci(num);
