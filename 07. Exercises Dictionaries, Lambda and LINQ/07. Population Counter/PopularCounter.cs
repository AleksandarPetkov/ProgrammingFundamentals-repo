using System;
using System.Collections.Generic;
using System.Linq;

class PopularCounter
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> countriesArgs = new Dictionary<string, Dictionary<string, long>>();

        string input = Console.ReadLine();

        while (input != "report")
        {
            string[] commandsArgs = input.Split('|');
            string country = commandsArgs[1];
            string city = commandsArgs[0];
            long population = long.Parse(commandsArgs[2]);

            if (!countriesArgs.ContainsKey(country))
            {
                countriesArgs.Add(country, new Dictionary<string, long>());// инициализирам си Dictionary
                countriesArgs[country].Add(city, population); // След това си запълвам второто Dictionary
            }
            else
            {
                if (!countriesArgs[country].ContainsKey(city)) // Ако в дадената държава Не съдържа даденият city
                {                                              // Тогава го добави
                    countriesArgs[country].Add(city, population);
                }
            }

            input = Console.ReadLine();
        }

        //countriesArgs = countriesArgs.OrderBy(n => n.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);
        // n - Country ; Value - Cyty ; Value - Popilation : <- Решение на един ред

        foreach (var county in countriesArgs.OrderByDescending(n => n.Value.Values.Sum()))
        {          // n - Country ; Value - Cyty ; Value - Popilation (Взимам Value.Values)

            // Друг вариянт да взема сумата е с List<int> popilationOfCities = country.Value.Select(x => x.Value).ToList();
            Console.WriteLine($"{county.Key} (total population: {county.Value.Values.Sum()})");

            foreach (var city in county.Value.OrderByDescending(c => c.Value))// Сортирам по големината на population
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }

        }
    }
}

