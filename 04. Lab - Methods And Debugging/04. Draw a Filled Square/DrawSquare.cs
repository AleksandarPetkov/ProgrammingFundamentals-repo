using System;

class DrawSquare
{
    static void TopAndBottonLines(int n)
    {
        Console.WriteLine("{0}",new string('-',n*2));
    }

    static void MiddleOfSquare(int num)
    {
        for (int j = 0; j < num/2; j++)
        {
            Console.Write("-");
            for (int i = 0; i < num - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
       
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        TopAndBottonLines(number);
        MiddleOfSquare(number);
        TopAndBottonLines(number);
    }
}

