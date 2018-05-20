using System;

class CountTheInt
{
    static void Main()
    {
        int counter = 0;

        try
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(counter);
        }
    }
}

