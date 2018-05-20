using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        foreach (var lettar in text)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)lettar));
        }

        Console.WriteLine(string.Join("/",sb));

    
    }
}

