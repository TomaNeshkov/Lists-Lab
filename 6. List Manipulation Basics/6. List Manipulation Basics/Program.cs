﻿using System;
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

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                    break;

                case "Remove":
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove);
                    break;

                case "RemoveAt":
                    int indexToRemove = int.Parse(tokens[1]);
                    numbers.RemoveAt(indexToRemove);
                    break;

                case "Insert":
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
