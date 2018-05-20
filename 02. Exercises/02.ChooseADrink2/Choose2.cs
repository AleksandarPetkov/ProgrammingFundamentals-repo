using System;

class Choose2
{
    static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        string liquid = string.Empty;

        double price = 0.00;

        if (profession == "Athlete")
        {
            liquid = "Water";
            price = quantity * 0.70;
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            liquid = "Coffee";
            price = quantity * 1.00;
        }
        else if (profession == "SoftUni Student")
        {
            liquid = "Beer";
            price = quantity * 1.70;
        }
        else
        {
            liquid = "Tea";
            price = quantity * 1.20;
        }

        Console.WriteLine($"The {profession} has to pay {price:f2}.");
    }
}

