using System;
using System.Collections.Generic;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] condense = new int[nums.Length - 1];

        if (nums.Length == 1)
        {
            Console.WriteLine(nums[0]);
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < condense.Length-i; j++)
            {
                condense[j] = nums[j] + nums[j + 1];
            }
            nums = condense;
        }
        Console.WriteLine(nums[0]);
    }
}

