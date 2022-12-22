//Задайте значения M и N. Напишите программу, которая выведет
//все четные натуральные числа в промежутке от M до N с
//помощью рекурсии.

void Numbers(int M, int N)
{
    if (M > N)
        return;
    if (M % 2 == 0)
        Console.Write($"{M}");
    else
    {
        Console.Write($" ");
    }
    Numbers(M + 1, N);
}

Console.Write("Введите число: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Numbers(M, N);
