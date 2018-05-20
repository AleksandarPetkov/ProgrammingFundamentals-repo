using System;

class SignOfIntegerNumbers
{
    static void DeclareSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0 )
        {
            Console.WriteLine($"The number {number} is negative.");

        }
        else if (number == 0)
        {
            Console.WriteLine("The number 0 is zero.");
        }
    }

    static void Main()
    {
        DeclareSign(int.Parse(Console.ReadLine()));
    }
}

