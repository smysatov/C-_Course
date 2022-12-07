//В заданном массиве найти сумму элементов,
//стоящих на нечетных позициях.

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

void OddSumPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
        sum = sum + array[i];
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
}

OddSumPos(array);
