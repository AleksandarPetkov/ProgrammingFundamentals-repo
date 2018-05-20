using System;

class ReverseInteger
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] numbers = new int[input];
        for (int i = 0; i < input; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = input-1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

