//Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки
//двумерного массива.

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

void ChangeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int max = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = max;
                }
            }
        }
    }
}

ChangeArray(arr_1);
PrintArray(arr_1);
