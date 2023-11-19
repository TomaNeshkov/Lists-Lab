using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        RemoveNegativesAndReverse(numbers);
    }

    static void RemoveNegativesAndReverse(List<int> numbers)
    {
        numbers.RemoveAll(num => num < 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
