using System;

class Calories
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        int caloures = 0;
        int counter = 0;
       

        for (int i = 0; i < numbers; i++)
        {
            string ingredients = Console.ReadLine().ToLower();
            counter++;

            if (counter > 20)
            {
                break;
            }

            if (ingredients == "cheese")
            {
                caloures += 500;
            }
            else if (ingredients == "tomato sauce")
            {
                caloures += 150;
            }
            else if (ingredients == "salami")
            {
                caloures += 600;
            }
            else if (ingredients == "pepper")
            {
                caloures += 50;
            }
        }

        Console.WriteLine($"Total calories: {caloures}");
    }
}

