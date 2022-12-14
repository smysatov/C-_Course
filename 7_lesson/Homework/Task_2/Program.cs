//На вход принимает позиции элемента в двумерном массиве
//, и возвращает значение этого элемента или же указание,
//что такого элемента нет.

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(min, max);
    ;

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

string Position(int[,] arr, int posrows, int poscolumns)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (posrows <= arr.GetLength(0) && poscolumns <= arr.GetLength(1))
                return $"Значение элемента массива: {arr[posrows - 1, poscolumns - 1]}";
    return "В массиве нет элемента с такой позицией";
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, min, max);
PrintArray(arr_1);

Console.Write("Введите номер строки: ");
int posrows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int poscolumns = int.Parse(Console.ReadLine());

Console.WriteLine(Position(arr_1, posrows, poscolumns));
