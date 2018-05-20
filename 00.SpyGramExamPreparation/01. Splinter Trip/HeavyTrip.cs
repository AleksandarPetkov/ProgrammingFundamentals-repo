using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HeavyTrip
{
    static void Main()
    {
        checked
        {
            double distance = double.Parse(Console.ReadLine());
            double fuelTank = double.Parse(Console.ReadLine());
            double heavyWinds = double.Parse(Console.ReadLine());

            double miles = (distance - heavyWinds) * 25;
            double milesInBadCondition = heavyWinds * 25 * 1.5;

            double fuelConsumation = miles + milesInBadCondition;

            double tolerance = fuelConsumation - (fuelConsumation * 0.95);
            double resultFuel = fuelConsumation + tolerance;
            double remainingFuel = fuelTank - resultFuel;

            if (remainingFuel >= 0)
            {
                Console.WriteLine($"Fuel needed: {resultFuel:f2}L");
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"Fuel needed: {resultFuel:f2}L");
                Console.WriteLine($"We need {-remainingFuel:f2}L more fuel.");
            }
        }
    }
}

