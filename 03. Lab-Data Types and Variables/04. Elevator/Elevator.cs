using System;

class Elevator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int curses = (int)Math.Ceiling(n / (double)p); // За да работи MathCeiling каствам към double , и после цялото към int

        Console.WriteLine(curses);
    }
}

