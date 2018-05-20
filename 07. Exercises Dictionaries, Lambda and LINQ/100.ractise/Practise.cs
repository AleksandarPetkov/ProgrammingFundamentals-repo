using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


class Practise
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> dictUsers = new Dictionary<string, Dictionary<string, int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputArgs = input.Split(' ');
            string ip = inputArgs[0];
            string user = inputArgs[1];
            int duration = int.Parse(inputArgs[2]);

            if (dictUsers.ContainsKey(user) == false)
            {
                dictUsers.Add(user, new Dictionary<string, int>());
            }

            if (dictUsers[user].ContainsKey(ip) == false)
            {
                dictUsers[user].Add(ip, duration);
            }
            else
            {
                dictUsers[user][ip] += duration;
            }
        }

        foreach (var user in dictUsers.OrderBy(x => x.Key))
        {
            Console.Write($"{user.Key}: ");
            int sumDuration = dictUsers[user.Key].Values.Sum();

            List<string> ips = user.Value.Keys.OrderBy(x => x).ToList();
            Console.WriteLine($"{sumDuration} [{string.Join(", ",ips)}]");
        }
    }
 
}
   


