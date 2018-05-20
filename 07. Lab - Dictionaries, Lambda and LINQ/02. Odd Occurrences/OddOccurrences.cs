using System;
using System.Collections.Generic;

class OddOccurrences
{
    static void Main()
    {
        string[] words = Console.ReadLine().
            ToLower().
            Split(' ');

        Dictionary<string, int> counter = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (counter.ContainsKey(word))
            {
                counter[word]++;
            }
            else
            {
                counter[word] = 1;
            }
        }

        List<string> result = new List<string>();

        foreach (var item in counter)
        {
            if (item.Value % 2 == 1)
            {
                result.Add(item.Key);
            }
        }

        Console.WriteLine(string.Join(", ",result));
    }
}

