


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class Weather
{
    static void Main()
    {
        Dictionary<string, KeyValuePair<double, string>> dataHolders = new Dictionary<string, KeyValuePair<double, string>>();

        string pattern = @"([A-Z]{2})([0-9]{1,2}.[0-9]{1,2})([A-Za-z]+)\|";

       

        while (true)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            string city = string.Empty;
            double temp = 0;
            string weather = string.Empty;

            MatchCollection matchedInput = Regex.Matches(input, pattern);

            foreach (Match element in matchedInput)
            {
                city = element.Groups[1].Value;
                temp = double.Parse(element.Groups[2].Value);
                weather = element.Groups[3].Value;
            }

            if (!dataHolders.ContainsKey(city))
            {
                dataHolders[city] = new KeyValuePair<double, string>(temp, weather);
            }
            else
            {
                dataHolders[city] = new KeyValuePair<double, string>(temp, weather);

            }
           
        }

        var sortedDict = dataHolders.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);
        foreach (var element in sortedDict)
        {
            Console.WriteLine($"{element.Key} => {element.Value.Key:f2} => {element.Value.Value}");
        }
    }
}


