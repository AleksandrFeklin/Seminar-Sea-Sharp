// //Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// void PrintArray(int[,] array) {
// for (var i = 0; i < array.GetLength(0); i++) {
// for (var j = 0; j < array.GetLength(1); j++) {
// Console.Write($"{array[i,j]}, ");
// }
// Console.WriteLine();
// }
// }

// int[,] CreateArrayWithRandomNumbers(int m, int n) {
// int[,] result = new int[m,n];

// var random = new Random();

// for (var i = 0; i < result.GetLength(0); i++) {
// for (var j = 0; j < result.GetLength(1); j++) {
// result[i,j] = random.Next(1, 100);
// }
// }

// return result;
// }

// Console.WriteLine("Введите число строк (m)");
// if(!int.TryParse(Console.ReadLine()!, out var m)) {
// Console.WriteLine("Всё плохо");
// }

// Console.WriteLine("Введите число столбцов (n)");
// if(!int.TryParse(Console.ReadLine()!, out var n)) {
// Console.WriteLine("Всё плохо");
// }


// PrintArray(CreateArrayWithRandomNumbers(m, n));





// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса  
//чётные, и замените эти элементы на их квадраты. 
// Например, изначально массив 
//  выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 

// void PrintArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}, ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateArrayWithRandomNumbers(int m, int n)
// {
//     int[,] result = new int[m, n];

//     var random = new Random();

//     for (var i = 0; i < result.GetLength(0); i++)
//     {
//         for (var j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = random.Next(1, 10);
//         }
//     }

//     return result;
// }
// void ChetSqrtElements(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i = i + 2)
//     {
//         for (var j = 0; j < array.GetLength(1); j = j + 2)
//         {
//             array[i, j] *= array[i, j];
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число строк (m)");
// if (!int.TryParse(Console.ReadLine()!, out var m))
// {
//     Console.WriteLine("Всё плохо");
// }

// Console.WriteLine("Введите число столбцов (n)");
// if (!int.TryParse(Console.ReadLine()!, out var n))
// {
//     Console.WriteLine("Всё плохо");
// }

// Console.WriteLine();
// var array = CreateArrayWithRandomNumbers(m, n);
// Console.WriteLine();
// PrintArray(array);
// ChetSqrtElements(array);
// PrintArray(array);



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] CreateArrayWithRandomNumbers(int m, int n)
// {
//     int[,] result = new int[m, n];
//     var random = new Random();
//     for (var i = 0; i < result.GetLength(0); i++)
//         for (var j = 0; j < result.GetLength(1); j++)
//             result[i, j] = random.Next(1, 10);
//     return result;
// }
// void PrintArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
//         Console.WriteLine();
//     }
// }
// int DiagonalSum(int[,] array)
// {
//     int sum = 0;
//     for (var i = 0; i < array.GetLength(0); i++)
//         for (var j = 0; j < array.GetLength(1); j++)
//             if (i == j) sum += array[i, j];
//     return sum;
// }
// Console.WriteLine("Введите число строк (m)");
// if (!int.TryParse(Console.ReadLine()!, out var m)) Console.WriteLine("Всё плохо");
// Console.WriteLine("Введите число столбцов (n)");
// if (!int.TryParse(Console.ReadLine()!, out var n)) Console.WriteLine("Всё плохо");
// int[,] array = CreateArrayWithRandomNumbers(m, n);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Сумма элементов находящихся на главной диагонали = " + DiagonalSum(array));