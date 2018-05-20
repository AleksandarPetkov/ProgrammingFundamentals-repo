using System;

class TestNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                counter++;
                sum += 3 * (i * j);

                if (sum >= stop )
                {
                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {sum} >= {stop}");
                    return;
                }
                
                   
                
                
            }
        }

        Console.WriteLine($"{counter} combinations");
        Console.WriteLine($"Sum: {sum}");

    }
}

