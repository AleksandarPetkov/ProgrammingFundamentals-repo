using System;

class Back
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minuts = int.Parse(Console.ReadLine());

        int currentHour = ((hours * 60) + minuts + 30) / 60;
        int currentMinuts = ((hours * 60) + minuts + 30) % 60;

        if (currentHour == 24)
        {
            currentHour = 0;
        }

        Console.WriteLine($"{currentHour}:{currentMinuts:d2}");


    }
}

