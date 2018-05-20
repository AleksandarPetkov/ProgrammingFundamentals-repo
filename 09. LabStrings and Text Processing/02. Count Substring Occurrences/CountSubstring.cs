using System;
using System.Collections.Generic;
using System.Linq;

class CountSubstring
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();

        int foundIndex = -1;
        int counter = 0;

        while (true)
        {
            foundIndex = text.IndexOf(word, foundIndex + 1);
            if (foundIndex == -1)
            {
                break;
            }
            else
            {
                counter++;
            }

        }
        Console.WriteLine(counter);
    }
}

