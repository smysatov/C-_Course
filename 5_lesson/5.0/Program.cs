//Задайте массив из 12 элементов, заполненный случайными
//числами из промежутка [-9,9]. Найдите сумму отрицательных
//и положительных элементов массива.

void FillArray(int[] array)
{
    Console.Write($"Введите значение min элемента массива: ");
    int min = int.Parse(Console.ReadLine());
    Console.Write($"Введите значение max элемента массива: ");
    int max = int.Parse(Console.ReadLine());
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    Console.Write("Случайный Массив N: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

Console.Write("введите количество элементов массива N: ");
int N = int.Parse(Console.ReadLine());

int[] array = new int[N];
FillArray(array);
PrintArray(array);

Console.WriteLine();

void SumPosNeg(int[] array)
{
    int pos,
        neg;
    pos = neg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
            pos += array[i];
        else
        {
            neg += array[i];
        }
    }
    Console.WriteLine($"Сумма положительных элементов: {pos}");
    Console.WriteLine($"Сумма отрицательных элементов: {neg}");
}

SumPosNeg(array);
