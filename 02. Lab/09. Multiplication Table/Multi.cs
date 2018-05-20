using System;

class Multi
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum = i * num;
            Console.WriteLine($"{num} X {i} = {sum}");
        }
    }
}

