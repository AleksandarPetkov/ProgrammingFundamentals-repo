using System;
using System.Collections.Generic;
using System.Linq;

class Entertrain
{
    static void Main()
    {
        List<long> wagons = new List<long>();

        int locoPower = int.Parse(Console.ReadLine());

        int counter = 1;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "All ofboard!")
            {
                break;
            }
            int wagon = int.Parse(input);

            wagons.Add(wagon);
            if (wagons.Sum() > locoPower)
            {
                long locoAvarage = wagons.Sum() / counter; // integerDivision

                RemoveClosestWagon(wagons, locoAvarage);
              
            }

            counter++;
        }
        wagons.Insert(0, locoPower);
        wagons.Reverse();
        Console.WriteLine(string.Join(" ",wagons));
      
    }

    static void RemoveClosestWagon(List<long> wagons, long avarage)
    {
        
        long currentWagons = 0;
        long closestWagon = long.MaxValue;
        int removedIndex = 0;

        for (int i = 0; i < wagons.Count; i++)
        {
            currentWagons = Math.Abs(wagons[i] - avarage);

            if (currentWagons < closestWagon)
            {
                closestWagon = currentWagons;
                removedIndex = i;
            }
        }
        wagons.RemoveAt(removedIndex);
    }
}

