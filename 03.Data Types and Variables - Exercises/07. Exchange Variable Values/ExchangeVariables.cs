using System;

class ExchangeVariables
{
    static void Main()
    {
        int fistNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int addNumberOne = 0;
        int addNumberTwo = 0;

        addNumberOne = fistNumber;
        addNumberTwo = secondNumber;

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {fistNumber}");
        Console.WriteLine($"b = {secondNumber}");

        Console.WriteLine("After:");
        Console.WriteLine($"a = {addNumberTwo}");
        Console.WriteLine($"b = {addNumberOne}");




    }
}

