﻿using System;

class PassOrFail
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if (grade < 3)
        {
            Console.WriteLine("Failed!");
        }
        else
        {
            Console.WriteLine("Passed!");
        }
    }
}

