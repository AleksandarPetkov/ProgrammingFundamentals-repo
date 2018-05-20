using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Trainegram
{
    static void Main()
    {
        string trainPattern = @"^(\<\[[^a-zA-Z0-9]*\]\.)(\.{1}\[[a-zA-Z0-9]*\]\.{1})*$";

        List<string> validTrains = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Traincode!")
            {
                break;
            }

            if (Regex.IsMatch(input, trainPattern))
            {
                Match match = Regex.Match(input, trainPattern);
                validTrains.Add(match.Value);
            }
        }
        Console.WriteLine(string.Join("\n",validTrains));
    }
}

