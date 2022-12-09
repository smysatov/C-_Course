//Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элементом массива

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

void MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
        if (max < array[i])
        {
            max = array[i];
        }
    for (int j = 0; j < array.Length; j++)

        if (min > array[j])
        {
            min = array[j];
        }
    Console.WriteLine($"Разница между max и min элементами массива: {Math.Round(max - min, 2)}");
}

MaxMin(array);
