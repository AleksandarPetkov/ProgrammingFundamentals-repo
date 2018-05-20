using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CameraView
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"\b([a-zA-Z]\w{2,24})\b";

        MatchCollection matchedUsernames = Regex.Matches(text, pattern);
    }
}

