using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MatchHexNum
{
    static void Main()
    {
        string pattern = @"\b(?:0x)?[0-9A-F]+\b";

        string input = Console.ReadLine();

        string[] numbers = Regex.Matches(input, pattern).
            Cast<Match>().
            Select(a => a.Value).
            ToArray();

        Console.WriteLine(string.Join(" ",numbers));
            
    }
}

