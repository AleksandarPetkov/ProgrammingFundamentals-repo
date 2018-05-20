using System;

class CharacterStats
{
    static void Main()
    {
        string name = Console.ReadLine();

        int healt = int.Parse(Console.ReadLine());
        int maxHealt = int.Parse(Console.ReadLine());

        int energy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());
       

        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Health: |{0}{1}|",new string('|',healt),new string('.',maxHealt-healt));

        Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', maxEnergy - energy));


    }
}
