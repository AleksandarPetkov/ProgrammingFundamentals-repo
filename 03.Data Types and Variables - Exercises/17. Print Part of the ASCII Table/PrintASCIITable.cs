using System;

class PrintASCIITable
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        for (char i = (char)first; i <= second; i++)
        {
            Console.Write($"{i} ");
        }

    }
}

