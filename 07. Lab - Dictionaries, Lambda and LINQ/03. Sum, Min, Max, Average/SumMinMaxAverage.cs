using System;
using System.Collections.Generic;
using System.Linq;

class SumMinMaxAverage
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num; 
        }

        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");

    }

}

