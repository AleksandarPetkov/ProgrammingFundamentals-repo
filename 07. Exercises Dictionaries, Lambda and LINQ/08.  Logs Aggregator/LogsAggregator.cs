using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Input Format city|country|population

//Countries should be ordered by their total population in descending order 
//cities should be ordered by the same criterion.

class Practise
{
    static void Main()
    {
        SortedDictionary<string, SortedDictionary<string, int>> dictUsersLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputArgs = input.Split(' ');

            string name = inputArgs[1];
            string ip = inputArgs[0];
            int duration = int.Parse(inputArgs[2]);

            if (!dictUsersLogs.ContainsKey(name))
            {
                dictUsersLogs.Add(name, new SortedDictionary<string, int>());

            }
            if (!dictUsersLogs[name].ContainsKey(ip))
            {
                dictUsersLogs[name][ip] = 0;
            }
            dictUsersLogs[name][ip] += duration;

        }


        foreach (var user in dictUsersLogs)
        {
            Console.Write($"{user.Key}:");

            var totalDuraion = dictUsersLogs[user.Key].Values.Sum();// how to extract Sum f
            
            var listOfIps = user.Value.Keys.ToList();

            Console.WriteLine($" {totalDuraion} [{string.Join(", ", listOfIps)}]");
        }
    }
}


