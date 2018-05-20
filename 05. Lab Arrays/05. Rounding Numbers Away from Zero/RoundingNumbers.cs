using System;
using System.Collections.Generic;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        foreach (var x in numbers)
        {
            double rounded = Math.Round(x, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{x} => {rounded}");
        }
    }
}

