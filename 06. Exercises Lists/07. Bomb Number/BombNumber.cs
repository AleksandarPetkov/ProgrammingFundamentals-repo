using System;
using System.Collections.Generic;
using System.Linq;

class BombNumber
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
             Split(' ').
             Select(int.Parse).
             ToList();

        List<int> bombNumber = Console.ReadLine().
           Split(' ').
           Select(int.Parse).
           ToList();


        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber[0])
            {
                for (int j = i - bombNumber[1]; j <= bombNumber[1] + i; j++)
                {
                    if (j >= 0 && j <= numbers.Count - 1)
                    {
                        numbers[j] = 0;
                    }
                   
                }

            }
        }
        Console.WriteLine(numbers.Sum());

    }
}

