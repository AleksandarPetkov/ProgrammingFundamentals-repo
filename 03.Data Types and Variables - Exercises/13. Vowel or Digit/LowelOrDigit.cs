using System;

class LowelOrDigit
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());

        if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
        {
            Console.WriteLine("vowel");
        }
        else if (char.IsNumber(symbol))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
        
    }
}

