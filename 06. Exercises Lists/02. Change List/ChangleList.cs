using System;
using System.Collections.Generic;
using System.Linq;

class ChangleList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        List<string> input = Console.ReadLine().Split(' ').ToList();

        while (input[0] != "odd" || input[0] != "even")
        {
            if (input[0] == "Delete")
            {
                int removedNumber = int.Parse(input[1]);
                numbers.RemoveAll(x => x == removedNumber);
            }
            else if (input[0] == "Insert")
            {
                var insertelement = int.Parse(input[1]);
                var insertPosition = int.Parse(input[2]);
                numbers.Insert(insertPosition, insertelement);
                
            }
            else if (input[0] == "Odd")
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 1)
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
                return;
            }
            else if (input[0] == "Even")
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
                return;
            }

            input = Console.ReadLine().Split(' ').ToList();
        }
    }
}

