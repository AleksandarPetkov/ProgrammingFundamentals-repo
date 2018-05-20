using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Raincast
{
    static void Main()
    {
        string patternType = @"^Type: (Normal|Warning|Danger)$";
        string patternSource = @"^Source: ([a-zA-Z0-9]+)$";
        string patternForecast = @"^Forecast: ([^!\.,?]+)$";

        List<string> results = new List<string>();
        string type = string.Empty;
        string source = string.Empty;
        string forecast = string.Empty;

        int round = 1;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Davai Emo")
            {
                break;
            }

            if (round == 1)
            {
                if (Regex.IsMatch(input,patternType))
                {
                    Match match = Regex.Match(input, patternType);

                    type = match.Groups[1].Value;

                    round++;
                }
                
            }
            else if (round == 2)
            {
                if (Regex.IsMatch(input, patternSource))
                {
                    Match match = Regex.Match(input, patternSource);

                    source = match.Groups[1].Value;

                    round++;
                }
               
            }
            else if (round == 3)
            {
                if (Regex.IsMatch(input, patternForecast))
                {
                    Match match = Regex.Match(input, patternForecast);

                    forecast = match.Groups[1].Value;

                    string output = $"({type}) {forecast} ~ {source}";
                    results.Add(output);
                    round = round / 3;
                }
            }
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }        
    }
}

