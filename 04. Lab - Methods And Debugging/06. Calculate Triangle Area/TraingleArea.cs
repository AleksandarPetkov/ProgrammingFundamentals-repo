using System;

class TraingleArea
{
    static double TriangleArea(double width, double height)
    {
        return (width * height) / 2;
    }

    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = TriangleArea(width, height);
        Console.WriteLine(area);

    }
}

