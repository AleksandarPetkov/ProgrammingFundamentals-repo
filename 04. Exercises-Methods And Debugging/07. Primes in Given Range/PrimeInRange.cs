using System;
using System.Collections.Generic;

class PrimeInRange
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        FindPrimeInRange(firstNumber, secondNumber);
    }

    private static void FindPrimeInRange(int firstNumber, int secondNumber)
    {
        List<int> numbers = new List<int>();
        
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("(empty list)");
            return;
        }
        if (firstNumber <= 1 || secondNumber < 0)
        {
            firstNumber = 2;
        }
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                numbers.Add(i);
            }
        }
        PrintResult(numbers);
    }

    private static void PrintResult(List<int> numbers)
    {
        Console.WriteLine(string.Join(", ",numbers));
    }

}

