using System;

class SumOdd
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= num * 2; i+= 2)
        {
            Console.WriteLine(i);
            sum += i;
            
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

