// *HomeWork7*

// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// double [,] array =new double [rows,columns];
// int n = 1;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     array[i,j] = Math.Round((new Random().NextDouble() + new Random().Next(-9,10)),n);
//      Console.Write(array[i,j]+ "  ");
//     }
// Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите искомое число");
// int find = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] array =new int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ "  ");
//     }
// Console.WriteLine();
// }

// bool f = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (find == array[i, j]) 
//             { f = true;};
        
//         }
//     }
// Console.WriteLine();
// if (f)
//     Console.WriteLine(find + "-есть в данном массиве");
// else
//     Console.WriteLine(find + "-нет в данном массиве");


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] array =new int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ "  ");
//     }
// Console.WriteLine();
// }
// Console.WriteLine("Среднее арифметическое каждого столбца:");

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     int n = 1;
//     double sum = 0;
//     double avg = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//     sum+=array[i,j];
//     avg = sum/array.GetLength(0);    
//     }
//     Console.Write(Math.Round(avg, n) +"  "); 
// }