using System;

class HelloName
{
    static void Main()
    {
        PrintName(Console.ReadLine());
    }

    static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

