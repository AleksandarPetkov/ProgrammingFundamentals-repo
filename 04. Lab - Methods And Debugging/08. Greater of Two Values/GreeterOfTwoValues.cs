using System;

class GreeterOfTwoValues
{
   

    static void Main() // Main Main
    {
        var type = Console.ReadLine();

        if (type == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string GetMax =  MaxOfTwoStrings(first, second);
            Console.WriteLine(GetMax);

        }
        else if (type == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int GetMax = MaxOfTwoIntegers(first, second);
            Console.WriteLine(GetMax);

        }
        else if (type == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char GetMax = MaxOfTwoCharackters(first, second);
            Console.WriteLine(GetMax);
        }
    }

    static int MaxOfTwoIntegers(int one, int two)
    {

        return Math.Max(one, two);
    }

    static char MaxOfTwoCharackters(char one, char two)
    {


        if (one < two)
        {
            return two;
        }
        else
        {
            return one;
        }
    }

    static string MaxOfTwoStrings(string one, string two)
    {

        if (one.CompareTo(two) >= 0)
        {
            return one;
        }
        else
        {
            return two;
        }
    }


}

