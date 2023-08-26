//Проверить существует треугольник с введенными сторонами или нет
// Console.Write("Введите длину первой стороны треугольника: ");
// double a = double.Parse(Console.ReadLine());

// Console.Write("Введите длину второй стороны треугольника: ");
// double b = double.Parse(Console.ReadLine());

// Console.Write("Введите длину третьей стороны треугольника: ");
// double c = double.Parse(Console.ReadLine());

// if (a + b > c && a + c > b && b + c > a)
// {
//     Console.WriteLine("Треугольник с такими сторонами может существовать.");
// }
// else
// {
//     Console.WriteLine("Треугольник с такими сторонами не может существовать.");
// }

//Вывести в консоль числа фибоначи в виде массива
// Console.WriteLine("Введите число фибоначи");
// int n = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// Console.Write(x + ", ");
// for (int i = 2; i <= n; i++)
// {
//     if (i == n)
//     {
//         Console.Write(i * n);
//     }
//     else
//     {
//         Console.Write(i * n + ", ");
//     }
// }


//Создать копию массива копируя его поэлеиментно
// Console.WriteLine("Введите размер массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = NewMass(m);
// int[] NewMass(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < n; i++) //Вводим Рандомные числа в массив и считаем четные числа
//     {
//         array[i] = new Random().Next(0, 999);
//     }
//     return array;
// }
// PrintArr(array);

// int[] newarr = CopyMass(array);
// PrintArr(newarr);

// void PrintArr(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < m; i++)
//     {
//         if (i == (m - 1))
//             System.Console.Write($"{array[i]}");
//         else
//             System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write("]");
// }

// int[] CopyMass(int[] arr)
// {
//     int[] dublikat = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         dublikat[i] = arr[i];
//     }
//     return dublikat;
// }