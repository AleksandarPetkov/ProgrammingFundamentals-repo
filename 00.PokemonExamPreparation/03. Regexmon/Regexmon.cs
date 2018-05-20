using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Regexmon
{
    static void Main()
    {
        string patternDidi = @"[^a-zA-Z-]+";
        string patternBojo = @"[a-zA-Z]+-[a-zA-Z]+";

        List<string> results = new List<string>();
        string input = Console.ReadLine();
        while (true)
        {
            if (Regex.IsMatch(input,patternDidi))
            {
                Match matchDidi = Regex.Match(input, patternDidi);
                results.Add(matchDidi.Value);

                int index = input.IndexOf(matchDidi.Value);
                input = input.Substring(index);
            }
            else
            {
                break;
            }

            if (Regex.IsMatch(input, patternBojo))
            {
                Match matchBojo = Regex.Match(input, patternBojo);
                results.Add(matchBojo.Value);


                int index = input.IndexOf(matchBojo.Value);
                input = input.Substring(index);
            }
            else
            {
                break;
            }
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}

