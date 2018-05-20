using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        List<int> squars = new List<int>();

        foreach (var num in numbers)
        {
            if (Math.Sqrt(num) == (int)Math.Sqrt(num))
            {
                squars.Add(num);
            }
        }
        Console.WriteLine(string.Join(" ",squars));
    }
}

