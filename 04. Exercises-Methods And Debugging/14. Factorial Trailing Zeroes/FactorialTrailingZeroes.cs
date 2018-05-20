using System;
using System.Numerics;


class FactorialTrailingZeroes
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
       
        BigInteger printFacturial = CalculateFacturial(number);

        Console.WriteLine($"{TrailingZeroes(printFacturial)}");
    }

    static BigInteger TrailingZeroes(BigInteger num)
    {
        int counter = 0;
        BigInteger zeroesChecker = 0;
        while (num > 0)
        {
            zeroesChecker = num % 10;
            if (zeroesChecker == 0)
            {
                counter++;
            }
            else
            {
                break;
            }
            num /= 10;
        }
        return counter;

    }

    public static BigInteger CalculateFacturial(int number)
    {
      
        BigInteger factorial = number;
        for (int i = number - 1; i >= 1; i--)
        {
            factorial = factorial * i;
        }
        return factorial;
    }

   
}

