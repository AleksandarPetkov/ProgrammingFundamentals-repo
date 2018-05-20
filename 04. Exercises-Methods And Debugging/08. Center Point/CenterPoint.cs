using System;
using System.Collections.Generic;

class CenterPoint
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distance1 = ReturnDistance(x1, y1);
        double distance2 = ReturnDistance(x2, y2);

        List<double> coordinats = new List<double>();

        if (distance1 >= distance2)
        {
            coordinats.Add(x2);
            coordinats.Add(y2);
        }
        else
        {
            coordinats.Add(x1);
            coordinats.Add(y1);
        }
        Console.Write("(");
        Console.Write(string.Join(", ",coordinats));
        Console.Write(")");
    }

    static double ReturnDistance(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distance;
    }
}

