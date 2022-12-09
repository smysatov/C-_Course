//Программа определяет, присутствует ли заданное число
//в массиве

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

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

string TrackingNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
            return "Заданное число пристутствует в массиве";
    }
    return "Заданное число отсутствует в массиве";
}

Console.WriteLine(TrackingNumber(array, num));
