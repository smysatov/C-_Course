//задает массив из N элементов случайными числами и выводит
//их на экран. Оформите заполнение массива и вывод в виде
//функции(для следующих задач).

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99, 99);
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
