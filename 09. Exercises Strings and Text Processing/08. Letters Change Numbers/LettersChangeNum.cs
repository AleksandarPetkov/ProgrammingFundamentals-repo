using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LettersChangeNum
{
    static void Main()
    {
        string[] input = Console.ReadLine().
            Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        double sum = 0;
       
       

        foreach (var word in input)
        {
            var firstLetter = word.First();
            var lastLetter = word.Last();
            double number = double.Parse( word.Substring(1, word.Length - 2));
            double tempSum = 0;


            if (char.IsLower(firstLetter)) // Друг вариянт: if(firstLetter >= 97 && firtLetter <=122)
            {
                tempSum = number * (firstLetter - ('a' - 1));
            }
            else
            {
                tempSum = number / (firstLetter - ('A' - 1));
            }

            if (char.IsLower(lastLetter))
            {
                tempSum +=  lastLetter - ('a' - 1);
            }
            else
            {
                tempSum -=  lastLetter - ('A' - 1);
            }

            sum += tempSum;
            
        }
        Console.WriteLine($"{sum:f2}");
    }
}

