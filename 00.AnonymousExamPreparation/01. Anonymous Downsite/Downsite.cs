using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Downsite
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());

        List<string> affectedSites = new List<string>();
        decimal totalLoss = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            string[] sitesArgs = Console.ReadLine().Split(' ').ToArray();

            string siteName = sitesArgs[0];
            long siteVisits = long.Parse(sitesArgs[1]);
            decimal pricePerVisit = decimal.Parse(sitesArgs[2]);
            decimal siteLoss = siteVisits * pricePerVisit;
            totalLoss += siteLoss;
            count++;
            affectedSites.Add(siteName);
        }

        BigInteger secToken = BigInteger.Pow(securityKey, count);

        foreach (var site in affectedSites)
        {
            Console.WriteLine(site);
        }
        Console.WriteLine($"Total Loss: {totalLoss:f20}");
        Console.WriteLine($"Security Token: {secToken}");
    }
}

