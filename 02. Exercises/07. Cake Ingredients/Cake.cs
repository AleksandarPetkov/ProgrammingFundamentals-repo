using System;

class Cake
{
    static void Main()
    {

        string input = Console.ReadLine();

        int counter = 0;

        while (input != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {input}.");
            input = Console.ReadLine();
            counter++;

            if (counter > 20)
            {
                break;
            }
        }

        Console.WriteLine($"Preparing cake with {counter} ingredients.");
    }
}

