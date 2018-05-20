using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PokemonDontGo
{
    static void Main()
    {
        List<int> elements = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            ToList();

        long sum = 0;
        while (elements.Count() != 0)
        {
            int index = int.Parse(Console.ReadLine());

            int manipulateNumber = 0;

            if (index > elements.Count - 1)
            {
                manipulateNumber = elements[elements.Count - 1];
                elements[elements.Count - 1] = elements[0];
            }
            else if (index < 0)
            {
                manipulateNumber = elements[0];
                elements[0] = elements[elements.Count - 1];
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (index == i)
                {
                    manipulateNumber = elements[i];
                  
                    elements.RemoveAt(i);
                    break;
                }
              
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] <= manipulateNumber)
                {
                    elements[i] += manipulateNumber;
                }
                else
                {
                    elements[i] -= manipulateNumber;
                } 
            }
            sum += manipulateNumber;
        }
        Console.WriteLine(sum);
    }
}

