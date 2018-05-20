using System;

class DifferentIntegers
{
    static void Main()
    {

        long number = long.Parse(Console.ReadLine());
        try
        {
            
            if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine($"{number} can fit in:");
            }
            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {

                Console.WriteLine("* sbyte");
            }
            if (number >= byte.MinValue && number <= byte.MaxValue)
            {


                Console.WriteLine("* byte");

            }
            if (number >= short.MinValue && number <= short.MaxValue)
            {


                Console.WriteLine("* short");

            }
            if (number >= ushort.MinValue && number <= ushort.MaxValue)
            {


                Console.WriteLine("* ushort");

            }
            if (number >= int.MinValue && number <= int.MaxValue)
            {


                Console.WriteLine("* int");

            }
            if (number >= uint.MinValue && number <= uint.MaxValue)
            {


                Console.WriteLine("* uint");

            }
            if (number >= long.MinValue && number <= long.MaxValue)
            {


                Console.WriteLine("* long");

            }
            else
            {
                Console.WriteLine("can't fit in any type");
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"{number} can't fit in any type");
        }
       


    }
}

