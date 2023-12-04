// Задача 1: Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание, что такого элемента нет.



// int[,] CreateMatrix(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     // Матрица размером rows на colums
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++) //i < matrix.GetLength(0), строчки
//     {
//         // i, j, m, k
//         for (int j = 0; j < colums; j++) // столбцы j < matrix.GetLength(1)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     //[rows, columns]
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t"); // \t - это 4 пробела
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите размеры массива ");
// int i = Convert.ToInt32(Console.ReadLine());
// int j = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateMatrix(i, j, 0, 10);
// PrintMatrix(array);

// Console.WriteLine("Введите координаты");
// int firstElement = Convert.ToInt32(Console.ReadLine());
// int secondElement = Convert.ToInt32(Console.ReadLine());

// if (i < firstElement || j < secondElement)
//     Console.WriteLine("Такого числа нет");
// else
// {
//     object element = array.GetValue(firstElement, secondElement);
//     Console.WriteLine($"Искомое число: {element}");
// }

// Задача 2: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// int[,] array = CreateMatrix(4, 4, 0, 10);
// PrintMatrix(array);

// for (int i = 0; i < array.GetLength(1); i++)
// {
//     var tmp = array[3, i];
//     array[3, i] = array[0, i];
//     array[0, i] = tmp;
// }
// Console.WriteLine("\n");
// PrintMatrix(array);

// Задача 3: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
//   с наименьшей суммой элементов и выводить на экран

// int[,] matrix = CreateMatrix(4, 3, 0, 10);
// PrintMatrix(matrix);

// int sum = int.MaxValue;
// int index = 0;
// for (int i = 0; i < 4; i++)
// {
//     int temp = 0;
//     for (int j = 0; j < 3; j++)
//     {
//         temp += matrix[i, j];
//     }
//     if (temp < sum)
//     {
//         sum = temp;
//         index = i;
//     }
// }
// Console.WriteLine("Строка: " + index + " Сумма - " + sum);
