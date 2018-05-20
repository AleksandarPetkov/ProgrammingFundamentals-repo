using System;

class PrimeChecker
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(number));
    }

    static bool IsPrime(long input)
    {
        int sqrtInput = (int)Math.Sqrt(input);
        if (input <= 1)
        {
            return false;
        }
        else
        {
            for (int verifier = 2; verifier <= sqrtInput; verifier++)
            {
                if (input % verifier == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }


}

