//Пользователь вводит с клавиатуры М чисел.
//Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.WriteLine("Сколько чисел вы хотите ввести?");
int M = int.Parse(Console.ReadLine());

int Positive(int M)
{
    int sum = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine($"Количество положительных чисел: {Positive(M)}");
