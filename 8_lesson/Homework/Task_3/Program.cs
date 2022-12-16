//Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

Console.Write("Введите количество строк 1 матрицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 матрицы: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента 1 матрицы: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента 1 матрицы: ");
int max = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, min, max);
PrintArray(arr_1);

Console.Write("Введите количество строк 2 матрицы: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 матрицы: ");
int column1 = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента 2 матрицы: ");
int min1 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента 2 матрицы: ");
int max1 = int.Parse(Console.ReadLine());

int[,] arr_2 = FillArray(row1, column1, min1, max1);
PrintArray(arr_2);

int[,] arr_res = new int[row, column1];
Console.WriteLine($"Произведение первой и второй матриц:");
MultiplyArr(arr_1, arr_2, arr_res);
PrintArray(arr_res);

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

void MultiplyArr(int[,] arr_1, int[,] arr_2, int[,] arr_res)
{
    for (int i = 0; i < arr_1.GetLength(0); i++)
    {
        for (int j = 0; j < arr_2.GetLength(1); j++)
        {
            for (int k = 0; k < arr_2.GetLength(0); k++)
            {
                arr_res[i, j] += arr_1[i, k] * arr_2[k, j];
            }
        }
    }
}
