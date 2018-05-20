using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        int distanceInMetars = int.Parse(Console.ReadLine());

        byte hours = byte.Parse(Console.ReadLine());
        byte minuts = byte.Parse(Console.ReadLine());
        byte second = byte.Parse(Console.ReadLine());

        ushort time = (ushort)(hours * 3600 + minuts * 60 + second);

        float metarPerSecond = (float)distanceInMetars / time;
        float kilometarsPerHour = ((float)distanceInMetars / 1000) / ((float)time / 3600);
        float milesPerHour = ((float)distanceInMetars / 1609) / ((float)time / 3600);

        Console.WriteLine(metarPerSecond);
        Console.WriteLine(kilometarsPerHour);
        Console.WriteLine(milesPerHour);

    }
}

