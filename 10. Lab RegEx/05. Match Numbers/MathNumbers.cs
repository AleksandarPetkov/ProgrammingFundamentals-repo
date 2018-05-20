using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MathNumbers
{
    static void Main()
    {
        string pattern = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
        string input = Console.ReadLine();



        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.Write($"{m.Value} ");
        }
    }
}

