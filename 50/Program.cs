﻿//Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает информацию о наличии этого элемента в массиве.
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns,0,10);
PrintArray(array);
Write("Введите значение элемента: ");
int element=int.Parse(ReadLine());
if(FindElement(array,element))
{
    WriteLine("Элемент найден");
}
else
{
    WriteLine("Элемент не найден");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]==el) return true;
        }
    }
    return false;
}


// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// // Заполнение массива рандомными числами от 1 до 9
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// //  Функция вывода массива в терминал
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Функция ввода 
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }