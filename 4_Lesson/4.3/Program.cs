//Выводит массив из 8 элементов, заполненный нулями
//и единицами в случайном порядке

void FillArray(int n)
{
    Console.Write("Вот что получилось: ");
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]}, ");
    }
}

Console.Write("введите количество элементов массива N -> ");
FillArray(int.Parse(Console.ReadLine()));
