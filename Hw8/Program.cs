// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           array[i, j] = rnd.Next(1, 1000);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// void SwapElements(int[,] array, int i, int j, int k)
// {
//     int temp = array [i, k];
//     array [i, k] = array [i, j];
//     array [i, j] = temp;
// }

// void BubleSortRowIn2DArray (int[,] array, int i)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i,j] < array[i, k])
//                 {
//                     SwapElements(array, i, j, k);
//                 }
//             }
//         }
// }

// void SortArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         BubleSortRowIn2DArray(array, i);
//     }
// }

// int rows = GetNumber("количество строк массива");
// int columns = GetNumber("количество столбцов массива");
// int[,] array = new int[rows, columns];
// FillArray(array);
// PrintArray(array);
// SortArray(array);
// System.Console.WriteLine("Измененный массив: ");
// PrintArray(array);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           array[i, j] = rnd.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// int SummRow(int[,] array, int i)
// {
//     int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
        
//             summ += array[i, j];
        
//         return summ;
// }

// int FindRowWithMinimalSummOfElements(int[,] array)
// {
//     int min = SummRow(array, 0);
//     int index = 0;
//     // int[] newArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int currentSumm = SummRow(array, i);
//         if (currentSumm < min)
//         {
//             min = currentSumm;
//             index = i;
//         }
//     }
//     return index + 1;
// }

// int rows = GetNumber("количество строк массива");
// int columns = GetNumber("количество столбцов массива");
// int[,] array = new int[rows, columns];
// FillArray(array);
// PrintArray(array);
// int rowWithMinimalSummOfElements = FindRowWithMinimalSummOfElements(array);
// System.Console.WriteLine("Номер строки с наименьшей суммой элементов: " + rowWithMinimalSummOfElements);

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int GetInNumber(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[,] CreateArray(int m, int n)
// {
//   int[,] array = new int[m, n];
//   return array;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] FillArrayRandom(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
//   return array;
// }

// int[,] MultiplyArray(int[,] firstArr, int[,] secondArr)
// {
//   int newRow, newCol;
//   if (firstArr.GetLength(0) > secondArr.GetLength(0))
//   {
//     newRow = secondArr.GetLength(0);
//   }
//   else
//   {
//     newRow = firstArr.GetLength(0);
//   }
//   if (firstArr.GetLength(1) > secondArr.GetLength(1))
//   {
//     newCol = secondArr.GetLength(1);
//   }
//   else
//   {
//     newCol = firstArr.GetLength(1);
//   }

//   int[,] newArray = new int[newRow, newCol];

//   for (int i = 0; i < newRow; i++)
//   {
//     for (int j = 0; j < newCol; j++)
//     {
//       for (int e = 0; e < newRow; e++)
//       {
//         newArray[i, j] += firstArr[i, e] * secondArr[e, j];
//       }
//     }
//   }
//   return newArray;
// }

// int[,] firstArr = CreateArray(GetInNumber("Введите количество строк массива 1: "), GetInNumber("Введите количество столбцов массива 1: "));
// int[,] secondArr = CreateArray(GetInNumber("Введите количество строк массива 2: "), GetInNumber("Введите количество столбцов массива 2: "));
// Console.WriteLine("Первый массив:");
// FillArrayRandom(firstArr);
// PrintArray(firstArr);
// Console.WriteLine("Второй массив:");
// FillArrayRandom(secondArr);
// PrintArray(secondArr);
// Console.WriteLine("Произведение двух матриц:");
// int[,] newArray = MultiplyArray(firstArr, secondArr);
// PrintArray(newArray);