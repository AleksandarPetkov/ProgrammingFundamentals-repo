using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MatchDates
{
    static void Main()
    {
        string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>\w{3})\1(?<year>\d{4})\b";
        string input = Console.ReadLine();

        MatchCollection dates = Regex.Matches(input, pattern);

        foreach (Match date in dates)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}

