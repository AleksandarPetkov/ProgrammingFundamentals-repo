using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Wormhole
{
    static void Main()
    {
        int[] wormholes = Console.ReadLine().
             Split(' ').
             Select(int.Parse).ToArray();

        int streps = 0;

        for (int i = 0; i < wormholes.Length; i++)
        {
            if (wormholes[i] == 0)
            {
                streps++;
            }
            else
            {
                int currentHole = wormholes[i];
                wormholes[i] = 0;
                i = currentHole;
                streps++;
            }
        }
        Console.WriteLine(streps);
        
    }
}

