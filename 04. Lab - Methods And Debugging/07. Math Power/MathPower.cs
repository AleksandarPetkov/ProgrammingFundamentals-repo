using System;

class MathPower
{
    static double PrintMathPower(double first, double second)
    {
        return Math.Pow(first, second);
    }

    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        double mathPower = PrintMathPower(firstNumber, secondNumber);
        Console.WriteLine(mathPower);
    }
}

