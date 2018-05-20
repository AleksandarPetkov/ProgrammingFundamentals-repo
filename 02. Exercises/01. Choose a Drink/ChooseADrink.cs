using System;

class ChooseADrink
{
    static void Main()
    {
        string profession = Console.ReadLine();

        string liquid = string.Empty;

        if (profession == "Athlete")
        {
            liquid = "Water";
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            liquid = "Coffee";
        }
        else if (profession == "SoftUni Student")
        {
            liquid = "Beer";
        }
        else
        {
            liquid = "Tea";
        }

        Console.WriteLine(liquid);
       
    }
}

