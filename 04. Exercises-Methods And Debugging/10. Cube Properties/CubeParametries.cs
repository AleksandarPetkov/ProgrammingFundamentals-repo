using System;
using System.Collections.Generic;

class CubeParametries
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        string type = Console.ReadLine();

        if (type == "area")
        {
            ReturnAreaOfCube(side);
        }
        else if (type == "volume")
        {
            ReturnVolumeOfCube(side);
        }
        else if (type == "space")
        {
            ReturnSpaceOfCube(side);
        }
        else if (type == "face")
        {
            ReturnFaceOfCube(side);
        }
    }

    static double ReturnAreaOfCube(double a)
    {
        double area = 6 * Math.Pow(a, 2);
        Console.WriteLine($"{area:f2}");
        return area;
    }

    static double ReturnVolumeOfCube(double a)
    {
        double volume = Math.Pow(a, 3);
        Console.WriteLine($"{volume:f2}");

        return volume;
    }

    static double ReturnSpaceOfCube(double a)
    {
        double space = Math.Sqrt(3 * Math.Pow(a, 2));
        Console.WriteLine($"{space:f2}");

        return space;
    }

    static double ReturnFaceOfCube(double a)
    {
        double face = Math.Sqrt(2 * Math.Pow(a, 2));
        Console.WriteLine($"{face:f2}");

        return face;
    }
}

