//Программа создает копию заданного массива с помощью
//поэлементного копирования

int[,] FillArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(100, 1000);
    return arr;
}

void PrintArray(int[,] arr)
{
    int columns = arr.GetLength(1);
    int rows = arr.GetLength(0);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] ArrayClone(int[,] arr)
{
    int columns = arr.GetLength(1);
    int rows = arr.GetLength(0);
    int[,] new_arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            new_arr[i, j] = arr[i, j];
    }
    return new_arr;
}

int[,] arr = FillArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
PrintArray(arr);
int[,] arr_2 = ArrayClone(arr);
Console.WriteLine();
PrintArray(arr_2);
