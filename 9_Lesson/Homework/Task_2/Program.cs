//Задайте значения M и N. Напишите программу, которая найдет
//сумму натуральных элементов в промежутке от M до N
//помощью рекурсии.

int Summa(int M, int N)
{
    if (M == N)
        return M;
    return Summa(M + 1, N) + M;
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Сумма эл. в промежутке от M до N: {Summa(M, N)}");
