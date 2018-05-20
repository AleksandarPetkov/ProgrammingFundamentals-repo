using System;
using System.Collections.Generic;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(PrintFacturial(number));
       
    }

    static BigInteger PrintFacturial(int num)
    {
        BigInteger factorial = num;
        for (int i = num - 1; i >= 1; i--)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}
