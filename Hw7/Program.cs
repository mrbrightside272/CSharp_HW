//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int InputNumber(string message)
// {
//     System.Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void FillArray2D(double[,] array2D)
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
//         }
//     }
// }

// void PrintArray2D(double[,] array2D)
// {
//      for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = InputNumber("Введите количество строк массива");
// int columns = InputNumber("Введите количество столбцов массива");

// double[,] arrayNew = new double[rows, columns];

// FillArray2D(arrayNew);
// PrintArray2D(arrayNew);
// System.Console.WriteLine();

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//  int InputNumber(string message)
// {
//     System.Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void FillArray2D(double[,] array2D)
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
//         }
//     }
// }

// void PrintArray2D(double[,] array2D)
// {
//      for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }
// int rows = InputNumber("Введите количество строк массива");
// int columns = InputNumber("Введите количество столбцов массива");

// double[,] arrayNew = new double[rows, columns];


// FillArray2D(arrayNew);
// PrintArray2D(arrayNew);
// System.Console.WriteLine();

// int numberInrow = InputNumber("Введите номер строки ");
// int numberIncolumns = InputNumber("Введите номер столбца: ");

// if (numberInrow - 1 > arrayNew.GetLength(0)
//  || numberIncolumns - 1 > arrayNew.GetLength(1))
//  {
//     System.Console.WriteLine("такого числа в массиве нет");
//  }
// else
// {
//     System.Console.WriteLine("Значение ячейки: " + arrayNew[numberInrow - 1, numberIncolumns - 1]);
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("Введите количество строк массива");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);

// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }


