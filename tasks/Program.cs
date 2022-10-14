//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] array = GetArray(3, 4, 1, 99);
// PrintArray(array);
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void Sort(int[,] arr)
// {
// for(int i = 0; i < arr.GetLength(0); i++)
// {
//     for(int j = 0; j < arr.GetLength(1); j++)
//     {
//         for(int n = 0; n < arr.GetLength(1) - 1; n++)
//         {
//             int maxposi = i;
//             int maxposj = j;
//             if(arr[i, n] > arr[maxposi,maxposj])
//             {
//                 maxposj = n;
//             }
//             int temp = arr[i, n];
//             arr[i, n] = arr[maxposi, maxposj];
//             arr[maxposi, maxposj] = temp;
//         }
//     }
// }
// }
// Sort(array);
// Console.WriteLine("Sorted array:");
// PrintArray(array);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int[,] array = GetArray(4, 4, 1, 9);
// PrintArray(array);
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int SumRow(int[,] arr, int i)
// {
//     int sumrow = 0;
//     for(int j = 0; j < arr.GetLength(1); j++)
//     {
//         sumrow = sumrow + arr[i, j];
//     }
//     return sumrow;
// }
// int minSumRow = SumRow(array, 0);
// int minSumRowNumber = 1;
// for(int i = 1; i < array.GetLength(0); i++)
// {
//     int sumrowi = SumRow(array, i);
//     if(sumrowi <  minSumRow)
//     {
//         minSumRow = sumrowi;
//         minSumRowNumber = i + 1; // + 1, так как линии считаем с 1, а индексы с 0
//     }
// }
// Console.WriteLine($"Minimum sum for elements = {minSumRow}, lane with minimun sum = {minSumRowNumber}");


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int[,] matrix1 = GetArray(2, 2, 1, 9);
// Console.WriteLine("First matrix: ");
// PrintArray(matrix1);
// int[,] matrix2 = GetArray(2, 2, 1, 9);
// Console.WriteLine("Second matrix: ");
// PrintArray(matrix2);
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] resultmatrix = new int[2, 2];
// void MultiMatrix(int[,] arr, int[,] arr2, int[,] arr3)
// {
//     for(int i = 0; i < arr3.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr3.GetLength(1); j++)
//         {
//             int sum = 0;
//             for(int n = 0; n < arr.GetLength(1); n++)
//             {
//                 sum = sum + arr[i, n] * arr2[n, j];
//             }
//             arr3[i, j] = sum;
//         }
//     }
// }
// MultiMatrix(matrix1, matrix2, resultmatrix);
// Console.WriteLine("matrix1 * matrix2 = ");
// PrintArray(resultmatrix);


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// int[,,] ArrayXYZ = GetArray(2, 2, 2, 10, 100);
// PrintArray(ArrayXYZ);
// int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
// {
//     int[] array = new int[x * y * z];   // проверка на одинаковые элементы через одномерный массив
//     int  number;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     array[i] = new Random().Next(10, 100);
//     number = array[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         if(array[i] == array[j])
//         {
//           array[i] = new Random().Next(10, 100);
//           j = 0;
//           number = array[i];
//         }
//           number = array[i];
//       }
//     }
//   }
//   int position = 0;
//   int[,,] result = new int[x, y, z];
//   for(int i = 0; i < x; i++)
//   {
//     for(int j = 0; j < y; j++)
//     {
//         for(int n = 0; n < z; n++)
//         {
//             result[i, j, n] = array[position];
//             position++;
//         }
//     }
//   }
//   return result;
// }
// void PrintArray(int[,,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             for(int n = 0; n < arr.GetLength(2); n++)
//             {
//                 Console.Write($"{arr[i, j, n]}({i},{j},{n}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Напишите программу, которая заполнит спирально массив 4 на 4.
// int[,] array = new int[4, 4];
// int temp = 1;
// int i = 0;
// int j = 0;
// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = temp;
//   temp++;
//   if((i <= j + 1)&&(i + j < array.GetLength(1) - 1))
//   {
//     j++;
//   }
//   else if((i < j)&&(i + j >= array.GetLength(0) - 1))
//   {
//     i++;
//   }
//   else if((i >= j)&&(i + j > array.GetLength(1) - 1))
//   {
//     j--;
//   }
//   else
//   {
//     i--;
//   }
// }
// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(array);

// Не работает
// void FillArray(int row, int col)    // Пробовал через рекурсию, как показывали на лекции, не получилось.
// {
//     int temp = 1;
//     if(array[row, col] == 0)
//     {
//         array[row, col] = temp;
//         temp++;
//         FillArray(row, col + 1);
//         FillArray(row + 1, col);
//         FillArray(row, col - 1);
//         FillArray(row - 1, col);
//     }
// }                                 
// FillArray(0, 0);
// PrintArray(array);                // Не работает до этой строки.