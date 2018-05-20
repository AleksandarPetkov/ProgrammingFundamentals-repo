using System;
using System.Collections.Generic;
using System.Linq;

class Practise
{
    static void Main()
    {
        string inpitLine = Console.ReadLine();
        List<int> nums = inpitLine.Split(' ').Select(int.Parse).ToList();

        nums.Sort();
        Console.WriteLine(string.Join(" <= ", nums));
    }
}

