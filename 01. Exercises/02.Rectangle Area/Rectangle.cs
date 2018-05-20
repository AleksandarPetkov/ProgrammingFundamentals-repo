using System;

class Rectangle
{
    static void Main()
    {
        double with = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double sum = with * height;

        Console.WriteLine($"{sum:f2}");
    }
}

