//Задайте двумерный массив размером m*n, заполненный
//случайными вещественными числами.

double[,] FillArray(int rows, int columns, int min, int max)
{
    double[,] arr = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().NextDouble() * (min - max) + max;
    ;

    return arr;
}

void PrintArray(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{Math.Round(arr[i, j], 1)} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

double[,] arr_1 = FillArray(row, column, min, max);
PrintArray(arr_1);
