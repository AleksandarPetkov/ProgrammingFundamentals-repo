using System;

class GameOfNumbers
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;
        bool itsTrue = true;

        for (int i = second; i >= first; i--)
        {
            for (int j = second; j >= first; j--)
            {
                counter++;

               

                if (j + i == magicNumber)
                {

                    Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                    itsTrue = false;
                    return;
                }
                
               
            }
        }

        Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");

    }
}

