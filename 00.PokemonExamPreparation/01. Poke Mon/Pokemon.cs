using System;
using System.Collections.Generic;
using System.Linq;

class Pokemon
{
    static void Main()
    {
        int pokePower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        double halfPower = (double)pokePower / 2.00;

        int count = 0;
        while (pokePower >= distance)
        {
            if (pokePower == halfPower && exhaustionFactor != 0)
            {
                pokePower = pokePower / exhaustionFactor;
                int currentPokePower = pokePower - distance;
                if (currentPokePower > distance)
                {
                    count++;
                    pokePower -= distance;
                }
                else
                {
                    break;
                }
              
            }
            else
            {
                pokePower -= distance;
                count++;
            }

            
        }
        Console.WriteLine(pokePower);
        Console.WriteLine(count);
    }
}

