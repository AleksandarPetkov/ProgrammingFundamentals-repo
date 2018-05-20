using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class KeyReplacer
{
    static void Main()
    {
        string input = Console.ReadLine();

        string startKey = @"^[a-zA-Z]+[<|\\]";
        string endKey = @"[<|\\][a-zA-Z]+$";

        Match firstKey = Regex.Match(input, startKey);
        Match secondKey = Regex.Match(input, endKey);

        string firstK = firstKey.Value.TrimEnd('<', '|', '\\');
        string secondtK = secondKey.Value.TrimStart('<', '|', '\\');

        string pattern = $"({firstK})(.*?)({secondtK})";

        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match item in matches)
        {
            sb.Append(item.Groups[2].Value);
        }

        Console.WriteLine(sb.Length > 1 ? sb.ToString() : "Empty result");
    }
}

