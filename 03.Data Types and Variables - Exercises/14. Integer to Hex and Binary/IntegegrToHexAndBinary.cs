using System;

class IntegegrToHexAndBinary
{
    static void Main()
    {
        int decValue = int.Parse(Console.ReadLine());

        string hexValue = string.Format("{0:x}", decValue);

        string binary = Convert.ToString(decValue, 2);

        Console.WriteLine(hexValue.ToUpper());
        Console.WriteLine(binary);
    }
}

