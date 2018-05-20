using System;
using System.Collections.Generic;
using System.Linq;

class RainAir
{
    static void Main()
    {
        Dictionary<string, List<int>> dictFlyInfo = new Dictionary<string, List<int>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "I believe I can fly!")
            {
                break;
            }
            string[] inputArgs = input.Split(' ').ToArray();

            if (inputArgs[1] != "=")
            {
                string name = inputArgs[0];

                List<int> customerFlights = new List<int>();

                for (int i = 1; i <= inputArgs.Length - 1; i++)
                {
                    customerFlights.Add(int.Parse(inputArgs[i]));
                }

                if (dictFlyInfo.ContainsKey(name) == false)
                {
                   
                    dictFlyInfo.Add(name, customerFlights);
                }
                else
                {
                    dictFlyInfo[name].AddRange(customerFlights);
                }
            }
            else
            {
                //you should make the 1st customer’s flights equal to the 2nd customer’s flights.
                string name = inputArgs[0];
                string replaceName = inputArgs[2];

                dictFlyInfo[name] = dictFlyInfo[replaceName].ToList();
                
            }

        }

        foreach (var name in dictFlyInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"#{name.Key} ::: {string.Join(", ",name.Value.OrderBy(x => x))}");
        }
    }

    
}

