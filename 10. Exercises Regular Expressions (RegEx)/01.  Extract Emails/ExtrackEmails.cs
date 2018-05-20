using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtrackEmails
{
    static void Main()
    {
        string pattern = @"(?<=\s)[a-z0-9]+([.-]\w*)*@[a-z]+([.-]\w*)*(\.[a-z]+)";
        string input = Console.ReadLine();

        MatchCollection matchedEmails = Regex.Matches(input, pattern);

        foreach (Match email in matchedEmails)
        {
            Console.WriteLine(email);
        }
    }
}

