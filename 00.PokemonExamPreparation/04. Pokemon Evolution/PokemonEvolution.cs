using System;
using System.Collections.Generic;
using System.Linq;

class PokemonEvolution
{
    static void Main()
    {
        Dictionary<string, List<string>> dictPokemons = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "wubbalubbadubdub")
            {
                break;
            }
            string[] inputArgs = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = inputArgs[0];


            if (inputArgs.Length == 1)
            {
                if (dictPokemons.ContainsKey(name))
                {
                    Console.WriteLine($"# {name}");
                    foreach (var details in dictPokemons[name])
                    {
                        Console.WriteLine($"{details}");
                    }
                }
            }
            else
            {
                string pokDetails = inputArgs[1] + " <-> " + inputArgs[2];

                if (dictPokemons.ContainsKey(name) == false)
                {
                    dictPokemons.Add(name, new List<string>());
                    dictPokemons[name].Add(pokDetails);
                }
                else
                {
                    dictPokemons[name].Add(pokDetails);
                }
            }

        }

        foreach (var pair in dictPokemons)
        {
            Console.WriteLine($"# {pair.Key}");

            foreach (var ev in pair.Value.OrderByDescending(x =>
            int.Parse(x.Split(new char[] { '<', '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).First())))
            {
                Console.WriteLine($"{ev}");
            }

        }
    }
}

