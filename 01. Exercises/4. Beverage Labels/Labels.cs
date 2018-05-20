using System;

class Labels
{
    static void Main()
    {
        //        Name – as per the input
        // Volume – integer, suffixed by “ml” (e.g. “220ml”)
        // Energy content – integer, suffixed by “kcal” (e.g. “500cw       kcal”)
        // Sugar content – integer, suffixed by “g” (e.g. “30g”)

        string name = Console.ReadLine();

        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        double kcal = (double)(volume * energy) / 100.00;
        double sugarContent = (double)(volume * sugar) / 100.00;


        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{kcal}kcal, {sugarContent}g sugars");

    }
}

