using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class UseYourChains
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"<p>(?<message>.*?)<\/p>";

        MatchCollection matchedWords = Regex.Matches(text, pattern);

        string extract = "";

        foreach (Match match in matchedWords)
        {
            extract += match.Groups["message"].ToString();

        }

        //replace symbols with space
        string replacePattern = @"([^a-z0-9]+)";

        //Regex regex = new Regex(replacePattern);
        extract = Regex.Replace(extract, replacePattern, " ");

        //replace multiply spaces with single
        extract = Regex.Replace(extract, @"\s+|\n+", " ");

        //convert letters
        StringBuilder sb = new StringBuilder(extract.Length);

        foreach (char ch in extract)
        {

            if (ch >= 'a' && ch <= 'm')
            {
                sb.Append((char)(ch + 13));
            }
            else if (ch >= 'n' && ch <= 'z')
            {
                sb.Append((char)(ch - 13));
            }
            else
            {
                sb.Append(ch);
            }

        }

        //print result
        string result = sb.ToString();
        Console.WriteLine(result);
    }
}

