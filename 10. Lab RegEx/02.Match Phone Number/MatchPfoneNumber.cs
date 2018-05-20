using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MatchPfoneNumber
{
    static void Main()
    {
        string pattern = @"\+359 2 ([0-9]{3}) ([0-9]{4})|\+359-2-([0-9]{3})-([0-9]{4})";
        string input = Console.ReadLine();

        MatchCollection matchedPhones = Regex.Matches(input, pattern);

        string[] phoneMatches = matchedPhones.
             Cast<Match>().
             Select(a => a.Value.Trim()).
             ToArray();

        Console.WriteLine(string.Join(", ",phoneMatches));
    }
}

