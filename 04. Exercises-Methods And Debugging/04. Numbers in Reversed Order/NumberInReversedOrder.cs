using System;

class NumberInReversedOrder
{
    static void Main()
    {
        ReversedDigits(Console.ReadLine());
    }

    static void ReversedDigits(string number)
    {
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char digits = number[i];
            Console.Write(digits);
        }
        Console.WriteLine();
    }
}

