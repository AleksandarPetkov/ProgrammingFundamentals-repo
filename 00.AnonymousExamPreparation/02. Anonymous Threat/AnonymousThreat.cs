using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AnonymousThreat
{
    static void Main()
    {
        List<string> words = Console.ReadLine().Split(' ').ToList();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "3:1")
            {
                break;
            }
            string[] commandArgs = input.Split(' ').ToArray();

            if (commandArgs[0] == "merge")
            {
                MergeWordsInSequances(words, commandArgs);
            }
            else if (commandArgs[0] == "divide")
            {
                DivideWordsInSequances(words, commandArgs);
            }
        }

        Console.WriteLine(string.Join(" ",words));
    }

    static void DivideWordsInSequances(List<string> words, string[] commandArgs)
    {
        int index = int.Parse(commandArgs[1]);
        int partitions = int.Parse(commandArgs[2]);

        List<string> parts = new List<string>();
        string current = "";
        for (int i = 0; i < words.Count; i++)
        {
          
            if (index == i)
            {
                current = words[index];
                int wordLenghtParts = words[i].Length / partitions;
                for (int j = 0; j < partitions; j++)
                {
                    parts.Add(current.Substring(0, wordLenghtParts));
                    current = current.Remove(0, wordLenghtParts);
                   
                }
                words.RemoveAt(index);
                break;
            }
           
        }

        parts[parts.Count - 1] = parts[parts.Count - 1] + current;
        //With insertRange:
        words.InsertRange(index,parts);

        //Or:
        //for (int j = 0; j < partitions; j++)
        //{
        //    words.Add(parts[j]);

        //}
       
        //if (current.Lenght > 0)
        //{
        //    words[words.Count - 1] = words[words.Count - 1] + current;
        //}
    }

    static void MergeWordsInSequances(List<string> words, string[] commandArgs)
    {
        int start = int.Parse(commandArgs[1]);
        int end = int.Parse(commandArgs[2]);

        if (start < 0)
        {
            start = 0;
        }
        if (end >= words.Count) // if (end > words.Count-1 )
        {
            end = words.Count - 1;
        }

        for (int i = start; i < end; i++)
        {
            words[start] = words[start] + words[start + 1];
            words.RemoveAt(start+1);
        }
    }

    
}

