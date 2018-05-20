using System;

class MaxMethod
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMaxValue(firstNumber,secondNumber,thirdNumber));
    }

    static int GetMaxValue(int numberOne, int numberTwo, int numberThree)
    {
        int firstNumbers = Math.Max(numberOne, numberThree);
        int secondNumbers = Math.Max(firstNumbers, numberTwo);
        if (firstNumbers > secondNumbers)
        {
            return firstNumbers;
        }
        else
        {
            return secondNumbers;
        }
    }
}

