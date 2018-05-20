using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    

    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (input != "JOKER")
        {
            string[] commandArgs = input.Split(':');
            string name = commandArgs[0];
            string[] cardsArgs = commandArgs[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (!people.ContainsKey(name))
            {
                people.Add(name, new Dictionary<string, int>());
                AddCardsToPerson(people[name], cardsArgs);
            }
            else
            {
                AddCardsToPerson(people[name], cardsArgs);
            }

            input = Console.ReadLine();
        }
    }

    private static void AddCardsToPerson(Dictionary<string, int> person, string[] cardsArgs)
    {
        foreach (var card in cardsArgs)
        {
            if (!person.ContainsKey(card))
            {
                person.Add(card, GetCardValue(card));
            }

        }
    }

    private static int GetCardValue(string card)
    {
        int power = 0;
        switch (card[0])
        {
            case '2':  
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '2':
            case '2':
            case '2':
        }
    }
}

