﻿//Задайте двумерный массив. Наудите сумму элементов
//главной диагонали.

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

void Summa(int[,] arr)
{
    int sum = 0;
    int rows = arr.GetLength(0);

    for (int i = 0; i < rows; i++)
    {
        sum += arr[i, i];
    }
    Console.Write($"Сумма элементов главной диагонали: {sum}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

PrintArray(arr_1);
Summa(arr_1);
