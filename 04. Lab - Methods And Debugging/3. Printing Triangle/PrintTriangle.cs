using System;

class PrintTriangle
{


    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static void PrintTriangleWithDigits(int input)
    {
        for (int i = 0; i <= input; i++)
        {
            PrintLine(1 , i);
        }

        for (int i = input-1; i >= 1; i--)
        {
            PrintLine(1, i);

        }
    }

    static void Main()
    {
        PrintTriangleWithDigits(int.Parse(Console.ReadLine()));

    }
}

