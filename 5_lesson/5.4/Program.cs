//Произведение чисел в одномерном массиве. Парой считаем
//первый и последний элемент, второй и предпоследний и т.д.

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

int[] Proizv(int[] array)
{
    int arraylength = array.Length;
    int multiplylength = arraylength / 2 + arraylength % 2;
    int[] multiply = new int[multiplylength];
    for (int i = 0; i < arraylength / 2; i++)
        multiply[i] = array[i] * array[arraylength - i - 1];
    if (multiply[multiplylength - 1] == 0)
        multiply[multiplylength - 1] = array[multiplylength - 1];
    return multiply;
}

int[] multiply = Proizv(array);
Console.WriteLine("Результат после перемножения элементов");
PrintArray(multiply);
