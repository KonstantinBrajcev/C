// Задача 19 - Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Insert number");
// int number = Convert.ToInt32(Console.ReadLine());
// (var a1, var a2, var a3, var a4, var a5) = (Convert.ToString(number)[0], Convert.ToString(number)[1], Convert.ToString(number)[2], Convert.ToString(number)[3], Convert.ToString(number)[4]);
// if ((a1 == a5) & (a2 == a4)) Console.WriteLine("This NUMBER is PALINDROME");
// else Console.WriteLine("This NUMBER is not PALINDROME");

// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Insert coordinat X1,Y1,Z1");
// double[] n1 = new double[3];
// for (int i = 0; i < n1.Length; i++)
// {
//     n1[i] = Convert.ToDouble(Console.ReadLine());
// }
// Console.WriteLine("Insert coordinat X2,Y2,Z2");
// double[] n2 = new double[3];
// for (int i = 0; i < n2.Length; i++)
// {
//     n2[i] = Convert.ToDouble(Console.ReadLine());
// }
// Console.WriteLine("Dimention = " + Math.Round(Math.Sqrt(Math.Pow(n2[0] - n1[0], 2) + Math.Pow(n2[1] - n1[1], 2) + Math.Pow(n2[2] - n1[2], 2)), 2));

// Задача 23 - Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }


// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int a = Prompt("Введите основание - ");
// int b = Prompt("Введите степень - ");
// int Prompt(string message) // Вводим числа с клавиатуры
// {
//     System.Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// bool Zero(int b) // Проверяем меньше нуля
// {
//     if (b < 0)
//     {
//         System.Console.WriteLine("Показатель не может быть меньше нуля");
//         return false;
//     }
//     else
//     {
//         return true;
//     }
// }
// if (Zero(b)) //Выводим расчет
// {
//     System.Console.WriteLine($"Число {a} в степени {b} будет равно {Math.Pow(a, b)}");
// }

// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int a = Prompt("Введите число - ");
// int Prompt(string message) // Вводим число с клавиатуры
// {
//     System.Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int Summa(int a)
// {
//     int summa = 0;
//     while (a != 0)
//     {
//         summa += a % 10;
//         a = a / 10;
//     }
//     return summa;
// }
// System.Console.WriteLine("Сумма цифр числа составляет - " + Summa(a));

// Задача 29: 
// Напишите программу, которая задаёт массив из m элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Console.WriteLine("Введите количество элементов массива: ");//спрашиваем сколько чисел будет
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];
// for (int i = 0; i < m; i++) //Вводим числа массива
// { array[i] = Prompt($"Введите {i + 1} элемент массива:"); }
// int Prompt(string message) // Вводим число с клавиатуры
// {
//     System.Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// PrintArr(array);//Выводим массив в строку
// void PrintArr(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < m; i++)
//     {
//         if (i == (m - 1))
//         System.Console.Write($"{array[i]}"); 
//         else
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write("]");
// }


// 10.08.2023
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




// 28.08.2023
// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)