using System;

class RectangleProperties
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;

        double perimetar = 2 * width + 2 * height;

        double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

        Console.WriteLine(perimetar);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);

    }
}

