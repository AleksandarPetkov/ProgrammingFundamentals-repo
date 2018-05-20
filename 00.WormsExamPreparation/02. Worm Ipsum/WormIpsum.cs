using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WormIpsum
{
    static void Main()
    {
        string patternValidSentences = @"^[A-Z][a-zA-Z0-9 ,-:]+\.$";

        List<string> result = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Worm Ipsum")
            {
                break;
            }
            string[] sentence = input.Split(new char[] { ' ', ',', '-','.',':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (Regex.IsMatch(input,patternValidSentences))
            {
                string replaceWord = "";
                foreach (var word in sentence)
                {
                    int bestCounter = -1;
                    char bestChar = ' ';
                    for (int i = 0; i < word.Length; i++)
                    {
                        int currentCounter = 0;

                        for (int j = 0; j < word.Length; j++)
                        {
                            if (word[j] == word[i])
                            {
                                currentCounter++;
                            }
                        }

                        if (currentCounter > bestCounter)
                        {
                            bestChar = word[i];
                            bestCounter = currentCounter;
                        }
                    }

                    if (bestCounter >= 2)
                    {
                        for (int i = 0; i < word.Length; i++)
                        {
                            replaceWord = replaceWord + bestChar;
                        }

                        input = input.Replace(word, replaceWord);
                        replaceWord = "";
                    }
                   
                }

                result.Add(input);
            }
           
        }

        Console.WriteLine(string.Join("\n",result));
    }
}

