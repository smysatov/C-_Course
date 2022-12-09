//Задает массив, заполненный случайными, положительными
//трехзначными числами. Показывает количество четных чисел
//в массиве.

void FillArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
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

void chet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            sum++;
    Console.WriteLine($"Количество четных чисел в массиве: {sum}");
}

chet(array);
