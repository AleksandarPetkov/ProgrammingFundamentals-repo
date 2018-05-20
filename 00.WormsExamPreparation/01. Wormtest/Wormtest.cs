using System;
using System.Collections.Generic;
using System.Linq;

class Wormtest
{
    static void Main()
    {
        int lenghtM = int.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        long lenghtInSM = lenghtM * 100;

        if (lenghtInSM % width == 0 || width == 0)
        {
            double product = lenghtInSM * width;
            Console.WriteLine($"{product:f2}");
        }
        else
        {
            double product = (lenghtInSM / width)*100;
            Console.WriteLine($"{product:f2}%");

        }
    }
}

