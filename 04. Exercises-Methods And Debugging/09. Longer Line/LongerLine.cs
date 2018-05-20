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
        double x3= double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());
        ReturnFirstDistance(x1, y1, x2, y2);

    }

    static void ReturnFirstDistance(double x1, double x2, double y1, double y2)
    {
        double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));


        List<double> coordinats = new List<double>();

        if (distance1 >= distance2)
        {
            coordinats.Add(y2);
            coordinats.Add(x2);
        }
        else
        {
            coordinats.Add(y1);
            coordinats.Add(x1);
        }
        Console.Write("(");
        Console.Write(string.Join(", ", coordinats));
        Console.Write(")");
    }

   
}


