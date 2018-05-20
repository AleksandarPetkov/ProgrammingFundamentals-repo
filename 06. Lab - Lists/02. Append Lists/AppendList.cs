using System;
using System.Collections.Generic;
using System.Linq;

class AppendList
{
    static void Main()
    {
        List<string> input = Console.ReadLine().
            Split('|').ToList();
        
        List<string> tokens = new List<string>();
        List<string> result = new List<string>();

        for (int i = input.Count-1; i >= 0; i--)
        {
            tokens.Add(input[i]);
        }

        foreach (var token in tokens)
        {
            List<string> numbers = token.Split(' ').ToList();

            foreach (var num in numbers)
            {
                if (num != "")
                {
                    result.Add(num);
                }
            }
        }
       
        Console.WriteLine(string.Join(" ",result));
    }
}

