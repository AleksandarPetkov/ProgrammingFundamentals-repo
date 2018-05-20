using System;

class MagicLatter
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char control = char.Parse(Console.ReadLine());

        for (char i = firstLetter; i <= secondLetter; i++)
        {
            for (char j = firstLetter; j <= secondLetter; j++)
            {
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    if (i != control && j != control && k != control)
                    {
                        Console.Write($"{i}{j}{k} ");
                    }

                }
            }
        }
    }
}

