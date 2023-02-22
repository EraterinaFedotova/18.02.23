//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами
// using System;
// using static System.Console;

// Clear();

// Write("Введите количество строк массива: ");
// int rows=int.Parse(ReadLine());

// Write("Введите количество столбцов массива: ");
// int columns=int.Parse(ReadLine());

// double[,] array = GetArray(rows, columns, 0, 5);

// PrintArray(array);

// double[,] GetArray(int m, int n, int min, int max)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(max-min);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i,j]:f1} ");
//         }
//         WriteLine();
//     }
// }



int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

// Заполнение массива рандомными вещественными числами
void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] twoDimArray = new double[m, n];
// Random rnd = new Random();
// void PrintArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { Console.Write($"{matr[i, j]} ");}
//  Console.WriteLine();}}

// void FillArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);