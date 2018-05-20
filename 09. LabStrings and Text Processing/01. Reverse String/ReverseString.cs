using System;
using System.Collections.Generic;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray(); 
        string reversed = string.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine(reversed);
       
    }
}

