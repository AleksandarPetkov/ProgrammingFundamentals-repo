using System;
using System.Collections.Generic;
using System.Linq;

class Trainers
{
    static void Main()
    {
        int participants = int.Parse(Console.ReadLine());

        double moneyTech = 0.0;
        double moneyTheo = 0.0;
        double moneyPract = 0.0;
        for (int i = 0; i < participants; i++)
        {
            long distance = long.Parse(Console.ReadLine()) * 1600;
            double cargo = double.Parse(Console.ReadLine())* 1000;
            string team = Console.ReadLine();

            if (team == "Technical")
            {
                moneyTech += (cargo * 1.5) - (0.7 * distance * 2.5);
            }
            else if (team == "Theoretical")
            {
                moneyTheo += (cargo * 1.5) - (0.7 * distance * 2.5);
            }
            else if (team == "Practical")
            {
                moneyPract += (cargo * 1.5) - (0.7 * distance * 2.5);
            }
        }
        if (moneyTech > moneyTheo && moneyTech > moneyPract)
        {
            Console.WriteLine($"The Technical Trainers win with ${moneyTech:f3}.");
            return;
        }
        else if (moneyTheo > moneyTech && moneyTheo > moneyPract)
        {
            Console.WriteLine($"The Theoretical Trainers win with ${moneyTheo:f3}.");
            return;
        }
        else if (moneyPract > moneyTech && moneyPract > moneyTheo)
        {
            Console.WriteLine($"The Practical Trainers win with ${moneyPract:f3}.");
            return;
        }
       
    }
}

