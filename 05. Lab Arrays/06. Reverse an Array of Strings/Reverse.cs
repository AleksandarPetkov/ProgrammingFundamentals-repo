using System;
using System.Collections.Generic;
using System.Linq;

class Reverse
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] items = input.Split(' ');

        for (int i = items.Length-1; i >= 0; i--)
        {
            Console.Write(items[i]+" ");
        }
    }
}

