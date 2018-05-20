using System;

class OddNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num % 2 != 0)
        {
            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
        else
        {
            Console.WriteLine("Please write an odd number.");
        }
    }
}

