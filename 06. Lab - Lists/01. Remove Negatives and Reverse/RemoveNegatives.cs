using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegatives
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        List<int> items = new List<int>();

        foreach (int num in numbers)
        {
            if (num > 0)
            {
                items.Add(num);
            }
            
        }

       
        items.Reverse();

        if (items.Any())
        {
            Console.WriteLine(string.Join(" ", items));
        }
        else
        {
            Console.WriteLine("empty");
        }

       
       
    }
}

