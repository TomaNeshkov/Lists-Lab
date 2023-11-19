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

        SumGaussTrick(numbers);

        Console.WriteLine(string.Join(" ", numbers));
    }

    static void SumGaussTrick(List<int> numbers)
    {
        int originalCount = numbers.Count;

        for (int i = 0; i < originalCount / 2; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }
    }
}
