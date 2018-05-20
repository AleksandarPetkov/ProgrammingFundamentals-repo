using System;


class HexadecimalFormat
{
    static void Main()
    {
        string numberInHex = Console.ReadLine();

        int numberInDecimal = Convert.ToInt32(numberInHex, 16);

        Console.WriteLine(numberInDecimal);
    }
} 

