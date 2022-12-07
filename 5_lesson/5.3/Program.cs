//Задан одномерный массив из 123 случайных чисел. Найти
//количество элементов массиваб значения которых лежат в
//отрезке [10,99].

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

void Find(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            sum = sum + 1;
    }
    Console.Write($"Количество эл. массива на отрезке [10,99]: {sum}");
}

Find(array);
