// Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N при помощи
//рекурсии.

void Numbers(int num)
{
    if (num == 0)
        return;
    Numbers(num - 1);
    Console.Write($" {num}");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Numbers(num);
