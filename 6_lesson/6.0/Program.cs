//программа переворачивает одномерный массив (последний
// элемент будет на первом месте, а первый - на последнем и т.д.)

void FillArray(double[] array)
{
    Console.Write($"Введите значение min элемента массива: ");
    double min = double.Parse(Console.ReadLine());
    Console.Write($"Введите значение max элемента массива: ");
    double max = double.Parse(Console.ReadLine());

    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (min - max) + max;
    }
}

void PrintArray(double[] array)
{
    int length = array.Length;
    Console.Write("Случайный Массив N: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}, ");
    }
}

Console.Write("введите количество элементов массива N: ");
int N = int.Parse(Console.ReadLine());

double[] array = new double[N];

FillArray(array);
PrintArray(array);
Console.WriteLine();

void Exchange(double[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);
    }
}

Exchange(array);
PrintArray(array);
