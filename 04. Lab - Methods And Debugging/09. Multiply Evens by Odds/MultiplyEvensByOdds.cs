using System;

class MultiplyEvensByOdds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = Math.Abs(n);
        Console.WriteLine(GetMultiplyOfEvensAndOdds(number));

    }

    private static int GetMultiplyOfEvensAndOdds(int number)
    {
        
        int sumEvens = GetSumOfEvenDigits(number);
        int sumOdds = GetSumOfOddsDigits(number);
        return sumEvens * sumOdds; 
    }

    static int GetSumOfEvenDigits(int digit)
    {
        int evensSum = 0;

        while (digit > 0)
        {
            int lastDigit = digit % 10;
            if (lastDigit % 2 == 0)
            {
                evensSum += lastDigit;
               
            }
            digit /= 10;
        }
        return evensSum;
    }

    static int GetSumOfOddsDigits(int digit)
    {
        int oddsSum = 0;

        while (digit > 0)
        {
            int lastDigit = digit % 10;
            if (lastDigit % 2 != 0)
            {
                oddsSum += lastDigit;

            }
            digit /= 10;
        }
        return oddsSum;
    }


}

