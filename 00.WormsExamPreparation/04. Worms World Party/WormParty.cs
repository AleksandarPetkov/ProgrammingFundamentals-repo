using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WormParty
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> dictWorms = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            string[] inputArgs = input.Split(new[] { " -> " }, StringSplitOptions.None).Select(x => x.Trim()).ToArray();

            string wormName = inputArgs[0];
            string wormTeam = inputArgs[1];
            long score = long.Parse(inputArgs[2]);

            if (dictWorms.ContainsKey(wormTeam) == false)
            {
                dictWorms.Add(wormTeam, new Dictionary<string, long>());
            }

            bool inside = false;
            foreach (var pair in dictWorms)
            {
                foreach (var item in pair.Value)
                {
                    if (item.Key == wormName)
                    {
                        inside = true;
                        break;
                    }
                }
            }

            if (inside == false)
            {
                dictWorms[wormTeam].Add(wormName, score);
            }
        }

        int counter = 1;
        foreach (var pair in dictWorms.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))
        {
            Console.WriteLine($"{counter}. Team: {pair.Key} - {pair.Value.Values.Sum()}");

            foreach (var team in pair.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{team.Key} : {team.Value}");
            }
            counter++;
        }
    }
}

