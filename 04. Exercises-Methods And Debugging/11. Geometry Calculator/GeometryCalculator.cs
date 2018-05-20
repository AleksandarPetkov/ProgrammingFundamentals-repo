using System;
using System.Collections.Generic;

class GeometryCalculator
{
    static void Main()
    {
        string type = Console.ReadLine();

        if (type == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            PrintTriangleArea(side, height);
        }
        else if (type == "square")
        {
            double side = double.Parse(Console.ReadLine());
            PrintSquareleArea(side);
        }
        if (type == "rectangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            PrintRectangleleArea(side, height);
        }
        else if (type == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            PrintCircleArea(radius);
        }

    }

    static double PrintTriangleArea(double side , double height)
    {
        double triangleArea = (side * height) / 2;
        Console.WriteLine($"{triangleArea:f2}");
        return triangleArea;
    }

    static double PrintSquareleArea(double side)
    {
        double squareleArea = Math.Pow(side, 2);
        Console.WriteLine($"{squareleArea:f2}");
        return squareleArea;
    }

    static double PrintRectangleleArea(double side, double height)
    {
        double rectangleleArea = side * height;
        Console.WriteLine($"{rectangleleArea:f2}");
        return rectangleleArea;
    }

    static double PrintCircleArea(double radius)
    {
        double circleArea = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"{circleArea:f2}");
        return circleArea;
    }
}

