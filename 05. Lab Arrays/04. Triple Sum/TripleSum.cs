using System;
using System.Collections.Generic;
using System.Linq;

class TripleSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 0;

        for (int a = 0; a < numbers.Length; a++)
        {
            for (int b = a + 1; b < numbers.Length; b++)
            {
                int result = numbers[a] + numbers[b];

                if (numbers.Contains(result))// Чрез .Contains() Проверявам дали в масива съдържа исканото условие
                {
                    Console.WriteLine($"{numbers[a]} + {numbers[b]} == {result}");
                    counter++;
                    
                }
               
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}

