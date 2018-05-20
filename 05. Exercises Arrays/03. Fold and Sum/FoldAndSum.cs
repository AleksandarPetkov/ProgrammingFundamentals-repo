using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().
            Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).
            ToArray();

        int k = (nums.Length / 4);
        int[] leftArray = nums.Take(k).ToArray();
        int[] middArray = nums.Skip(k).Take(2 * k).ToArray();
        int[] rightArray = nums.Skip(3*k).Take(k).ToArray();
        Array.Reverse(leftArray);
        Array.Reverse(rightArray);

        int[] firstSum = new int [2 * k];
        int[] result = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            firstSum[i] = leftArray[i];
        }

        for (int j = 0; j < k; j++)
        {
            firstSum[j + k] = rightArray[j];
        }

        for (int i = 0; i < k*2; i++)
        {
            result[i] = firstSum[i] + middArray[i];
        }
        Console.WriteLine(string.Join(" ",result));
       
    }
}

