﻿using System;

class TraingleOfNum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        

        for (int i = 1; i <= number; i++)
        {
            for (int a = 1; a <= i; a++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }
        
        
    }
}

