// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Укажите номер строки ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите номер столбца ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,11);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
// System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }

// CreateArray();
// PrintArray();

// if(num1 >= 0 && num1 < array.GetLength(0) && num2 >=0 && num2 < array.GetLength(1))
//     {
//         int num3 = array[num1,num2];
//         Console.WriteLine("Элемент массива = " +num3);
//     }
// else
//     {
//         Console.WriteLine("Такого элемента нет");
//     }

// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и
// последнюю строку массива.

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,11);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
// System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }

// void FindElementsArray(int row1, int row2)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//         Console.WriteLine();
// }

// CreateArray();
// PrintArray();
// FindElementsArray(0, array.GetLength(0) - 1);
// PrintArray();

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[3,3];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
// System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     int minSum = int.MaxValue;
//     int minSumRow = -1;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//     int currentSum = 0;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            currentSum += array[i,j];
//         }
//         if(currentSum < minSum)
//            {
//                 minSum = currentSum;
//                 minSumRow = i;
//            }
            
// }
// Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
// }

// CreateArray();
// PrintArray();
// FindElementsArray();

// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

// int[,] array = new int[3,3];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);
//     }
// }

// // Находим наименьший элемент и его индексы
// int minElement = array[0, 0];
// int minRowIndex = 0;
// int minColIndex = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i, j] < minElement)
//         {
//             minElement = array[i, j];
//             minRowIndex = i;
//             minColIndex = j;
//         }
//     }
// }

// // Создаем новый массив без строки и столбца с минимальным элементом
// int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

// for (int i = 0, newRow = 0; i < array.GetLength(0); i++)
// {
//     if (i == minRowIndex)
//     {
//         continue; // Пропускаем строку с минимальным элементом
//     }

//         for (int j = 0, newCol = 0; j < array.GetLength(1); j++)
//         {
//             if (j == minColIndex)
//             {
//                 continue; // Пропускаем столбец с минимальным элементом
//             }

//                 newArray[newRow, newCol] = array[i, j];
//                 newCol++;
//         }
//             newRow++;
// }
        
// // Выводим исходный массив
// Console.WriteLine("Исходный массив:");
// PrintArray(array);

// // Выводим новый массив без строки и столбца с минимальным элементом
// Console.WriteLine("\nНовый массив после удаления строки и столбца с минимальным элементом:");
// PrintArray(newArray);
    

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine();
//     }
// }