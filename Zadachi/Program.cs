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