using System;

class Debitcard
{
    static void Main()
    {
        int pin1 = int.Parse(Console.ReadLine());
        int pin2 = int.Parse(Console.ReadLine());
        int pin3 = int.Parse(Console.ReadLine());
        int pin4 = int.Parse(Console.ReadLine());


        Console.WriteLine($"{pin1:d4} {pin2:d4} {pin3:d4} {pin4:d4}");
    }
}

