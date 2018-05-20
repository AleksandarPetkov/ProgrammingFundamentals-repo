using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class MatchFullName
{
    static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+\ [A-Z][a-z]+\b";

        string names = Console.ReadLine();

        MatchCollection matchedNames = Regex.Matches(names, pattern); // (matchedNames) Взимам стринговете които ми 
                                                                      // отговарят на шаблона
        foreach (Match name in matchedNames)
        {
            Console.Write(name.Value + " ");
        }
        Console.WriteLine();
    }
}

