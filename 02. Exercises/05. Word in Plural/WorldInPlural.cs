using System;

class WorldInPlural
{
    static void Main()
    {
        string word = Console.ReadLine();

        if (word.EndsWith("ch") || word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
        {
            Console.WriteLine(word + "es");
        }
        else if (word.EndsWith("y"))
        {
            word = word.Remove(word.Length - 1);

            Console.WriteLine(word + "ies");
        }
        else
        {
            Console.WriteLine(word + "s");
        }
       
      
    }
}

