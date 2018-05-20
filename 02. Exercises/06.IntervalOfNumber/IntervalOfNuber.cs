using System;

class IntervalOfNuber
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        if (second > first)
        {
            for (int i = first; i <= second; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = second; i <= first; i++)
            {
                Console.WriteLine(i);
            }
        }

        
    }
}

