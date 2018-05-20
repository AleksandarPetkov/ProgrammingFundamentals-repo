using System;
using System.Collections.Generic;
using System.Linq;

class SumArrays
{
    static void Main()
    {

        int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        long maxArray = Math.Max(firstArray.Length, secondArray.Length);

        for (long i = 0; i < maxArray; i++)
        {
            long sum = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            //Чрез(i % firstArray.Length) не позволява на брояча да излеза извън размера на масива,
            //като го прави кръгов => (0 % 4 = 0), (1 % 4 = 1),(2 % 4 = 2),(3 % 4 = 3),(4 % 4 = 0),(5 % 4 = 1) и тн
            Console.Write(sum + " ");
        }
    }
}

