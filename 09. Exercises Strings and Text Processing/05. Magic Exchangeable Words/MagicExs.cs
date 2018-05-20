using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicExs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        char[] firstWord = input[0].ToCharArray().Distinct().ToArray();
        char[] secondWord = input[1].ToCharArray().Distinct().ToArray();

        if (firstWord.Length == secondWord.Length)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");

        }
    }
}

