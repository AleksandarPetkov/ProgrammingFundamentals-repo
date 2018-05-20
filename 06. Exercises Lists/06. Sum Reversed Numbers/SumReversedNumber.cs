using System;
using System.Collections.Generic;
using System.Linq;

class SumReversedNumber
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        int sum = 0;
        
        for (int i = 0; i < numbers.Count; i++)
        {
            int currentNumber = numbers[i];
            int reversedNum = 0;

            while (currentNumber > 0)
            {
                int remainder = currentNumber % 10;
                reversedNum = (reversedNum * 10) + remainder;
                currentNumber = currentNumber / 10;
            }
            sum += reversedNum;
        }
        Console.WriteLine(sum);
    }
}

