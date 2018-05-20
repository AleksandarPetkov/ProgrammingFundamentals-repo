using System;

class FibonnacciNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(PrintFibonnacciNumbers(number));
    }

    static int PrintFibonnacciNumbers(int fibonacciNumber)
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int nNumber = 0;
        if (fibonacciNumber == 0 || fibonacciNumber == 1)
        {
            return fibonacciNumber = 1;
        }
        else
        {
            for (int i = 0; i < fibonacciNumber; i++)
            {
                nNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nNumber;
            }
            return nNumber;
        }
    }
}

