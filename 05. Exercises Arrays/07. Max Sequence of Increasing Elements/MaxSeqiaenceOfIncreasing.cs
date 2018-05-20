using System;
using System.Collections.Generic;
using System.Linq;

class MaxSeqiaenceOfIncreasing
{
    static void Main()
    {

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int counter = 1;
        int bestCounter = 0;
        int BestIndex = 0;
        

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] - numbers[i - 1] == 1)
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > bestCounter)
            {
                bestCounter = counter;
                BestIndex = i - counter + 1;
            }

        }
        for (int i = BestIndex; i < bestCounter + BestIndex; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    }
      
}
   


