using System;
using System.Collections.Generic;
using System.Linq;

class LargestCommonEnd
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split(' ');
        string[] secondInput = Console.ReadLine().Split(' ');

        int lenghtArr = Math.Min(firstInput.Length, secondInput.Length);
        int leftCounter = 0;
        int rightCounter = 0;


        for (int i = 0; i < lenghtArr; i++)
        {
            if (firstInput[i] == secondInput[i])
            {
                leftCounter++;
            }
            if (firstInput[firstInput.Length - i - 1] == secondInput[secondInput.Length - i - 1])
            {
                rightCounter++;
            }
        }
        Console.WriteLine(Math.Max(leftCounter,rightCounter));
    }
}

