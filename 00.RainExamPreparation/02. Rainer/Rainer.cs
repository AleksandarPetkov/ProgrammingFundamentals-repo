using System;
using System.Collections.Generic;
using System.Linq;

class Rainer
{
    static void Main()
    {
        int[] sequances = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] numbers = new int[sequances.Length - 1];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = sequances[i];
        }

        int[] cloning = new int[numbers.Length];
        for (int i = 0; i < cloning.Length; i++)
        {
            cloning[i] = numbers[i];
        }
        
        int index = sequances[sequances.Length - 1];
        bool breakProgram = false;
        int steps = 0;
        while (true)
        {
           
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]--;
                
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[index] == 0)
                {
                    breakProgram = true;
                    break;
                }
            }

            if (breakProgram == true)
            {

                break;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = cloning[i];
                }

            }
            
            index = int.Parse(Console.ReadLine());
            steps++;
        }

        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine(steps);
      
    }
}

