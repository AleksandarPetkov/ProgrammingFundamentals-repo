﻿using System;

class CenturiesToMinuts
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;

        int days = (int)(years * 365.2422);

        int hours = days * 24;

        long minuts = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minuts} minutes");  
    }
}

