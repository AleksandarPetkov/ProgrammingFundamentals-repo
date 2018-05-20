using System;
using System.Collections.Generic;

class MasterNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            bool IsPolindrome = PolindoneCheck(i);
            bool IsDevisibleBySeven = DevisibleBySevenCheck(i);
            bool isEvenDigit = EvenDigitCheck(i);

            if (IsPolindrome && IsDevisibleBySeven && isEvenDigit)
            {
                Console.WriteLine(i);
            }
        }
  
    }

    private static bool PolindoneCheck(int i)
    {
        int number = i;
        int reversedNumber = 0;
        while (i > 0)
        {

            int digit = i % 10;
            reversedNumber = reversedNumber * 10 + digit;

            i /= 10;
        }
        if (number == reversedNumber)
        {
            return true;
        }
        return false;
    }

    private static bool DevisibleBySevenCheck(int i)
    {
        int sum = 0;
        while (i > 0)
        {
            sum += i % 10;
            i /= 10;
            
        }
        if (sum % 7 == 0)
        {
            return true;
        }
        return false;
    }

    private static bool EvenDigitCheck(int number)
    {
        int digit = 0;
        while (number > 0)
        {
            digit = number % 10;
            if (digit % 2 == 0)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}

