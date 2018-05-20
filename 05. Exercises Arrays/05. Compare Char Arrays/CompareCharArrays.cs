using System;
using System.Collections.Generic;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstLetters = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] secondLetters = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        if (firstLetters.Length == secondLetters.Length)
        {
            if (firstLetters[0] < secondLetters[0])
            {
                Console.WriteLine(firstLetters);
                Console.WriteLine(secondLetters);

            }
            else
            {
                Console.WriteLine(secondLetters);
                Console.WriteLine(firstLetters);

            }
        }
        else if (firstLetters.Length > secondLetters.Length)
        {
            Console.WriteLine(secondLetters);
            Console.WriteLine(firstLetters);

        }
        else
        {
            Console.WriteLine(firstLetters);
            Console.WriteLine(secondLetters);
        }

    }
}
        
    

