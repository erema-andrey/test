// Домашняя работа. Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки элемента: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер строки элемента: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
//             else Console.Write($"{matrix[i, j],4} ");
//         }
//         Console.WriteLine("]");
//     }
// }
// void FindElementmatrix(int[,] matrix)
// {
//     if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
//         Console.WriteLine($"Такой элемент есть, это ----> {matrix[row, column]}");
//     else
//         Console.WriteLine($"Строка: {row}, колонка {column} ----> в массиве отсутствует");
// }
// int[,] creatMatrixRndInt = CreateMatrixRndInt(5, 7, 1, 10);
// PrintMatrix(creatMatrixRndInt);
// FindElementmatrix(creatMatrixRndInt);

// // Домашняя работа. Задача 47. Задайте двумерный массив размером m×n, заполненный
// // случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9


// double[,] GreatMatrixRndDouble(int rows, int colums, double min, double max)
// {
//     double[,] matrix = new double[rows, colums];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix (double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6}, ");
//             else Console.Write($"{matrix[i, j], 6} ");
//         }
//         Console.WriteLine("]");
//     }
// }
// double[,] matrixArray = GreatMatrixRndDouble(5, 9, 1.5, 1.19);
// PrintMatrix(matrixArray);







// // Домашняя работы. Задача 52. Вывод через массив. Задайте двумерный массив из целых чисел
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

double[] ArithmeticMean(int[,] matrix)
{
    double[] ArithmeticMeanNewMassiv = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summaArithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summaArithmeticMean += matrix[i, j];
        }
        ArithmeticMeanNewMassiv[j] = Math.Round(summaArithmeticMean / matrix.GetLength(0), 2);
    }
    return ArithmeticMeanNewMassiv;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[,] creatMatrixRndInt = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(creatMatrixRndInt);
double[] array = ArithmeticMean(creatMatrixRndInt);
Console.Write("Среднее арифметическое элементов в столбцах: ");
PrintArray(array);