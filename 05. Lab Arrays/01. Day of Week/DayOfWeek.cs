using System;
using System.Collections.Generic;
using System.Linq;

class DayOfWeek
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        if (day < 1 || day > 7)
        {
            Console.WriteLine("Invalid Day!");
            return;
        }
        else
        {
            Console.WriteLine(daysOfWeek[day - 1]);
        }
        
    }
}

