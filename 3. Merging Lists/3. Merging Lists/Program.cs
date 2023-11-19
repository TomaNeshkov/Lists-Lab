﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> secondList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> mergedList = MergeLists(firstList, secondList);

        Console.WriteLine(string.Join(" ", mergedList));
    }

    static List<int> MergeLists(List<int> firstList, List<int> secondList)
    {
        List<int> result = new List<int>();
        int minLength = Math.Min(firstList.Count, secondList.Count);

        for (int i = 0; i < minLength; i++)
        {
            result.Add(firstList[i]);
            result.Add(secondList[i]);
        }

        result.AddRange(firstList.Skip(minLength));
        result.AddRange(secondList.Skip(minLength));

        return result;
    }
}
