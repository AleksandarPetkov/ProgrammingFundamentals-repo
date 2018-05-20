using System;
using System.Collections.Generic;
using System.Linq;

class NSA
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> dictData = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            string[] inputArgs = input.Split(new[] { " -> " }, StringSplitOptions.None).ToArray();
            string country = inputArgs[0];
            string name = inputArgs[1];
            int days = int.Parse(inputArgs[2]);

            if (dictData.ContainsKey(country) == false)
            {
                dictData.Add(country, new Dictionary<string, int>());
               
            }
            if (dictData[country].ContainsKey(name))
            {
                dictData[country][name] = days;
            }
            else
            {
                dictData[country][name] = days;
            }
            
        }

        foreach (var pair in dictData.OrderByDescending( x => x.Value.Count))
        {
            Console.WriteLine($"Country: {pair.Key}");

            foreach (var spy in pair.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"**{spy.Key} : {spy.Value}");
            }
        }
    }
}

