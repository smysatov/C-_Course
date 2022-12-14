//Задайте двумерный массив. Найдите элементы, у которых
//обе позиции четные, и замените эти элементы на их квадраты.

int[,] FillArray(int rows, int columns, int from, int to)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j], 4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayCloneSquare(int[,] arr)
{
    int columns = arr.GetLength(1);
    int rows = arr.GetLength(0);

    for (int i = 1; i < rows; i += 2)
    {
        for (int j = 1; j < columns; j += 2)
            arr[i, j] *= arr[i, j];
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

PrintArray(arr_1);
ArrayCloneSquare(arr_1);
PrintArray(arr_1);
