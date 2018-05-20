using System;
using System.Collections.Generic;
using System.Linq;

class CharacterMultiplier
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        char[] firstWord = input[0].ToCharArray();
        char[] secondWord = input[1].ToCharArray();
        long sum = 0;
        int lowestLenght = Math.Min(firstWord.Length, secondWord.Length);
        int biggestLenght = Math.Max(firstWord.Length, secondWord.Length);
        string substring = string.Empty;
        int counter = 0;

        if (firstWord.Length == secondWord.Length)
        {
            for (int i = 0; i < firstWord.Length; i++)
            {
                sum += (int)firstWord[i] * (int)secondWord[i];
            }
            Console.WriteLine(sum);
            return;
        }
        else
        {
            for (int i = 0; i < lowestLenght; i++)
            {
                sum += firstWord[i] * secondWord[i];
                counter++;
  
            }

            if (firstWord.Length > secondWord.Length)
            {
                string word1 = new string(firstWord);
                substring = word1.Substring(counter);
                char[] secondSum = substring.ToCharArray();

                for (int i = 0; i < secondSum.Length; i++)
                {
                    sum += (int)secondSum[i];
                }
               
            }
            else
            {
                string word2 = new string(secondWord);
                substring = word2.Substring(counter);
                char[] secondSum = substring.ToCharArray();

                for (int i = 0; i < secondSum.Length; i++)
                {
                    sum += (int)secondSum[i];
                }
            }

            
        }
        Console.WriteLine(sum);
    }
}

