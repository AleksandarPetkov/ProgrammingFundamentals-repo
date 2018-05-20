using System;
using System.Collections.Generic;
using System.Linq;

class LargestThree
{

    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        List<int> result = numbers.OrderByDescending(x => x).Take(3).ToList();
        Console.WriteLine(string.Join(" ", result));
    }

}