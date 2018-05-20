using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequaence
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        int biggestIndex = 0;
        int biggestCount = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            int counter = 0;
            int index = numbers[i];

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    counter++;
                }
                if (counter > biggestCount)
                {
                    biggestCount = counter;
                    biggestIndex = index;
                }
            }
        }

        for (int i = 0; i < biggestCount; i++)
        {
            Console.Write($"{biggestIndex} ");
        }
        Console.WriteLine();
    }
}

