using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        string[] words = Console.ReadLine().
            ToLower().
            Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' },
            StringSplitOptions.RemoveEmptyEntries).
            ToArray();

        List<string> elements = new List<string>();

        foreach (var word in words)
        {
            if (word.Length < 5)
            {
                elements.Add(word);
            }
        }
        List<string> result = elements.OrderBy(x => x).Distinct().ToList();
       
        Console.WriteLine(string.Join(", ", result));
    }
}

