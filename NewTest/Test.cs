using System;
using System.Collections.Generic;

public class NumberReplacer
{
    public List<string> ReplaceNumbers(List<int> numbers)
    {
        List<string> replacedNumbers = new List<string>();

        foreach (int number in numbers)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                replacedNumbers.Add("fizz-buzz");
            }
            else if (number % 3 == 0)
            {
                replacedNumbers.Add("fizz");
            }
            else if (number % 5 == 0)
            {
                replacedNumbers.Add("buzz");
            }
            else
            {
                replacedNumbers.Add(number.ToString());
            }
        }

        return replacedNumbers;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Пример использования программы
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        NumberReplacer numberReplacer = new NumberReplacer();
        List<string> replacedNumbers = numberReplacer.ReplaceNumbers(numbers);

        foreach (string replacedNumber in replacedNumbers)
        {
            Console.WriteLine(replacedNumber);
        }
    }
}
