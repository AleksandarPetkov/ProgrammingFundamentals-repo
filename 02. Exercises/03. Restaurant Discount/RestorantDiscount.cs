using System;

class RestorantDiscount
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        double price = 0.00;
        string place = string.Empty;
        double discount = 0;

        if (groupSize <= 50)
        {
            price = 2500;
            place = "Small Hall";
        }
        else if (groupSize > 50 && groupSize <= 100)
        {
            price = 5000;
            place = "Terrace";
        }
        else if (groupSize > 100 && groupSize <= 120)
        {
            price = 7500;
            place = "Great Hall";
        }
        else if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        

        if (package == "Normal")
        {
            price += 500;
            discount = 0.95;

        }
        else if (package == "Gold")
        {
            price += 750;
            discount = 0.90;
        }
        else if (package == "Platinum")
        {
            price += 1000;
            discount = 0.85;

        }

        double dicountPrice = price * discount;

        double priceForPerson = dicountPrice / groupSize;

        Console.WriteLine($"We can offer you the {place}");
        Console.WriteLine($"The price per person is {priceForPerson:f2}$");
    }
}

