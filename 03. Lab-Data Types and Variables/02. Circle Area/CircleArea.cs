using System;

class CircleArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double circleArea = radius * radius * Math.PI;

        Console.WriteLine($"{circleArea:f12}");
    }
}

