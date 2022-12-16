﻿//Задайте двумерный массив. Введите элемент, и найдите
//первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.

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

string FindNumber(int[,] arr, int findNum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == findNum)
                return $"Позиция первого вхождения числа: [{i + 1} , {j + 1}]";
    return "Число не найдено";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

PrintArray(arr_1);

Console.WriteLine(FindNumber(arr_1, int.Parse(Console.ReadLine())));
