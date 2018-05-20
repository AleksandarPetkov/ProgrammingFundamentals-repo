using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class AnonymousVox
{
    static void Main()
    {
        string pattern = @"([a-zA-Z]+)(.+)(\1)";

        string input = Console.ReadLine();
        string[] placeholders = Console.ReadLine().
            Split(new char[] { '{', '}' }).
            ToArray();

        placeholders = placeholders.Where(x => x.Length > 0).ToArray();

        MatchCollection matches = Regex.Matches(input, pattern);

        int count = 0;
        foreach (Match match in matches)
        {
            string oldValue = match.Value;
            string newValue = match.Groups[1].Value + placeholders[count] + match.Groups[1].Value;
            input = input.Replace(oldValue, newValue);

            count++;
        }
        Console.WriteLine(input);
    }
}

