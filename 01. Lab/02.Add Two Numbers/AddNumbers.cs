using System;

class AddNumbers
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int sum = first + second;

        Console.WriteLine($"{first} + {second} = {sum}");

    }
}

