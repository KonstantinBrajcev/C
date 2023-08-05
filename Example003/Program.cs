// Console.Write("Введите ваше имя");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);

// double numberA = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// double numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// double result1 = numberA + numberB;
// Console.WriteLine(result1);
// double result2 = numberA / numberB;
// Console.WriteLine(result2);

using System;

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
Console.WriteLine(username);
if (username == "Маша")
{
    Console.WriteLine("Ура это же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}