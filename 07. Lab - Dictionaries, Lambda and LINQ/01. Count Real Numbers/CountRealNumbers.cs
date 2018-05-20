using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().
            Split(' ').
            Select(double.Parse).
            ToArray();

        var counts = new SortedDictionary<double, int>();

        foreach (var num in numbers)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        foreach (var num in counts.Keys)
        {
            Console.WriteLine($"{num} -> {counts[num]}");
        }
    }
}

