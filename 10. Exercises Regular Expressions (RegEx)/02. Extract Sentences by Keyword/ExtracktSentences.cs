using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtracktSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = "\\b" + word + "\\b";

        string[] sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        Regex regex = new Regex(pattern);

        foreach (var sentec in sentences)
        {
            if (regex.IsMatch(sentec))
            {
                Console.WriteLine(sentec.Trim());
            }
        }
    }
}

