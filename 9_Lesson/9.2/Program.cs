//Задайте значения M и N. Напишите программу, которая
//рекурсивно выведет все натуральные числа
//в промежутке от M до N.

void Numbers(int M, int N)
{
    if (M > N)
        return;
    Console.Write($" {M}");
    Numbers(M + 1, N);
}

Console.Write("Введите число: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Numbers(M, N);
