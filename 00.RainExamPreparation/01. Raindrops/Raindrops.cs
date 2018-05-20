using System;
using System.Collections.Generic;
using System.Linq;

class Raindrops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double dencity = double.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            long raindropsCount = long.Parse(input[0]);
            int squareMeters = int.Parse(input[1]);

            double regionalCoefficient = (double)raindropsCount / squareMeters;
            sum += regionalCoefficient;
        }

        if (dencity != 0)
        {
            double result = sum / dencity;
           
            Console.WriteLine($"{result:f3}");
        }
        else
        {
            Console.WriteLine($"{sum:f3}");
        }
    }
}

