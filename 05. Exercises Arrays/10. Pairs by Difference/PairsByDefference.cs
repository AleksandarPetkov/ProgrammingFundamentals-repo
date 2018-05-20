using System;
using System.Collections.Generic;
using System.Linq;

class PairsByDefference
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int element1 = numbers[i];

            for (int j = i+1; j < numbers.Length; j++)
            {
                int element2 = numbers[j];
                int result1 =element1 - element2;
                int result2 = element2 - element1;

                if (result1 == difference || result2 == difference)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

